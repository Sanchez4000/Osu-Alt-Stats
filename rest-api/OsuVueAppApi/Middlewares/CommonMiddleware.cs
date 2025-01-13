using OsuVueAppApi.Models.Custom;
using System.Text;
using System.Text.Json;

namespace OsuVueAppApi.Middlewares
{
    public class CommonMiddleware(RequestDelegate next)
    {
        private readonly StandartResponse _response = new StandartResponse();

        public async Task InvokeAsync(HttpContext context)
        {
            context.Response.ContentType = "application/json";
            var originalBody = context.Response.Body;
            using var newBody = new MemoryStream();
            context.Response.Body = newBody;

            try
            {
                await next.Invoke(context);
                _response.Data = await GetDataAsync(newBody);
            }
            catch (Exception ex)
            {
                _response.Exception = new ExceptionData
                {
                    Message = ex.Message,
                    StackTrace = ex.StackTrace
                };
            }

            _response.Code = context.Response.StatusCode;
            UpdateBody(newBody);

            newBody.Seek(0, SeekOrigin.Begin);
            await newBody.CopyToAsync(originalBody);
            context.Response.Body = originalBody;
        }

        private static async Task<object?> GetDataAsync(MemoryStream responseBody)
        {
            responseBody.Seek(0, SeekOrigin.Begin);
            var responseBodyText = await new StreamReader(responseBody).ReadToEndAsync();

            return JsonSerializer.Deserialize<TestModel>(responseBodyText);
        }
        private void UpdateBody(MemoryStream responseBody)
        {
            var json = JsonSerializer.Serialize(_response);
            var bytes = Encoding.UTF8.GetBytes(json);

            responseBody.Seek(0, SeekOrigin.Begin);
            responseBody.Write(bytes, 0, bytes.Length);
        }
    }
}

﻿using Newtonsoft.Json;
using OsuVueAppApi.CommonServices.Interfaces;
using OsuVueAppApi.Exceptions;
using OsuVueAppApi.Models.Osu;
using OsuVueAppApi.OsuApiProviders;
using OsuVueAppApi.Utilities;

namespace OsuVueAppApi.CommonServices.Implementations
{
    public class OsuApiService : IOsuApiService
    {
        private const int CLIENT_ID = 34162;
        private const string CLIENT_SECRET = "zDsmZ4qb0Mjo9CmLOjjm1MIXmg0e2KzXY3l2z4sh"; //Test secret (not actual) TODO load secret from appsettings
        private const string GRANT_TYPE = "authorization_code";

        private const string DIRECTORY = "temp";
        private const string FILE = "auth-backup.txt";
        private const string FULL_PATH = $"{DIRECTORY}/{FILE}";

        private OsuOAuthData? _oAuthData = null;

        public UsersProvider Users
        {
            get
            {
                if (_oAuthData == null)
                    throw new NotAuthorizedException();

                return new UsersProvider(_oAuthData);
            }
        }

        public OsuApiService()
        {
            if (File.Exists(FULL_PATH))
            {
                var json = File.ReadAllText(FULL_PATH);
                _oAuthData = JsonConvert.DeserializeObject<OsuOAuthData>(json);
                return;
            }

            if (!Directory.Exists(DIRECTORY))
                Directory.CreateDirectory(DIRECTORY);
        }

        public async Task Authorize(string authorizationCode)
        {
            var client = new HttpClient();
            var msg = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://osu.ppy.sh/oauth/token"),
                Content = new StringContent($"client_id={CLIENT_ID}&client_secret={CLIENT_SECRET}&code={authorizationCode}&grant_type={GRANT_TYPE}")
            };
            msg.Headers.Add("Accept", "application/json");
            msg.Content.Headers.ContentType.MediaType = "application/x-www-form-urlencoded";

            var response = await client.SendAsync(msg);
            var json = await response.Content.ReadAsStringAsync();

            _oAuthData = JsonConvert.DeserializeObject<OsuOAuthData>(json);

            if (_oAuthData != null)
                await BackupToken(json);
        }
        public async Task<string> GetOAuthToken(string authorizationCode)
        {
            var client = new HttpClient();
            var msg = HttpClientHelper.GetOsuApiMessage(
                "https://osu.ppy.sh/oauth/token",
                HttpMethod.Post,
                new StringContent($"client_id={CLIENT_ID}&client_secret={CLIENT_SECRET}&code={authorizationCode}&grant_type={GRANT_TYPE}")
            );

            var response = await client.SendAsync(msg);
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<bool> IsAuthorized()
        {
            await Task.Delay(100);
            throw new NotImplementedException();
        }

        private static async Task BackupToken(string token)
        {
            if (!File.Exists(FULL_PATH))
                File.Create(FULL_PATH).Close();
                
            await File.WriteAllTextAsync(FULL_PATH, token);
        }
    }
}

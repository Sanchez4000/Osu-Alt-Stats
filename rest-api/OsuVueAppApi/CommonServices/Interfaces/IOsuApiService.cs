using OsuVueAppApi.OsuApiProviders;

namespace OsuVueAppApi.CommonServices.Interfaces
{
    public interface IOsuApiService
    {
        public Task Authorize(string authorizationCode);
        public Task<bool> IsAuthorized();

        public UsersProvider Users { get; }
    }
}

using Common.DbModels;
using Domain.CQRS.Profile.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace OsuVueAppApi.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ProfileController(IMediator mediator) : ControllerBase
    {
        [HttpGet("/[controller]/Active")]
        public async Task<ProfileModel?> GetActive()
        {
            var profile = await mediator.Send(new GetActiveQuery());
            return profile;
        }
    }
}

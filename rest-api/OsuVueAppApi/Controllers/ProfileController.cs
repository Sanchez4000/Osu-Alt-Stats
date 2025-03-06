using Common.ViewModels;
using Domain.CQRS.Profile.Commands;
using Domain.CQRS.Profile.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OsuVueAppApi.Requests;

namespace OsuVueAppApi.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ProfileController(IMediator mediator) : ControllerBase
    {
        [HttpGet("/[controller]/Active")]
        public async Task<ProfileViewModel?> GetActive()
        {
            var profile = await mediator.Send(new GetActiveQuery());
            return profile;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateProfileRequest request)
        {
            await mediator.Send(new CreateProfileCommand() { Name = request.Name });
            return Created();
        }
    }
}

using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BrixelAPI.SpaceState.Features.UpdateState
{
    [Authorize]
    [ApiController]
    [Route("api/status")]
    [Route("api/brixel/spaceapi/state")]
    public class ToggleIsOpenStateController
    {
        private readonly IMediator _mediator;

        public ToggleIsOpenStateController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ToggleIsOpenStateResponse> PostAsync(ToggleIsOpenStateRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}

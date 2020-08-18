using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BrixelAPI.SpaceState.Features.UpdateState
{
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

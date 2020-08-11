using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BrixelAPI.SpaceState.Features.GetFullStatus
{
    [ApiController]
    [Route("api/brixel/spaceapi")]
    public class GetFullStatusController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GetFullStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public Task<GetFullStatusResponse> Get()
        {
            var request = new GetFullStatusRequest();
            return _mediator.Send(request);
        }
    }
}
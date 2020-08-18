using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BrixelAPI.SpaceState.Features.GetStateChangedLogs
{
    [ApiController]
    [Route("api/brixel/spaceapi/logs")]
    [Route("api/log")]
    public class GetStateChangedLogController
    {
        private readonly IMediator _mediator;

        public GetStateChangedLogController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<GetStateChangedLogResponse> Get(string order = null)
        {
            var request = new GetStateChangedLogRequest(order);
            return await _mediator.Send(request);
        }
    }
}

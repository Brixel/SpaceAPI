using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;
using MediatR;

namespace BrixelAPI.SpaceAPI.Features.GetFullStatus
{
    public class GetFullStatusRequest : IRequest<GetFullStatusResponse>
    {
    }

    public class GetFullStatusResponse
    {
        public GetFullStatusResponse(Domain.SpaceAPI spaceAPI)
        {
            SpaceAPI = spaceAPI;
        }
        public Domain.SpaceAPI SpaceAPI { get; set; }
    }

    public class GetFullStatusHandler : IRequestHandler<GetFullStatusRequest, GetFullStatusResponse>
    {
        public Task<GetFullStatusResponse> Handle(GetFullStatusRequest request, CancellationToken cancellationToken)
        {
            var state = Domain.SpaceAPI.Create();
            var response = new GetFullStatusResponse(state);
            return Task.FromResult(response);
        }
    }

    [Route("api/brixel/spaceapi")]
    public class GetFullStatusController
    {
        private readonly IMediator _mediator;

        public GetFullStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public Task<GetFullStatusResponse> Get(GetFullStatusRequest request)
        {
            return _mediator.Send(request);
        }
    }
}

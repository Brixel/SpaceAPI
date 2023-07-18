using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using BrixelAPI.SpaceState.Domain.SpaceStateAggregate;
using BrixelAPI.SpaceState.Infrastructure;
using MediatR;

namespace BrixelAPI.SpaceState.Features.GetFullStatus
{
    class GetFullStatusHandler : IRequestHandler<GetFullStatusRequest, GetFullStatusResponse>
    {
        private readonly ISpaceStateRepository _spaceStateRepository;

        public GetFullStatusHandler(ISpaceStateRepository spaceStateRepository)
        {
            _spaceStateRepository = spaceStateRepository;
        }
        public async Task<GetFullStatusResponse> Handle(GetFullStatusRequest request, CancellationToken cancellationToken)
        {

            var state = Domain.SpaceStateAggregate.SpaceState.GetConfiguredSpaceAPI();
            var lastState = await _spaceStateRepository.GetLastLogAsync();

            state.State.Open = lastState.IsOpen;
            state.State.Lastchange = (int)lastState.ChangedAtDateTime
                .ToUniversalTime()
                .Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            
            var response = new GetFullStatusResponse(state);
            return response;
        }
    }
}
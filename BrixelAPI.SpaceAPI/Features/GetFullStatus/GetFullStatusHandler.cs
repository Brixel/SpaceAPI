using BrixelAPI.SpaceState.Infrastructure;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

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

            if (lastState != null)
            {

                state.State.Open = lastState.IsOpen;
                state.State.Lastchange = lastState.ChangedAtDateTime
                    .ToUniversalTime()
                    .Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            }

            var response = new GetFullStatusResponse(state);
            return response;
        }
    }
}
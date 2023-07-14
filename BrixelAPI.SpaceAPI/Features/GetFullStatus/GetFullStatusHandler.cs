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
        private readonly ISpaceStateChangedLogRepository _spaceStateChangedLogRepository;

        public GetFullStatusHandler(ISpaceStateRepository spaceStateRepository, ISpaceStateChangedLogRepository spaceStateChangedLogRepository)
        {
            _spaceStateRepository = spaceStateRepository;
            _spaceStateChangedLogRepository = spaceStateChangedLogRepository;
        }
        public async Task<GetFullStatusResponse> Handle(GetFullStatusRequest request, CancellationToken cancellationToken)
        {

            var state = SpaceApi.GetConfiguredSpaceAPI();
            var lastState = await _spaceStateChangedLogRepository.GetLastLogAsync();

            state.State.Open = lastState.IsOpen;
            state.State.Lastchange = (int)lastState.ChangedAtDateTime
                .ToUniversalTime()
                .Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            
            var response = new GetFullStatusResponse(state);
            return response;
        }
    }
}
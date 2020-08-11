using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
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
            Domain.SpaceStateAggregate.SpaceState currentState;
            try
            {
                currentState = await _spaceStateRepository.ReadAsync();

            }
            catch (FileNotFoundException)
            {

                currentState = Domain.SpaceStateAggregate.SpaceState.Create();
                await _spaceStateRepository.AddAsync(currentState);
            }

            var response = new GetFullStatusResponse(currentState);
            return response;
        }
    }
}
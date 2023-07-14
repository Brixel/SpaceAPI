using System;
using System.Threading;
using System.Threading.Tasks;
using BrixelAPI.SpaceState.Domain.SpaceStateAggregate;
using BrixelAPI.SpaceState.Domain.SpaceStateChangedAggregate;
using BrixelAPI.SpaceState.Infrastructure;
using MediatR;

namespace BrixelAPI.SpaceState.Features.UpdateState
{
    class ToggleIsOpenStateHandler : IRequestHandler<ToggleIsOpenStateRequest, ToggleIsOpenStateResponse>
    {
        private readonly ISpaceStateRepository _spaceStateRepository;
        private readonly ISpaceStateChangedLogRepository _spaceStateChangedLogRepository;
        private readonly ISpaceStateUnitOfWork _unitOfWork;

        public ToggleIsOpenStateHandler(ISpaceStateRepository spaceStateRepository, ISpaceStateChangedLogRepository spaceStateChangedLogRepository, ISpaceStateUnitOfWork unitOfWork)
        {
            _spaceStateRepository = spaceStateRepository;
            _spaceStateChangedLogRepository = spaceStateChangedLogRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<ToggleIsOpenStateResponse> Handle(ToggleIsOpenStateRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var state = Domain.SpaceStateAggregate.SpaceApi.GetConfiguredSpaceAPI();

            state.ChangeState(request.IsOpen);
            
            await _spaceStateChangedLogRepository.AddAsync(SpaceStateChangedLog.Create(request.IsOpen, "User"));

            await _unitOfWork.CommitAsync();

            return new ToggleIsOpenStateResponse();
        }
    }
}
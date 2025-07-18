﻿using BrixelAPI.SpaceState.Domain.SpaceStateChangedAggregate;
using BrixelAPI.SpaceState.Infrastructure;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BrixelAPI.SpaceState.Features.UpdateState
{
    class ToggleIsOpenStateHandler : IRequestHandler<ToggleIsOpenStateRequest, ToggleIsOpenStateResponse>
    {
        private readonly ISpaceStateRepository _spaceStateRepository;
        private readonly ISpaceStateUnitOfWork _unitOfWork;

        public ToggleIsOpenStateHandler(ISpaceStateRepository spaceStateRepository, ISpaceStateUnitOfWork unitOfWork)
        {
            _spaceStateRepository = spaceStateRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<ToggleIsOpenStateResponse> Handle(ToggleIsOpenStateRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var state = Domain.SpaceStateAggregate.SpaceState.GetConfiguredSpaceAPI();

            state.ChangeState(request.IsOpen);

            await _spaceStateRepository.AddAsync(SpaceStateChangedLog.Create(request.IsOpen, "User"));

            await _unitOfWork.CommitAsync();

            return new ToggleIsOpenStateResponse();
        }
    }
}
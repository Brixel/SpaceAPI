using System;
using System.Threading;
using System.Threading.Tasks;
using BrixelAPI.SpaceState.Domain.SpaceStateChangedAggregate;
using BrixelAPI.SpaceState.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BrixelAPI.SpaceState.Features.UpdateState
{
    class SpaceStateChangedLogRepository : ISpaceStateChangedLogRepository
    {
        private readonly SpaceStateContext _context;

        public SpaceStateChangedLogRepository(SpaceStateContext context)
        {
            _context = context;
        }
        public async Task AddAsync(SpaceStateChangedLog spaceStateChangedLog)
        {
            await _context.SpaceStateChangedLog.AddAsync(spaceStateChangedLog);
        }
    }

    class SpaceStateUnitOfWork : ISpaceStateUnitOfWork
    {
        private readonly SpaceStateContext _context;

        public SpaceStateUnitOfWork(SpaceStateContext context)
        {
            _context = context;
        }

        public DbSet<SpaceStateChangedLog> SpaceStateChangedLog { get; set; }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }

    internal interface ISpaceStateUnitOfWork
    {
        public DbSet<SpaceStateChangedLog> SpaceStateChangedLog { get; set; }
        Task CommitAsync();
    }

    interface ISpaceStateChangedLogRepository
    {
        Task AddAsync(SpaceStateChangedLog spaceStateChangedLog);
    }


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

            var state = await _spaceStateRepository.ReadAsync();

            state.State.Open = request.IsOpen;

            await _spaceStateRepository.AddAsync(state);

            await _spaceStateChangedLogRepository.AddAsync(SpaceStateChangedLog.Create(request.IsOpen, "User"));

            await _unitOfWork.CommitAsync();

            return new ToggleIsOpenStateResponse();
        }
    }
}
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Helpers;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BrixelAPI.SpaceState.Features.GetStateChangedLogs
{
    public class GetStateChangedLogHandler : IRequestHandler<GetStateChangedLogRequest, GetStateChangedLogResponse>
    {
        private readonly SpaceStateContext _context;

        public GetStateChangedLogHandler(SpaceStateContext context)
        {
            _context = context;
        }


        public async Task<GetStateChangedLogResponse> Handle(GetStateChangedLogRequest request, CancellationToken cancellationToken)
        {
            var sortDirection = GetSortingDirection(request.Order);
            var spaceStateChangedLogs =
                sortDirection == SortDirection.Ascending
                    ? _context.SpaceStateChangedLog.OrderBy(x => x.ChangedAtDateTime)
                    : _context.SpaceStateChangedLog.OrderByDescending(x => x.ChangedAtDateTime);

            var logs = await
                spaceStateChangedLogs
                    .Select(x => new GetStateChangedLogResponse.GetStateChangeLogDTO()
                    {
                        IsOpen = x.IsOpen,
                        ChangedAtDateTime = x.ChangedAtDateTime,
                        ChangedByUser = x.ChangedByUser
                    }).ToListAsync(cancellationToken);

            return new GetStateChangedLogResponse(logs);

        }

        private SortDirection GetSortingDirection(string requestOrder)
        {
            switch (requestOrder)
            {
                case "asc":
                case "ascending":
                    return SortDirection.Ascending;
                case "desc":
                case "descending":
                default:
                    return SortDirection.Descending;
            }
        }
    }
}
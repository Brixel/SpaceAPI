using MediatR;

namespace BrixelAPI.SpaceState.Features.GetStateChangedLogs
{
    public class GetStateChangedLogRequest : IRequest<GetStateChangedLogResponse>
    {
        public GetStateChangedLogRequest(string order)
        {
            if (string.IsNullOrEmpty(order))
            {
                Order = "asc";
            }
            else
            {
                Order = order;
            }
        }

        public string Order { get; set; }
    }
}
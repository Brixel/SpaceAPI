using MediatR;

namespace BrixelAPI.SpaceState.Features.UpdateState
{
    // TODO Register this validator
    public class ToggleIsOpenStateRequest : IRequest<ToggleIsOpenStateResponse>
    {
        public bool IsOpen { get; set; }
    }
}
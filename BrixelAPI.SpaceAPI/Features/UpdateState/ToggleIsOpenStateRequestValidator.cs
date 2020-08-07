using FluentAssertions;
using FluentValidation;

namespace BrixelAPI.SpaceState.Features.UpdateState
{
    public class ToggleIsOpenStateRequestValidator : AbstractValidator<ToggleIsOpenStateRequest>
    {
        public ToggleIsOpenStateRequestValidator()
        {
            RuleFor(x => x.IsOpen).Should().NotBe(false);
        }
    }
}
using FluentValidation;

namespace Ban.Application.CQRS.Command.UpdateBan
{
    public class UpdateCommandValidator : AbstractValidator<UpdateBansCommand>
    {
        public UpdateCommandValidator()
        {
            RuleFor(opt => opt.id).NotEmpty();
            RuleFor(opt => opt.id).GreaterThan(0);
        }
    }
}

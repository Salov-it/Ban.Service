using FluentValidation;


namespace Ban.Application.CQRS.Command.Create
{
    public class CreateCommandValidator : AbstractValidator<CreateBanСommand>
    {
        public CreateCommandValidator()
        {
            RuleFor(query => query.entity).GreaterThan(0);
        }
    }
}

using FluentValidation;

namespace Ban.Application.CQRS.Querries.GetByIdQuerry
{
    public class GetByIdValidator : AbstractValidator<GetByIdQuerry>
    {
        public GetByIdValidator()
        {
            RuleFor(opt => opt.Id).NotEmpty();
            RuleFor(opt => opt.Id).GreaterThan(0);
        }
    }
}

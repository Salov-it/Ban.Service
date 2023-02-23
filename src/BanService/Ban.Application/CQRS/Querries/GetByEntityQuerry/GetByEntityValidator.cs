using FluentValidation;


namespace Ban.Application.CQRS.Querries.GetByEntityQuerry
{
    internal class GetByEntityValidator : AbstractValidator<GetByEntityQuerry>
    {
        public void GetByOwnerValidator()
        {
            RuleFor(opt => opt.entityId).NotEmpty();
            RuleFor(opt => opt.entityId).GreaterThan(0);
        }
    }
}

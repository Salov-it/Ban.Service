using Ban.Domain;
using MediatR;

namespace Ban.Application.CQRS.Querries.GetByIdQuerry
{
    public class GetByIdQuerry : IRequest<Bans>
    {
        public int Id { get; set; }
    }
}

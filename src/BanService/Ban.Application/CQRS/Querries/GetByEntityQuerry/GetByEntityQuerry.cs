using Ban.Domain;
using MediatR;

namespace Ban.Application.CQRS.Querries.GetByEntityQuerry
{
    public class GetByEntityQuerry  : IRequest<Bans>
    {
        public int entityId { get; set; }
    }
}

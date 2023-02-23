using MediatR;
using Ban.Domain;

namespace Ban.Application.CQRS.Querries.Get
{
    public class GetBansQuery : IRequest<List<Bans>>
    {

    }
}



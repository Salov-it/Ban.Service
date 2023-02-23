using Ban.Domain;
using MediatR;
using Ban.Application.Interfac;
using FluentValidation.Results;

namespace Ban.Application.CQRS.Querries.Get
{
    public class GetBansHandler : IRequestHandler<GetBansQuery, List<Bans>>
    {
        private readonly IBanContext _context;
        public GetBansHandler(IBanContext context)
        {
            _context = context;
        }

        public async Task<List<Bans>> Handle(GetBansQuery request, CancellationToken cancellationToken)
        {
            
            return _context.bans.ToList();
        }
    }
}

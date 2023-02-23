using Ban.Domain;
using Ban.Application.Interfac;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Ban.Application.CQRS.Querries.GetByEntityQuerry
{
    internal class GetByEntityHandler : IRequestHandler<GetByEntityQuerry, Bans>
    {
        private readonly IBanContext _context;
        public GetByEntityHandler(IBanContext context)
        {
            _context = context;
        }
        public async Task<Bans> Handle(GetByEntityQuerry request, CancellationToken cancellationToken)
        {
            var bans = await _context.bans.FirstOrDefaultAsync(w => w.entity == request.entityId);
            if (bans == null)
            {
                return null;
            }
            return bans;
        }
    }
}

using Ban.Domain;
using Ban.Application.Interfac;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Ban.Application.CQRS.Querries.GetByIdQuerry
{
    public class GetByIdHandler : IRequestHandler<GetByIdQuerry, Bans>
    {
        private readonly IBanContext _BanContext;
        public GetByIdHandler(IBanContext BanContext)
        {
            _BanContext = BanContext;
        }
        public async Task<Bans> Handle(GetByIdQuerry request, CancellationToken cancellationToken)
        {
            return await _BanContext.bans.FirstOrDefaultAsync(w => w.id == request.Id, cancellationToken);
        }
    }
}

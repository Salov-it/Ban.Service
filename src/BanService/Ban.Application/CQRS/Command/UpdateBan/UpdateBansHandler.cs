using Ban.Domain;
using Ban.Application.Interfac;
using MediatR;


namespace Ban.Application.CQRS.Command.UpdateBan
{
    public class UpdateBansHandler : IRequestHandler<UpdateBansCommand, Bans>
    {
        private readonly IBanContext _context;
        public UpdateBansHandler(IBanContext context)
        {
            _context = context;
        }

        public async Task<Bans> Handle(UpdateBansCommand request, CancellationToken cancellationToken)
        {
            var content = _context.bans.Find(request.id);

            if (content.until < DateTime.UtcNow)
            {
                return null;
            }
            if(content.until > DateTime.UtcNow)
            {
                return content;
            }
            if(content.until == DateTime.UtcNow)
            {
                return null;
            }
            return content;
        }
    }
}

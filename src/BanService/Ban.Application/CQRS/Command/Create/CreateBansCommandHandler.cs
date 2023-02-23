using Ban.Application.Interfac;
using Ban.Domain;
using MediatR;

namespace Ban.Application.CQRS.Command.Create
{
    public class CreateBansCommandHandler : IRequestHandler<CreateBanСommand,Bans>
    {
        public CreateBansCommandHandler(IBanContext context)
        {
            _banContext = context;
        }
        private readonly IBanContext _banContext;
        public async Task<Bans> Handle(CreateBanСommand request, CancellationToken cancellationToken)
        {
            var content = new Bans
            {
                entity = request.entity,
                until = request.until,
                reason = request.reason,
            };
            await _banContext.bans.AddAsync(content, cancellationToken);
            await _banContext.SaveChangesAsync(cancellationToken);

            return content;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}

using Ban.Domain;
using MediatR;


namespace Ban.Application.CQRS.Command.UpdateBan
{
    public class UpdateBansCommand : IRequest<Bans>
    {

        public int id { get; set; }
        public DateTime entity { get; set; }
       
    }
}

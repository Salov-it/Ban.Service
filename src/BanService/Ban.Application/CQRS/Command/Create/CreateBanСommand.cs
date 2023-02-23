using Ban.Domain;
using MediatR;


namespace Ban.Application.CQRS.Command.Create
{
    public class CreateBanСommand : IRequest<int>
    {
        public int entity { get; set; }
        public DateTime until { get; set; }
        public string reason { get; set; }

    }
}

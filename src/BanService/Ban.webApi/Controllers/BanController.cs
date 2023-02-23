using Ban.Application.CQRS.Command.Create;
using Ban.Application.CQRS.Querries.GetByEntityQuerry;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ban.webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BanController : ControllerBase
    {
        private readonly IMediator mediator;

        public BanController(IMediator mediator)
        {
            this.mediator = mediator;
        }
       
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] int entity, DateTime until, string reason)
        {
            var content = new CreateBanСommand
            {
                entity = entity,
                until = until,
                reason = reason
            };
            var answer = await mediator.Send(content);
            return Ok(answer);
        }

        [HttpGet]
        public async Task<IActionResult> GetByEntity(int entity)
        {
            var content = new GetByEntityQuerry
            {
                entityId = entity
            };
            var answer = await mediator.Send(content);
            return Ok(answer);
        }
    }
}

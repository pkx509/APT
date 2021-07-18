using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

using GFCA.Application.EmailInbounds.Queries.GetEmailInbounds;
using GFCA.Application.EmailInbounds.Commands.CreateEmailInbound;
using GFCA.Application.EmailInbounds.Commands.UpdateEmailInbound;
using GFCA.Application.EmailInbounds.Commands.DeleteEmailInbound;
using Microsoft.Extensions.Primitives;

namespace GFCA.WebAPI.Controllers
{
    public class EmailInboundController : ApiControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<GetEmailInboundQueryResponse>> Get()
        {
            var command = new GetEmailInboundQueryRequest();

            var queryString = Request.Query;
            if (queryString.Keys.Contains("$inlinecount"))
            {
                StringValues Skip;
                StringValues Take;
                StringValues Count;
                int total = (queryString.TryGetValue("Count", out Count)) ? Convert.ToInt32(Count) : 0;
                int skip = (queryString.TryGetValue("$Skip", out Skip)) ? Convert.ToInt32(Skip[0]) : 0;
                int top = (queryString.TryGetValue("$Top", out Take)) ? Convert.ToInt32(Take[0]) : total;

                command.Skip = skip;
                command.Take = top;
                command.Count = total;

            }
            var data = await Mediator.Send(command);
            return data;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetEmailInboundQueryResponse>> Get(int id)
        {
            var command = new GetEmailInboundQueryRequest { Id = id };
            var data = await Mediator.Send(command);
            return data;
        }


        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateEmailInboundCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateEmailInboundCommand command)
        {
            if (id != command.EmailID)
            {
                return BadRequest();
            }

            await Mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteEmailInboundCommand { Id = id };
            var data = await Mediator.Send(command);
            return NoContent();
        }

    }
}

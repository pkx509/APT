using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GFCA.Application.Sales.Channels.Commands.CreateChannel;
using GFCA.Application.Sales.Channels.Commands.DeleteChannel;
using GFCA.Application.Sales.Channels.Commands.UpdateChannel;
using GFCA.Application.Sales.Channels.Queries.GetChannel;
using GFCA.Shared.Models.Vm;
using GFCA.WebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GFCA.WebAPI.Areas.Sales.Controllers
{
    public class ChannelController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<ChannelVm>> Get()
        {
            var command = new GetChannelQuery
            {

            };

            var data = await Mediator.Send(command);
            return data;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateChannelCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateChannelCommand command)
        {
            if (id != command.ChannelId)
            {
                return BadRequest();
            }

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteChannelCommand { ChannelId = id };
            var data = await Mediator.Send(command);
            return NoContent();
        }
    }
}

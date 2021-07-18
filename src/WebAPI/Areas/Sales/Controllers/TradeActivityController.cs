using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GFCA.Application.Sales.TradeActivities.Commands.CreateTradeActivity;
using GFCA.Application.Sales.TradeActivities.Commands.DeleteTradeActivity;
using GFCA.Application.Sales.TradeActivities.Commands.UpdateTradeActivity;
using GFCA.Application.Sales.TradeActivities.Queries.GetTradeActivity;
using GFCA.Shared.Models.Vm;
using GFCA.WebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GFCA.WebAPI.Areas.Sales.Controllers
{
    public class TradeActivityController : ApiControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<TradeActivityVm>> Get()
        {
            var command = new GetTradeActivityQuery
            {

            };

            var data = await Mediator.Send(command);
            return data;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateTradeActivityCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateTradeActivityCommand command)
        {
            if (id != command.TradeActivityId)
            {
                return BadRequest();
            }

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteTradeActivityCommand { TradeActivityId = id };
            var data = await Mediator.Send(command);
            return NoContent();
        }

    }
}

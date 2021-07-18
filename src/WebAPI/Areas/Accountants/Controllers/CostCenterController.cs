using System.Threading.Tasks;
using GFCA.Application.Accountants.CostCenters.Commands.CreateCostCenter;
using GFCA.Application.Accountants.CostCenters.Commands.DeleteCostCenter;
using GFCA.Application.Accountants.CostCenters.Commands.UpdateCostCenter;
using GFCA.Application.Accountants.CostCenters.Queries.GetCostCenter;
using GFCA.Shared.Models.Vm;
using Microsoft.AspNetCore.Mvc;

namespace GFCA.WebAPI.Controllers
{
    public class CostCenterController : ApiControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<CostCenterVm>> Get()
        {
            var command = new GetCostCenterQuery
            {

            };

            var data = await Mediator.Send(command);
            return data;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateCostCenterCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateCostCenterCommand command)
        {
            if (id != command.CostCenterId)
            {
                return BadRequest();
            }

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteCostCenterCommand { CostCenterId = id };
            var data = await Mediator.Send(command);
            return NoContent();
        }

    }
}
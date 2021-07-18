using System.Threading.Tasks;
using GFCA.Application.Organizations.Employees.Commands.CreateEmployee;
using GFCA.Application.Organizations.Employees.Commands.DeleteEmployee;
using GFCA.Application.Organizations.Employees.Commands.UpdateEmployee;
using GFCA.Application.Organizations.Employees.Queries.GetEmployee;
using GFCA.Shared.Models.Vm;
using Microsoft.AspNetCore.Mvc;

namespace GFCA.WebAPI.Controllers
{

    public class EmployeeController : ApiControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<EmployeeVm>> Get()
        {
            var command = new GetEmployeeQuery
            {

            };

            var data = await Mediator.Send(command);
            return data;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateEmployeeCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateEmployeeCommand command)
        {
            if (id != command.EmployeeId)
            {
                return BadRequest();
            }

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteEmployeeCommand { EmployeeId = id };
            var data = await Mediator.Send(command);
            return NoContent();
        }

    }
}
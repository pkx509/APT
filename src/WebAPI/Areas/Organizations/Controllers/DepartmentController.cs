using System.Threading.Tasks;
using GFCA.Application.Organizations.Departments.Commands.CreateDepartment;
using GFCA.Application.Organizations.Departments.Commands.DeleteDepartment;
using GFCA.Application.Organizations.Departments.Commands.UpdateDepartment;
using GFCA.Application.Organizations.Departments.Queries.GetDepartment;
using GFCA.Shared.Models.Vm;
using Microsoft.AspNetCore.Mvc;

namespace GFCA.WebAPI.Controllers
{
    public class DepartmentController : ApiControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<DepartmentVm>> Get()
        {
            var command = new GetDepartmentQuery
            {

            };

            var data = await Mediator.Send(command);
            return data;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateDepartmentCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateDepartmentCommand command)
        {
            if (id != command.DepartmentId)
            {
                return BadRequest();
            }

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteDepartmentCommand { DepartmentId = id };
            var data = await Mediator.Send(command);
            return NoContent();
        }

    }
}
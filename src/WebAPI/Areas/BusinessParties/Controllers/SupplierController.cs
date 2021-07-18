using System.Threading.Tasks;
using GFCA.Application.BusinessParties.Suppliers.Commands.CreateSupplier;
using GFCA.Application.BusinessParties.Suppliers.Commands.DeleteSupplier;
using GFCA.Application.BusinessParties.Suppliers.Commands.UpdateSupplier;
using GFCA.Application.BusinessParties.Suppliers.Queries.GetSupplier;
using GFCA.Shared.Models.Vm;
using Microsoft.AspNetCore.Mvc;

namespace GFCA.WebAPI.Controllers
{

    public class SupplierController : ApiControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<SupplierVm>> Get()
        {
            var command = new GetSupplierQuery
            {

            };

            var data = await Mediator.Send(command);
            return data;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateSupplierCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateSupplierCommand command)
        {
            if (id != command.SupplierId)
            {
                return BadRequest();
            }

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteSupplierCommand { SupplierId = id };
            var data = await Mediator.Send(command);
            return NoContent();
        }

    }
}
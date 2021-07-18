using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GFCA.Application.BusinessParties.Customers.Commands.CreateCustomer;
using GFCA.Application.BusinessParties.Customers.Commands.DeleteCustomer;
using GFCA.Application.BusinessParties.Customers.Commands.UpdateCustomer;
using GFCA.Application.BusinessParties.Customers.Queries.GetCustomer;
using GFCA.Shared.Models.Vm;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GFCA.WebAPI.Controllers
{
    public class CustomerController : ApiControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<CustomerVm>> Get()
        {
            var command = new GetCustomerQuery
            {

            };

            var data = await Mediator.Send(command);
            return data;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateCustomerCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateCustomerCommand command)
        {
            if (id != command.CustomerId)
            {
                return BadRequest();
            }

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteCustomerCommand { CustomerId = id };
            var data = await Mediator.Send(command);
            return NoContent();
        }

    }
}
using System;
using System.Threading.Tasks;
using GFCA.Application.Organizations.Companies.Commands.CreateCompany;
using GFCA.Application.Organizations.Companies.Commands.DeleteCompany;
using GFCA.Application.Organizations.Companies.Commands.UpdateCompany;
using GFCA.Application.Organizations.Companies.Queries.GetCompany;
using GFCA.Shared.Models.Vm;
using Microsoft.AspNetCore.Mvc;

namespace GFCA.WebAPI.Controllers
{
    public class CompanyController : ApiControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<CompanyVm>> Get()
        {
            var command = new GetCompanyQuery
            {

            };

            var data = await Mediator.Send(command);
            return data;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateCompanyCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateCompanyCommand command)
        {
            if (id != command.CompanyId)
            {
                return BadRequest();
            }

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteCompanyCommand { CompanyId = id };
            var data = await Mediator.Send(command);
            return NoContent();
        }

    }
}
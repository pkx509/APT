using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GFCA.Application.Warehouses.Brands.Commands.CreateBrand;
using GFCA.Application.Warehouses.Brands.Commands.DeleteBrand;
using GFCA.Application.Warehouses.Brands.Commands.UpdateBrand;
using GFCA.Application.Warehouses.Brands.Queries.GetBrand;
using GFCA.Shared.Models.Vm;
using GFCA.WebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace GFCA.WebAPI.Controllers
{
    public class BrandController : ApiControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<BrandVm>> Get()
        {
            var command = new GetBrandQuery
            {

            };

            var data = await Mediator.Send(command);
            return data;
        }


        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateBrandCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateBrandCommand command)
        {
            if (id != command.BrandId)
            {
                return BadRequest();
            }

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteBrandCommand { BrandId = id };
            var data = await Mediator.Send(command);
            return NoContent();
        }

    }
}
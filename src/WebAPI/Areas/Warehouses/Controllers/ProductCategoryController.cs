using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GFCA.Application.Warehouses.ProductCategories.Commands.CreateProductCategory;
using GFCA.Application.Warehouses.ProductCategories.Commands.DeleteProductCategory;
using GFCA.Application.Warehouses.ProductCategories.Commands.UpdateProductCategory;
using GFCA.Application.Warehouses.ProductCategories.Queries.GetProductCategory;
using GFCA.Shared.Models.Vm;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GFCA.WebAPI.Controllers
{
    public class ProductCategoryController : ApiControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<ProductCategoryVm>> Get()
        {
            var command = new GetProductCategoryQuery
            {

            };

            var data = await Mediator.Send(command);
            return data;
        }


        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateProductCategoryCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateProductCategoryCommand command)
        {
            if (id != command.ProductCategoryId)
            {
                return BadRequest();
            }

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteProductCategoryCommand { ProductCategoryId = id };
            var data = await Mediator.Send(command);
            return NoContent();
        }

    }
}
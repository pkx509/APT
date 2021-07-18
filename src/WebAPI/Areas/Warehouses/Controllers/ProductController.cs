using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GFCA.Application.Warehouses.Products.Commands.CreateProduct;
using GFCA.Application.Warehouses.Products.Commands.DeleteProduct;
using GFCA.Application.Warehouses.Products.Commands.UpdateProduct;
using GFCA.Application.Warehouses.Products.Queries.GetProduct;
using GFCA.Shared.Models.Vm;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GFCA.WebAPI.Controllers
{
    public class ProductController : ApiControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<ProductVm>> Get()
        {
            var command = new GetProductQuery
            {

            };

            var data = await Mediator.Send(command);
            return data;
        }


        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateProductCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateProductCommand command)
        {
            if (id != command.ProductId)
            {
                return BadRequest();
            }

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteProductCommand { ProductId = id };
            var data = await Mediator.Send(command);
            return NoContent();
        }

    }
}
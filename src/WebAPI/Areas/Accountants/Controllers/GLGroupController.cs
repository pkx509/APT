using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GFCA.Application.Accountants.GLGroups.Commands.CreateGLGroup;
using GFCA.Application.Accountants.GLGroups.Commands.DeleteGLGroup;
using GFCA.Application.Accountants.GLGroups.Commands.UpdateGLGroup;
using GFCA.Application.Accountants.GLGroups.Queries.GetGLGroup;
using GFCA.Shared.Models.Vm;
using GFCA.WebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GFCA.WebAPI.Areas.Accountants.Controllers
{
    public class GLGroupController : ApiControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<GLGroupVm>> Get()
        {
            var command = new GetGLGroupQuery
            {

            };

            var data = await Mediator.Send(command);
            return data;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateGLGroupCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateGLGroupCommand command)
        {
            if (id != command.GroupId)
            {
                return BadRequest();
            }

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteGLGroupCommand { GroupId = id };
            var data = await Mediator.Send(command);
            return NoContent();
        }

    }
}

using System.Threading.Tasks;
using GFCA.Application.Accountants.GLAccounts.Commands.CreateGLAccount;
using GFCA.Application.Accountants.GLAccounts.Commands.DeleteGLAccount;
using GFCA.Application.Accountants.GLAccounts.Commands.UpdateGLAccount;
using GFCA.Application.Accountants.GLAccounts.Queries.GetGLAccount;
using GFCA.Shared.Models.Vm;
using Microsoft.AspNetCore.Mvc;

namespace GFCA.WebAPI.Controllers
{
    public class GLAccountController : ApiControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<GLAccountVm>> Get()
        {
            var command = new GetGLAccountQuery
            {

            };

            var data = await Mediator.Send(command);
            return data;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateGLAccountCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateGLAccountCommand command)
        {
            if (id != command.AccountId)
            {
                return BadRequest();
            }

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteGLAccountCommand { AccountId = id };
            var data = await Mediator.Send(command);
            return NoContent();
        }

    }
}
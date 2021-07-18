using System;
using System.Threading.Tasks;
using GFCA.Application.Workflows.Workflows.Queries.GetWorkflow;
using GFCA.Shared.Models.Vm;
using Microsoft.AspNetCore.Mvc;

namespace GFCA.WebAPI.Controllers
{
    public class WorkflowController : ApiControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<WorkflowVm>> Get()
        {
            var command = new GetWorkflowQuery
            {

            };

            var data = await Mediator.Send(command);
            return data;
        }

    }
}

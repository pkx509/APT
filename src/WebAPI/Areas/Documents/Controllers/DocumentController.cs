using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

using GFCA.Application.Documents.Queries.GetDocument;
using GFCA.Application.Documents.Commands.CreateDocument;
using GFCA.Application.Documents.Commands.UpdateDocument;
using GFCA.Application.Documents.Commands.DeleteDocument;
using Microsoft.Extensions.Primitives;
using GFCA.Shared.Models.Vm;

namespace GFCA.WebAPI.Controllers
{
    public class DocumentController : ApiControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<DocumentVm>> Get()
        {
            var command = new GetDocumentQuery
            {

            };

            var data = await Mediator.Send(command);
            return data;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateDocumentCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateDocumentCommand command)
        {
            if (id != command.DocumentId)
            {
                return BadRequest();
            }

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteDocumentCommand { DocumentId = id };
            var data = await Mediator.Send(command);
            return NoContent();
        }

    }
}

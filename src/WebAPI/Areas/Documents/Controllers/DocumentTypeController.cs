using System.Threading.Tasks;
using GFCA.Application.Documents.DocumentTypes.Commands.CreateDocumentType;
using GFCA.Application.Documents.DocumentTypes.Commands.DeleteDocumentType;
using GFCA.Application.Documents.DocumentTypes.Commands.UpdateDocumentType;
using GFCA.Application.Documents.DocumentTypes.Queries.GetDocumentType;
using GFCA.Shared.Models.Vm;
using GFCA.WebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace GFCA.WebAPI.Areas.Documents.Controllers
{
    public class DocumentTypeController : ApiControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<DocumentTypeVm>> Get()
        {
            var command = new GetDocumentTypeQuery
            {

            };

            var data = await Mediator.Send(command);
            return data;
        }


        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateDocumentTypeCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateDocumentTypeCommand command)
        {
            if (id != command.DocumentTypeId)
            {
                return BadRequest();
            }

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteDocumentTypeCommand { DocumentTypeId = id };
            var data = await Mediator.Send(command);
            return NoContent();
        }

    }
}
using System;
using MediatR;

namespace GFCA.Application.Documents.DocumentTypes.Commands.DeleteDocumentType
{
    public class DeleteDocumentTypeCommand : IRequest
    {
        public int DocumentTypeId { get; set; }
    }
}

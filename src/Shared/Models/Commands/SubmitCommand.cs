using System;
using GFCA.Shared.Models.Dto;

namespace GFCA.Domain.Models
{
    public class SubmitCommand : Command
    {

        private readonly DocumentDto _document;
        private readonly DocumentActionDto _documentAction;
        public SubmitCommand(DocumentDto document, DocumentActionDto documentAction)
        {
            _document = document;
            _documentAction = documentAction;
        }

        public override void Execute()
        {
            _documentAction.DocumentId = _document.DocumentId ?? 0;
        }
        
    }
}

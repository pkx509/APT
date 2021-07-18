using System;
using GFCA.Shared.Models.Dto;

namespace GFCA.Domain.Models
{
    public abstract class Command
    {
        public abstract void Execute();
    }

    public enum CommandOption
    {
        Submit,
        Confirm,
        Approve,
        Reject,
        Review,
        Comiit,
        Cancel,
        CopyTo
    }

    public class DocumentProcess
    {

        private readonly DocumentDto _documentDto;

        public DocumentProcess(DocumentDto document)
        {
            _documentDto = document;
        }

        public void Submit()
        {
            DocumentActionDto docAction = new DocumentActionDto();
            docAction.DocumentId = _documentDto.DocumentId?? 0;


        }

        public void Confirm()
        {
            //Find WorkflowState
            //loop process by StateProcess
            Console.WriteLine("Send mail");
        }

        public void Approve() { }
        public void Reject() { }
        public void Review() { }
        public void Commit() { }
        public void Cancel() { }
        public void CopyTo() { }

    }

}

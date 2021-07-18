using System;
using FluentValidation;

namespace GFCA.Application.Documents.DocumentTypes.Commands.CreateDocumentType
{
    public class CreateDocumentTypeCommandValidator : AbstractValidator<CreateDocumentTypeCommand>
    {
        public CreateDocumentTypeCommandValidator()
        {
            RuleFor(v => v.WorkflowId)
                .NotEmpty()
                .WithMessage("WorkflowId is required.");

        }
    }
}

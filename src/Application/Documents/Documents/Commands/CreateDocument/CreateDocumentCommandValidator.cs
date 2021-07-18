using System;
using FluentValidation;

namespace GFCA.Application.Documents.Commands.CreateDocument
{
    public class CreateDocumentCommandValidator : AbstractValidator<CreateDocumentCommand>
    {
        public CreateDocumentCommandValidator()
        {
            RuleFor(v => v.DocumentTypeId)
                .NotEmpty()
                .WithMessage("DocumentTypeId is required.");

        }
    }
}

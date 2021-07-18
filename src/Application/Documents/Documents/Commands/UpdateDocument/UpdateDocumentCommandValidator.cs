using System;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using GFCA.Application.Common.Interfaces;

namespace GFCA.Application.Documents.Commands.UpdateDocument
{
    public class UpdateDocumentCommandValidator : AbstractValidator<UpdateDocumentCommand>
    {
        private readonly IApplicationDbContext _context;
        public UpdateDocumentCommandValidator(IApplicationDbContext context)
        {
            _context = context;

            RuleFor(v => v.DocumentId)
                .NotEmpty().WithMessage("Title is required.")
                ;
            /*
                .MaximumLength(200).WithMessage("Title must not exceed 200 characters.")
                .MustAsync(BeUniqueRefNo).WithMessage("The specified title already exists.");
            */
        }

        public async Task<bool> BeUniqueRefNo(UpdateDocumentCommand model, string referenceNo, CancellationToken cancellationToken)
        {
            return await _context.Documents
                .Where(l => l.DocumentId != model.DocumentId)
                .AllAsync(l => l.ReferenceNo != referenceNo);
        }
    }
}

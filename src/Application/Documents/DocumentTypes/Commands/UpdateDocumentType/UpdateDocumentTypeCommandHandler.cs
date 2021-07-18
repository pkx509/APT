using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Exceptions;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.Documents;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Documents.DocumentTypes.Commands.UpdateDocumentType
{
    public class UpdateDocumentTypeCommandHandler : IRequestHandler<UpdateDocumentTypeCommand>
    {

        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public UpdateDocumentTypeCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<Unit> Handle(UpdateDocumentTypeCommand request, CancellationToken cancellationToken)
        {

            var doc = _mapper.Map<DocumentTypeDto>(request);
            var entity = await _context.DocumentTypes.FindAsync(doc.DocumentTypeId);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DocumentType), request.DocumentTypeId);
            }

            entity.DocumentTypeCode = doc.DocumentTypeCode;
            entity.WorkflowId = doc.WorkflowId??0;
            entity.DocumentTypeName = doc.DocumentTypeName;
            entity.DocumentTypeDesc = doc.DocumentTypeDesc;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

        }
    }
}

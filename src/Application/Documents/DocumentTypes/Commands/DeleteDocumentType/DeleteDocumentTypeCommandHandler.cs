using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Exceptions;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.Documents;
using MediatR;

namespace GFCA.Application.Documents.DocumentTypes.Commands.DeleteDocumentType
{
    public class DeleteDocumentTypeCommandHandler : IRequestHandler<DeleteDocumentTypeCommand>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public DeleteDocumentTypeCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<Unit> Handle(DeleteDocumentTypeCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DocumentTypes.FindAsync(request.DocumentTypeId);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DocumentType), request.DocumentTypeId);
            }

            _context.DocumentTypes.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}

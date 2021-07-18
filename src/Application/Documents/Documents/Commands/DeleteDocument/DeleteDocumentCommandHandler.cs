using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Exceptions;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.Documents;
using MediatR;

namespace GFCA.Application.Documents.Commands.DeleteDocument
{

    public class DeleteDocumentCommandHandler : IRequestHandler<DeleteDocumentCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public DeleteDocumentCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteDocumentCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Documents.FindAsync(request.DocumentId);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Document), request.DocumentId);
            }

            var childEntity = _context.DocumentActions.Where(w => w.DocumentId == request.DocumentId);
            if (childEntity != null)
                _context.DocumentActions.RemoveRange(childEntity);

            _context.Documents.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }

}

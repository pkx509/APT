using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Exceptions;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities;
using MediatR;

namespace GFCA.Application.EmailInbounds.Commands.DeleteEmailInbound
{
    public class DeleteEmailInboundCommand : IRequest
    {
        public int Id { get; set; }
    }

    public class DeleteEmailInboundCommamdHandler : IRequestHandler<DeleteEmailInboundCommand>
    {

        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public DeleteEmailInboundCommamdHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteEmailInboundCommand request, CancellationToken cancellationToken)
        {

            var entity = await _context.EmailInbounds.FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(EmailInbound), request.Id);
            }

            _context.EmailInbounds.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}

using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Interfaces;
using MediatR;

namespace GFCA.Application.Warehouses.Brands.Commands.DeleteBrand
{
    public class DeleteBrandCommandHandler: IRequestHandler<DeleteBrandCommand>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public DeleteBrandCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<Unit> Handle(DeleteBrandCommand request, CancellationToken cancellationToken)
        {
            try
            {
                await _context.BeginTransactionAsync();

                var entity = await _context.Brands.FindAsync(request.BrandId);

                _context.Brands.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);
                await _context.CommitTransactionAsync();

            }
            catch
            {
                _context.RollbackTransaction();
            }

            return Unit.Value;
        }

    }
}

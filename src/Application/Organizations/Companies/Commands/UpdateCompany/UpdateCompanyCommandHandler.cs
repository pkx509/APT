using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Exceptions;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.Organizations;
using MediatR;
using GFCA.Shared.Models.Dto;

namespace GFCA.Application.Organizations.Companies.Commands.UpdateCompany
{
    public class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyCommand>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public UpdateCompanyCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<Unit> Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
        {
            var CompanyDto = _mapper.Map<CompanyDto>(request);

            try
            {
                await _context.BeginTransactionAsync();
                var entity = await _context.Companies.FindAsync(new { Id = request.CompanyId });
                if (entity == null)
                    throw new NotFoundException(nameof(Company), CompanyDto.CompanyId);

                entity.Code = CompanyDto.CompanyCode;
                entity.Name = CompanyDto.CompanyName;

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

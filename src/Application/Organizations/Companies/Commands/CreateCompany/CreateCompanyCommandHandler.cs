using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.Organizations;
using MediatR;
using GFCA.Shared.Models.Dto;

namespace GFCA.Application.Organizations.Companies.Commands.CreateCompany
{
    public class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public CreateCompanyCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<int> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
        {

            var CompanyDto = _mapper.Map<CompanyDto>(request);
            var CompanyEnt = _mapper.Map<Company>(CompanyDto);

            try
            {
                await _context.BeginTransactionAsync();

                _context.Companies.Add(CompanyEnt);
                await _context.SaveChangesAsync(cancellationToken);
                await _context.CommitTransactionAsync();
            }
            catch
            {
                _context.RollbackTransaction();
            }
            return CompanyEnt.Id;
        }


    }
}

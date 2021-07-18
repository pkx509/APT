using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.Organizations;
using MediatR;
using GFCA.Shared.Models.Dto;

namespace GFCA.Application.Organizations.Departments.Commands.CreateDepartment
{
    public class CreateDepartmentCommandHandler : IRequestHandler<CreateDepartmentCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public CreateDepartmentCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<int> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {

            var DepartmentDto = _mapper.Map<DepartmentDto>(request);
            var DepartmentEnt = _mapper.Map<Department>(DepartmentDto);

            try
            {
                await _context.BeginTransactionAsync();

                _context.Departments.Add(DepartmentEnt);
                await _context.SaveChangesAsync(cancellationToken);
                await _context.CommitTransactionAsync();
            }
            catch
            {
                _context.RollbackTransaction();
            }
            return DepartmentEnt.Id;
        }


    }
}

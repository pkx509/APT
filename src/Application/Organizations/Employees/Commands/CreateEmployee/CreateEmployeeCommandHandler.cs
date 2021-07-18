using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Interfaces;
using MediatR;
using GFCA.Shared.Models.Dto;
using GFCA.Domain.Entities.Organizations;

namespace GFCA.Application.Organizations.Employees.Commands.CreateEmployee
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public CreateEmployeeCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<int> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {

            var EmployeeDto = _mapper.Map<EmployeeDto>(request);
            var EmployeeEnt = _mapper.Map<Employee>(EmployeeDto);

            try
            {
                await _context.BeginTransactionAsync();

                _context.Employees.Add(EmployeeEnt);
                await _context.SaveChangesAsync(cancellationToken);
                await _context.CommitTransactionAsync();
            }
            catch //(Exception ex)
            {
                _context.RollbackTransaction();
            }
            return EmployeeEnt.Id;
        }


    }
}

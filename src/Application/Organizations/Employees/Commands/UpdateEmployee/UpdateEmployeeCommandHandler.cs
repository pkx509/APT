using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Exceptions;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.Organizations;
using MediatR;
using GFCA.Shared.Models.Dto;

namespace GFCA.Application.Organizations.Employees.Commands.UpdateEmployee
{
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public UpdateEmployeeCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<Unit> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var EmployeeDto = _mapper.Map<EmployeeDto>(request);

            try
            {
                await _context.BeginTransactionAsync();
                var entity = await _context.Employees.FindAsync(new { Id = request.EmployeeId });
                if (entity == null)
                    throw new NotFoundException(nameof(Employee), EmployeeDto.EmployeeId);

                entity.Code = EmployeeDto.EmployeeCode;
                entity.Prefix = EmployeeDto.Prefix;
                entity.FirstName = EmployeeDto.FirstName;
                entity.LastName = EmployeeDto.LastName;
                entity.Position = EmployeeDto.Position;
                entity.Email = EmployeeDto.Email;

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

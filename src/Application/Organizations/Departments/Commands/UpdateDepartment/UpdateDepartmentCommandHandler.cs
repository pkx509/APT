using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Exceptions;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.Organizations;
using MediatR;
using GFCA.Shared.Models.Dto;

namespace GFCA.Application.Organizations.Departments.Commands.UpdateDepartment
{
    public class UpdateDepartmentCommandHandler : IRequestHandler<UpdateDepartmentCommand>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public UpdateDepartmentCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<Unit> Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var DepartmentDto = _mapper.Map<DepartmentDto>(request);

            try
            {
                await _context.BeginTransactionAsync();
                var entity = await _context.Departments.FindAsync(request.DepartmentId);
                if (entity == null)
                    throw new NotFoundException(nameof(Department), DepartmentDto.DepartmentId);

                
                entity.BranchCode = DepartmentDto.BranchCode;
                entity.BranchName = DepartmentDto.BranchName;

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

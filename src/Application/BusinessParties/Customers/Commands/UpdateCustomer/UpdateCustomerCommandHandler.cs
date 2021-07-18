using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Exceptions;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.BusinessParties;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.BusinessParties.Customers.Commands.UpdateCustomer
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public UpdateCustomerCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<Unit> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<CustomerDto>(request);

            try
            {
                await _context.BeginTransactionAsync();
                var entity = await _context.Customers.FindAsync(request.CustomerId);
                if (entity == null)
                    throw new NotFoundException(nameof(Customer), dto.CustomerId);

                _mapper.Map<UpdateCustomerCommand, Customer>(request, entity);
                //entity.CustomerCode    = dto.CustomerCode;
                //entity.CustomerName    = dto.CustomerName;
                //entity.CustomerGroup   = dto.CustomerGroup;
                //entity.ShortName       = dto.ShortName;
                //entity.Distributor     = dto.SalesBy;
                //entity.AccountNo       = dto.AccountNo;
                /*
                if (customerDto.Clients != null)
                {
                    foreach (var dto in customerDto.Clients)
                    {
                        var client = _mapper.Map<Client>(dto);
                        _context.Clients.Add(client);
                    }
                }
                else
                {

                }

                if (customerDto.Channels != null)
                {
                    foreach (var dto in customerDto.Clients)
                    {
                        var channel = _mapper.Map<Channel>(dto);
                        _context.Channels.Add(channel);
                    }
                }
                else
                {

                }
                */
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

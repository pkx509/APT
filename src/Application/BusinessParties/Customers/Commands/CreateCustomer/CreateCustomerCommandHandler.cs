using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.BusinessParties;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.BusinessParties.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public CreateCustomerCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<int> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {

            var dto = _mapper.Map<CustomerDto>(request);
            var ent = _mapper.Map<Customer>(dto);

            try
            {
                await _context.BeginTransactionAsync();

                //ICollection<Client> clients = _mapper.Map<IList<ClientDto>, ICollection<Client>>(customerDto.Clients);
                /*
                if (customerDto.Clients != null)
                {
                    foreach (var dto in customerDto.Clients)
                    {
                        var c = _mapper.Map<Client>(dto);
                        customerEnt.Clients.Add(c);
                    }
                }

                if (customerDto.Channels != null)
                {
                    foreach (var dto in customerDto.Channels)
                    {
                        var c = _mapper.Map<Channel>(dto);
                        customerEnt.Channels.Add(c);
                    }
                }
                */
                _context.Customers.Add(ent);
                await _context.SaveChangesAsync(cancellationToken);
                await _context.CommitTransactionAsync();
            }
            catch
            {
                _context.RollbackTransaction();
            }
            return ent.CustomerId;
        }

        
    }


}

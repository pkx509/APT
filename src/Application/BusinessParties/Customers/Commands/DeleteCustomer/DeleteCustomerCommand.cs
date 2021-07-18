using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.BusinessParties;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.BusinessParties.Customers.Commands.DeleteCustomer
{
    public class DeleteCustomerCommand
        : CustomerDto
        , IMapFrom<CustomerDto>
        , IRequest
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<DeleteCustomerCommand, CustomerDto>();
            profile.CreateMap<CustomerDto, Customer>();
            profile.CreateMap<DeleteCustomerCommand, Customer>();
        }

    }
}

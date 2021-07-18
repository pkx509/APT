using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.BusinessParties;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.BusinessParties.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommand
        : CustomerDto
        , IMapFrom<CustomerDto>
        , IRequest<int>
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<CreateCustomerCommand, CustomerDto>();
            profile.CreateMap<CustomerDto, Customer>()
                .ForMember(d => d.Distributor, o => o.MapFrom(f => f.SalesBy));
            profile.CreateMap<CreateCustomerCommand, Customer>()
                .ForMember(d => d.Distributor, o => o.MapFrom(f => f.SalesBy));

            profile.CreateMap<Customer, CustomerDto>()
                .ForMember(d => d.SalesBy, o => o.MapFrom(f => f.Distributor));
            profile.CreateMap<Customer, CreateCustomerCommand>()
                .ForMember(d => d.SalesBy, o => o.MapFrom(f => f.Distributor));
        }

    }

}

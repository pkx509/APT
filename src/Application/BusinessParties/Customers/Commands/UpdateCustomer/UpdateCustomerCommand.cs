using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.BusinessParties;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.BusinessParties.Customers.Commands.UpdateCustomer
{
    public class UpdateCustomerCommand
        : CustomerDto
        , IMapFrom<CustomerDto>
        , IRequest
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<UpdateCustomerCommand, CustomerDto>();
            profile.CreateMap<CustomerDto, Customer>()
                .ForMember(d => d.Distributor, o => o.MapFrom(f => f.SalesBy));
            profile.CreateMap<UpdateCustomerCommand, Customer>()
                .ForMember(d => d.Distributor, o => o.MapFrom(f => f.SalesBy));

            profile.CreateMap<Customer, CustomerDto>()
                .ForMember(d => d.SalesBy, o => o.MapFrom(f => f.Distributor));
            profile.CreateMap<Customer, UpdateCustomerCommand>()
                .ForMember(d => d.SalesBy, o => o.MapFrom(f => f.Distributor));

        }

    }
}

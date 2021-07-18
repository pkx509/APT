using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.BusinessParties;
using GFCA.Shared.Models.Vm;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.BusinessParties.Customers.Queries.GetCustomer
{
    public class GetCustomerQuery
        : CustomerDto
        , IMapFrom<GetCustomerQuery>
        , IRequest<CustomerVm>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetCustomerQuery, CustomerDto>();
            profile.CreateMap<CustomerDto, Customer>();
            profile.CreateMap<GetCustomerQuery, Customer>();

            profile.CreateMap<Customer, CustomerDto>();
            profile.CreateMap<Customer, GetCustomerQuery>();
        }
    }

}

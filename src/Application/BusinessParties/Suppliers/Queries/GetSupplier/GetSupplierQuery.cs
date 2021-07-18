using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.BusinessParties;
using GFCA.Shared.Models.Dto;
using GFCA.Shared.Models.Vm;
using MediatR;

namespace GFCA.Application.BusinessParties.Suppliers.Queries.GetSupplier
{
    public class GetSupplierQuery
        : SupplierDto
        , IMapFrom<GetSupplierQuery>
        , IRequest<SupplierVm>
    {

        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetSupplierQuery, SupplierDto>();
            profile.CreateMap<SupplierDto, Supplier>();
            profile.CreateMap<GetSupplierQuery, Supplier>();

            profile.CreateMap<Supplier, SupplierDto>();
            profile.CreateMap<Supplier, GetSupplierQuery>();
        }

    }
}

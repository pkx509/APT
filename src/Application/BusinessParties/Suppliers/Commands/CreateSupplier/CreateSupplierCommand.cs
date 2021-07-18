using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.BusinessParties;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.BusinessParties.Suppliers.Commands.CreateSupplier
{
    public class CreateSupplierCommand
        : SupplierDto
        , IMapFrom<CreateSupplierCommand>
        , IRequest<int>
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<CreateSupplierCommand, SupplierDto>();
            profile.CreateMap<SupplierDto, Supplier>();
            profile.CreateMap<CreateSupplierCommand, Supplier>();
        }

    }
}

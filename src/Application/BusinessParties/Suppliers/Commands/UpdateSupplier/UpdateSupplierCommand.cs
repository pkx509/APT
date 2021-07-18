using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.BusinessParties;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.BusinessParties.Suppliers.Commands.UpdateSupplier
{
    public class UpdateSupplierCommand
        : SupplierDto
        , IMapFrom<UpdateSupplierCommand>
        , IRequest
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<UpdateSupplierCommand, SupplierDto>();
            profile.CreateMap<SupplierDto, Supplier>();
            profile.CreateMap<UpdateSupplierCommand, Supplier>();
        }

    }
}

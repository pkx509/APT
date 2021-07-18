using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Documents;
using GFCA.Shared.Models.Dto;

namespace GFCA.Application.Documents.FixedContracts.Commands.UpdateFixedContract
{
    public class UpdateFixedContractCommand
        : FixedContractDto
        , IMapFrom<UpdateFixedContractCommand>
    {
        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<UpdateFixedContractCommand, FixedContractDto>();
            profile.CreateMap<FixedContractDto, FixedContract>();
            profile.CreateMap<UpdateFixedContractCommand, FixedContract>();
        }
    }
}

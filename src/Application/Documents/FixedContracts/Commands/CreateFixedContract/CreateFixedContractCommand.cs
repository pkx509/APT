using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Documents;
using GFCA.Shared.Models.Dto;

namespace GFCA.Application.Documents.FixedContracts.Commands.CreateFixedContract
{
    public class CreateFixedContractCommand : FixedContractDto
        , IMapFrom<CreateFixedContractCommand>
    {
        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<CreateFixedContractCommand, FixedContractDto>();
            profile.CreateMap<FixedContractDto, FixedContract>();
            profile.CreateMap<CreateFixedContractCommand, FixedContract>();
        }

    }
}

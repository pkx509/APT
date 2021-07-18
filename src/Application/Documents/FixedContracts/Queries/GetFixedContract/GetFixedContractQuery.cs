using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Documents;
using GFCA.Shared.Models.Dto;
using GFCA.Shared.Models.Vm;
using MediatR;

namespace GFCA.Application.Documents.FixedContracts.Queries.GetFixedContract
{
    public class GetFixedContractQuery
        : FixedContractDto
        , IMapFrom<GetFixedContractQuery>
        , IRequest<FixedContractVm>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetFixedContractQuery, FixedContractDto>();
            profile.CreateMap<FixedContractDto, FixedContract>();
            profile.CreateMap<GetFixedContractQuery, FixedContract>();

            profile.CreateMap<FixedContract, FixedContractDto>();
            profile.CreateMap<FixedContract, GetFixedContractQuery>();
        }
    }
}

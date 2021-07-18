using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Documents;
using GFCA.Shared.Models.Dto;
using GFCA.Shared.Models.Vm;
using MediatR;

namespace GFCA.Application.Documents.Budgets.Queries.GetBudget
{
    public class GetBudgetQuery
        : BudgetDto
        , IMapFrom<GetBudgetQuery>
        , IRequest<BudgetVm>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetBudgetQuery, BudgetDto>();
            profile.CreateMap<BudgetDto, Budget>();
            profile.CreateMap<GetBudgetQuery, Budget>();

            profile.CreateMap<Budget, BudgetDto>();
            profile.CreateMap<Budget, GetBudgetQuery>();
        }
    }
}

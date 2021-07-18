using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Documents;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Documents.Budgets.Commands.CreateBudget
{
    public class CreateBudgetCommand
        : BudgetDto
        , IMapFrom<CreateBudgetCommand>
        , IRequest<int>
    {
        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<CreateBudgetCommand, BudgetDto>();
            profile.CreateMap<BudgetDto, Budget>();
            profile.CreateMap<CreateBudgetCommand, Budget>();
        }

    }
}

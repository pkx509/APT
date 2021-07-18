using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Documents;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Documents.Budgets.Commands.UpdateBudget
{
    public class UpdateBudgetCommand
        : BudgetDto
        , IMapFrom<UpdateBudgetCommand>
        , IRequest
    {
        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<UpdateBudgetCommand, BudgetDto>();
            profile.CreateMap<BudgetDto, Budget>();
            profile.CreateMap<UpdateBudgetCommand, Budget>();
        }
    }
}

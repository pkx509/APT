using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Workflows;
using GFCA.Shared.Models.Dto;
using GFCA.Shared.Models.Vm;
using MediatR;

namespace GFCA.Application.Workflows.Workflows.Queries.GetWorkflow
{
    public class GetWorkflowQuery
        : WorkflowDto
        , IMapFrom<GetWorkflowQuery>
        , IRequest<WorkflowVm>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetWorkflowQuery, WorkflowDto>();
            profile.CreateMap<WorkflowDto, Workflow>();
            profile.CreateMap<GetWorkflowQuery, Workflow>();

            profile.CreateMap<Workflow, WorkflowDto>();
            profile.CreateMap<Workflow, GetWorkflowQuery>();
        }
    }

}
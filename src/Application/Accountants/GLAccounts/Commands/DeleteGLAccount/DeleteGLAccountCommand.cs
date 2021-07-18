using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Accountants;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Accountants.GLAccounts.Commands.DeleteGLAccount
{
    public class DeleteGLAccountCommand
        : GLAccountDto
        , IMapFrom<GLAccountDto>
        , IRequest
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<DeleteGLAccountCommand, GLAccountDto>();
            profile.CreateMap<GLAccountDto, GLAccount>();
            profile.CreateMap<DeleteGLAccountCommand, GLAccount>();
        }

    }
}

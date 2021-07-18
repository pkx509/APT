using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Documents;
using GFCA.Shared.Models.Dto;
using GFCA.Shared.Models.Vm;
using MediatR;

namespace GFCA.Application.Documents.DocumentTypes.Queries.GetDocumentType
{
    public class GetDocumentTypeQuery
        : DocumentTypeDto
        , IMapFrom<GetDocumentTypeQuery>
        , IRequest<DocumentTypeVm>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetDocumentTypeQuery, DocumentTypeDto>();
            profile.CreateMap<DocumentTypeDto, DocumentType>();
            profile.CreateMap<GetDocumentTypeQuery, DocumentType>();

            profile.CreateMap<DocumentType, DocumentTypeDto>();
            profile.CreateMap<DocumentType, GetDocumentTypeQuery>();
        }
    }
}

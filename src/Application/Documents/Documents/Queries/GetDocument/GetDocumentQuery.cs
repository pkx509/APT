using MediatR;
using GFCA.Domain.Enums;
using GFCA.Shared.Models.Vm;
using GFCA.Application.Common.Mappings;
using GFCA.Shared.Models.Dto;
using GFCA.Domain.Entities.Documents;
using AutoMapper;

namespace GFCA.Application.Documents.Queries.GetDocument
{
    public class GetDocumentQuery : DocumentDto
        , IMapFrom<GetDocumentQuery>
        , IRequest<DocumentVm>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetDocumentQuery, DocumentDto>();
            profile.CreateMap<DocumentDto, Document>();
            profile.CreateMap<GetDocumentQuery, Document>();

            profile.CreateMap<Document, DocumentDto>();
            profile.CreateMap<Document, GetDocumentQuery>();
        }
    }
}

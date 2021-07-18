using AutoMapper;
using MediatR;
using GFCA.Application.Common.Mappings;
using GFCA.Shared.Models.Dto;
using GFCA.Domain.Entities.Documents;

namespace GFCA.Application.Documents.Commands.CreateDocument
{

    public class CreateDocumentCommand
        : DocumentDto
        , IMapFrom<CreateDocumentCommand>
        , IRequest<int>
    {
        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<CreateDocumentCommand, DocumentDto>();
            profile.CreateMap<DocumentDto, Document>();
            profile.CreateMap<CreateDocumentCommand, Document>();
        }

    }

}

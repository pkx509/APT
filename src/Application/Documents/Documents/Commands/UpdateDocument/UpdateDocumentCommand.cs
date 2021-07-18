using AutoMapper;
using GFCA.Application.Common.Mappings;
using MediatR;
using GFCA.Shared.Models.Dto;
using GFCA.Domain.Entities.Documents;

namespace GFCA.Application.Documents.Commands.UpdateDocument
{

    public class UpdateDocumentCommand : DocumentDto, IRequest, IMapFrom<UpdateDocumentCommand>
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<UpdateDocumentCommand, DocumentDto>();
            profile.CreateMap<DocumentDto, Document>();
            profile.CreateMap<UpdateDocumentCommand, Document>();
        }

    }

}

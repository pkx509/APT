using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Documents;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Documents.DocumentTypes.Commands.UpdateDocumentType
{
    public class UpdateDocumentTypeCommand
        : DocumentTypeDto
        , IRequest
        , IMapFrom<UpdateDocumentTypeCommand>
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<UpdateDocumentTypeCommand, DocumentDto>();
            profile.CreateMap<DocumentTypeDto, DocumentType>();
            profile.CreateMap<UpdateDocumentTypeCommand, DocumentType>();
        }

    }
}

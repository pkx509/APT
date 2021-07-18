using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Documents;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Documents.DocumentTypes.Commands.CreateDocumentType
{
    public class CreateDocumentTypeCommand
        : DocumentTypeDto
        , IMapFrom<CreateDocumentTypeCommand>
        , IRequest<int>
    {
        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<CreateDocumentTypeCommand, DocumentTypeDto>();
            profile.CreateMap<DocumentTypeDto, DocumentType>();
            profile.CreateMap<CreateDocumentTypeCommand, DocumentType>();
        }

    }
}

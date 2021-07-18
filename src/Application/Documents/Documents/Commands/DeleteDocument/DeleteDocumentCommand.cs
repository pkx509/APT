using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Exceptions;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities;
using MediatR;

namespace GFCA.Application.Documents.Commands.DeleteDocument
{
    public class DeleteDocumentCommand : IRequest
    {
        public int DocumentId { get; set; }
    }

}

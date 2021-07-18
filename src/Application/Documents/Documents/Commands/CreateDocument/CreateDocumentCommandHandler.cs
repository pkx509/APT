using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.Documents;
using GFCA.Shared.Models.Dto;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GFCA.Application.Documents.Commands.CreateDocument
{
    public class CreateDocumentCommandHandler : IRequestHandler<CreateDocumentCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public CreateDocumentCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<int> Handle(CreateDocumentCommand request, CancellationToken cancellationToken)
        {
            var d = _mapper.Map<DocumentDto>(request);
            var doc = _mapper.Map<Document>(d);

            try
            {

                await _context.BeginTransactionAsync();
                string userName = (_currentUser.UserId > 0) ? "Anonymous User" : _currentUser.UserName;
                var docType = await _context.DocumentTypes.FindAsync(request.DocumentTypeId);
                string referenceNo = $"{docType.DocumentTypeCode}-{doc.DocumentYear:0000}{doc.DocumentMonth:00}-{doc.Version:00}{doc.Revision:00}";
                doc.ReferenceNo = referenceNo;
                doc.DocumentTypeCode = docType.DocumentTypeCode;

                //var actor = await _context.Actors.FirstOrDefaultAsync(d => d.ActorName.Equals(userId));
                var actor = await _context.Actors.FirstOrDefaultAsync(d => d.ActorId == 1);
                if (actor != null)
                {
                    var da = new DocumentAction();
                    da.DocumentId = doc.DocumentId;
                    da.ActorId = actor.ActorId;
                    da.ActorName = actor.ActorName;
                    da.TimeStamp = _dateTime.Now;
                    //_context.DocumentActions.Add(da);
                    //await _context.SaveChangesAsync(cancellationToken);
                    doc.DocumentActions.Add(da);
                }

                if (docType.DocumentTypeCode.StartsWith("FC"))
                {
                    IList<FixedContractDto> dtos = request.FixedContracts;
                    foreach (var dto in dtos)
                    {
                        dto.DocumentId = doc.DocumentId;
                        var fc = _mapper.Map<FixedContract>(dto);
                        //_context.FixedContracts.Add(fc);
                        //await _context.SaveChangesAsync(cancellationToken);
                        doc.FixedContracts.Add(fc);
                    }
                }

                if (docType.DocumentTypeCode.StartsWith("BP"))
                {
                    IList<BudgetDto> dtos = request.Budgets;
                    foreach (var dto in dtos)
                    {
                        dto.DocumentId = doc.DocumentId;
                        var b = _mapper.Map<Budget>(dto);
                        //_context.Budgets.Add(b);
                        //await _context.SaveChangesAsync(cancellationToken);
                        doc.Budgets.Add(b);
                    }
                }

                if (docType.DocumentTypeCode.StartsWith("SF"))
                {
                    IList<SaleForecastDto> dtos = request.SaleForecasts;
                    foreach (var dto in dtos)
                    {
                        dto.DocumentId = doc.DocumentId;
                        var s = _mapper.Map<SaleForecast>(dto);
                        //_context.SaleForecasts.Add(s);
                        //await _context.SaveChangesAsync(cancellationToken);
                        doc.SaleForecasts.Add(s);
                    }
                }

                _context.Documents.Add(doc);
                await _context.SaveChangesAsync(cancellationToken);
                await _context.CommitTransactionAsync();

            }
            catch
            {
                _context.RollbackTransaction();
            }

            return doc.DocumentId;
        }

    }
}

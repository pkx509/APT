using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Exceptions;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.Documents;
using GFCA.Shared.Models.Dto;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GFCA.Application.Documents.Commands.UpdateDocument
{
    public class UpdateDocumentCommandHandler : IRequestHandler<UpdateDocumentCommand>
    {

        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        public UpdateDocumentCommandHandler(IApplicationDbContext context, IMapper mapper, IDateTime dateTime)
        {
            _context = context;
            _mapper = mapper;
            _dateTime = dateTime;

        }
        public async Task<Unit> Handle(UpdateDocumentCommand request, CancellationToken cancellationToken)
        {

            var doc = _mapper.Map<DocumentDto>(request);
            var entity = await _context.Documents.FindAsync(doc.DocumentId);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Document), request.DocumentId);
            }

            //var doc = _mapper.Map<Document>(request);

            entity.ClientCode = doc.ClientCode;
            entity.ClientName = doc.ClientName;
            entity.CustomerCode = doc.CustomerCode;
            entity.CustomerName = doc.CustomerName;
            entity.TotalSale = doc.TotalSale;
            entity.TotalInvestment = doc.TotalInvestment;
            entity.CurrentState = doc.CurrentState;
            entity.NextState = doc.NextState;

            var da = await _context.DocumentActions.FirstOrDefaultAsync(o => o.DocumentId == request.DocumentId && o.TimeStamp < _dateTime.Now);
            //var actor = await _context.Actors.FirstOrDefaultAsync(d => d.ActorName.Equals(userId));
            var actor = await _context.Actors.FirstOrDefaultAsync(d => d.ActorId == 1);
            if (!doc.CurrentState.Equals(entity.CurrentState))
            {

                var dac = new DocumentAction();
                dac.DocumentId = doc.DocumentId.Value;
                dac.ActorId = actor.ActorId;
                dac.ActorName = actor.ActorName;
                dac.TimeStamp = _dateTime.Now;
                _context.DocumentActions.Add(dac);
            }
            else
            {
                da.DocumentId = doc.DocumentId.Value;
                da.ActorId = actor.ActorId;
                da.ActorName = actor.ActorName;
                da.TimeStamp = _dateTime.Now;
            }

            var dfc = _context.FixedContracts.Where(w => w.DocumentId == doc.DocumentId);
            if (dfc.Count() > 0)
            {
                var dto = _mapper.Map<FixedContractDto>(request);
                var fc = _mapper.Map<FixedContract>(dto);
                _context.FixedContracts.Add(fc);
            }
            else
            {
            }


            var dbg = _context.Budgets.Where(w => w.DocumentId == doc.DocumentId);
            if (dbg.Count() > 0)
            {
            }
            else
            {
            }

            var dsf = _context.SaleForecasts.Where(w => w.DocumentId == doc.DocumentId);
            if (dsf.Count() > 0)
            {
            }
            else
            {
            }

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

        }
    }
}

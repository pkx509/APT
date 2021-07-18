using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Exceptions;
using GFCA.Application.Common.Interfaces;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities;
using MediatR;

namespace GFCA.Application.EmailInbounds.Commands.UpdateEmailInbound
{

    public class UpdateEmailInboundCommand : IRequest, IMapFrom<UpdateEmailInboundCommand>
    {
        public int EmailID { get; set; }
        public string FromEmail { get; set; }
        public string DataPath { get; set; }
        public bool IsActive { get; set; }
        public string Remark { get; set; }

        public void Mapping(Profile profile)
        {
            profile.AllowNullDestinationValues = true;
            profile.CreateMap<UpdateEmailInboundCommand, EmailInbound>()
                .ForMember(d => d.IsActive, o => o.MapFrom(s => s.IsActive == true ? 1 : 0));
        }
    }


    public class UpdateEmailInboundCommandHanler : IRequestHandler<UpdateEmailInboundCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public UpdateEmailInboundCommandHanler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateEmailInboundCommand request, CancellationToken cancellationToken)
        {

            var model = _mapper.Map<EmailInbound>(request);
            var entity = await _context.EmailInbounds.FindAsync(model.EmailID);

            if (entity == null)
            {
                throw new NotFoundException(nameof(EmailInbound), request.EmailID);
            }

            entity.DataPath = model.DataPath;
            entity.FromEmail = model.FromEmail;
            entity.IsActive = model.IsActive;
            entity.Remark = model.Remark;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

        }
    }

}

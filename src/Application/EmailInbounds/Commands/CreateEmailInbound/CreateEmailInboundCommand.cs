using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Interfaces;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities;
using MediatR;

namespace GFCA.Application.EmailInbounds.Commands.CreateEmailInbound
{
    public class CreateEmailInboundCommand : IRequest<int>, IMapFrom<CreateEmailInboundCommand>
    {
        public int EmailID { get; set; }
        public string FromEmail { get; set; }
        public string DataPath { get; set; }
        public bool IsActive { get; set; }
        public string Remark { get; set; }


        public void Mapping(Profile profile)
        {
            profile.AllowNullDestinationValues = true;
            profile.CreateMap<CreateEmailInboundCommand, EmailInbound>()
                .ForMember(d => d.IsActive, o => o.MapFrom(s => s.IsActive == true ? 1 : 0));
        }


    }


    public class CreateEmailInboundCommandHanler : IRequestHandler<CreateEmailInboundCommand, int>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        public CreateEmailInboundCommandHanler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateEmailInboundCommand request, CancellationToken cancellationToken)
        {
            /*
            var entity = new EmailInbound
            {
                EmailID = request.EmailID,
                FromEmail = request.FromEmail,
                DataPath = request.DataPath,
                IsActive = request.IsActive ? 1: 0,
                Remark = request.Remark
            };
            */
            var entity = _mapper.Map<EmailInbound>(request);
            _context.EmailInbounds.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);
            
            return entity.EmailID;
        }


    }
}

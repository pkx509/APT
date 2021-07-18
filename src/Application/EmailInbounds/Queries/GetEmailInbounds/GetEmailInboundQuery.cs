using System;
using System.Threading;
using System.Threading.Tasks;
using GFCA.Application.Common.Exceptions;
using GFCA.Application.Common.Interfaces;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities;
using MediatR;
using AutoMapper;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace GFCA.Application.EmailInbounds.Queries.GetEmailInbounds
{
    public class GetEmailInboundQueryRequest : IRequest<GetEmailInboundQueryResponse>
    {
        public int? Id { get; set; } = default;
        public int? Skip { get; set; } = 0;
        public int? Take { get; set; } = 0;
        public int? Count { get; set; } = 0;
    }

    public class GetEmailInboundQueryResponse : Common.Models.Result
    {
        //public IQueryable<EmailInbound> Items { get; set; } = default;
        public dynamic Items { get; set; } = default;
        public int Count { get; set; } = 0;
        public GetEmailInboundQueryResponse(bool success, IEnumerable<string> error) : base(success, error)
        {

        }
    }

    public class GetEmailInboundQueryHandler : IRequestHandler<GetEmailInboundQueryRequest, GetEmailInboundQueryResponse>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetEmailInboundQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetEmailInboundQueryResponse> Handle(GetEmailInboundQueryRequest request, CancellationToken cancellationToken)
        {
            dynamic data = default;

            var count = 0;
            int skip = request.Skip ?? 0;
            int take = request.Take ?? 0;
            if (request.Id == null)
            {

                count = await _context.EmailInbounds.CountAsync();
                data = await _context.EmailInbounds
                .AsNoTracking()
                //.Skip(skip)
                //.Take(take)
                .ToListAsync(cancellationToken);
            }
            else
            {
                count = await _context.EmailInbounds.CountAsync();
                data = await _context.EmailInbounds
                    .FindAsync(new object[] { request.Id }, cancellationToken);

            }

            IEnumerable<string> err = new List<string>();
            var response = new GetEmailInboundQueryResponse(true, err);
            response.Items = data;
            response.Count = count;

            return await Task.FromResult(response);
        }

    }
}

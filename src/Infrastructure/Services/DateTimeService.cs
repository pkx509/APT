using GFCA.Application.Common.Interfaces;
using System;

namespace GFCA.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}

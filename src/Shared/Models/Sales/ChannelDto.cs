using System;
using GFCA.Shared.Models.Common;

namespace GFCA.Shared.Models.Dto
{
    public class ChannelDto : AuditableDtoBase
    {
        public int ChannelId { get; set; } = 0;
        public string ChannelCode { get; set; }
        public string ChannelName { get; set; }
        public string ChannelDesc { get; set; }

    }
}

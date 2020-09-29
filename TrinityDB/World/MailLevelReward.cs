using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class MailLevelReward
    {
        public byte Level { get; set; }
        public uint RaceMask { get; set; }
        public uint MailTemplateId { get; set; }
        public uint SenderEntry { get; set; }
    }
}

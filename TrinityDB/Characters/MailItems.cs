using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class MailItems
    {
        public uint MailId { get; set; }
        public ulong ItemGuid { get; set; }
        public ulong Receiver { get; set; }
    }
}

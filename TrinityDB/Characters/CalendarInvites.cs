using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CalendarInvites
    {
        public ulong InviteId { get; set; }
        public ulong EventId { get; set; }
        public ulong Invitee { get; set; }
        public ulong Sender { get; set; }
        public byte Status { get; set; }
        public uint ResponseTime { get; set; }
        public byte ModerationRank { get; set; }
        public string Note { get; set; }
    }
}

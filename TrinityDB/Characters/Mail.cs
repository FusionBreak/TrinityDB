using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class Mail
    {
        public uint Id { get; set; }
        public byte MessageType { get; set; }
        public sbyte Stationery { get; set; }
        public ushort MailTemplateId { get; set; }
        public ulong Sender { get; set; }
        public ulong Receiver { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public byte HasItems { get; set; }
        public uint ExpireTime { get; set; }
        public uint DeliverTime { get; set; }
        public ulong Money { get; set; }
        public ulong Cod { get; set; }
        public byte Checked { get; set; }
    }
}

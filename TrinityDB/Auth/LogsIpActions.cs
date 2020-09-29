﻿using System;
using System.Collections.Generic;

namespace TrinityDB.Auth
{
    public partial class LogsIpActions
    {
        public uint Id { get; set; }
        public uint AccountId { get; set; }
        public ulong CharacterGuid { get; set; }
        public byte Type { get; set; }
        public string Ip { get; set; }
        public string Systemnote { get; set; }
        public uint Unixtime { get; set; }
        public DateTime Time { get; set; }
        public string Comment { get; set; }
    }
}

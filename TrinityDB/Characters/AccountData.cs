﻿using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class AccountData
    {
        public uint AccountId { get; set; }
        public byte Type { get; set; }
        public uint Time { get; set; }
        public byte[] Data { get; set; }
    }
}

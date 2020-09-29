using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class Bugreport
    {
        public uint Id { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
    }
}

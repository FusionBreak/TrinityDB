using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class Petition
    {
        public ulong Ownerguid { get; set; }
        public ulong? Petitionguid { get; set; }
        public string Name { get; set; }
    }
}

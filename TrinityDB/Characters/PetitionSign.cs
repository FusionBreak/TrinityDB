using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class PetitionSign
    {
        public ulong Ownerguid { get; set; }
        public ulong Petitionguid { get; set; }
        public ulong Playerguid { get; set; }
        public uint PlayerAccount { get; set; }
    }
}

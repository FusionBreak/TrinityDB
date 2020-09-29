using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class TransmogHoliday
    {
        public uint Id { get; set; }
        public int RequiredTransmogHoliday { get; set; }
        public short VerifiedBuild { get; set; }
    }
}

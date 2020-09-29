using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class SpellAreatrigger
    {
        public uint SpellMiscId { get; set; }
        public uint AreaTriggerId { get; set; }
        public uint MoveCurveId { get; set; }
        public uint ScaleCurveId { get; set; }
        public uint MorphCurveId { get; set; }
        public uint FacingCurveId { get; set; }
        public uint DecalPropertiesId { get; set; }
        public uint TimeToTarget { get; set; }
        public uint TimeToTargetScale { get; set; }
        public uint VerifiedBuild { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterGarrisonFollowers
    {
        public CharacterGarrisonFollowers()
        {
            CharacterGarrisonFollowerAbilities = new HashSet<CharacterGarrisonFollowerAbilities>();
        }

        public ulong DbId { get; set; }
        public ulong Guid { get; set; }
        public uint FollowerId { get; set; }
        public uint Quality { get; set; }
        public uint Level { get; set; }
        public uint ItemLevelWeapon { get; set; }
        public uint ItemLevelArmor { get; set; }
        public uint Xp { get; set; }
        public uint CurrentBuilding { get; set; }
        public uint CurrentMission { get; set; }
        public uint Status { get; set; }

        public virtual Characters Gu { get; set; }
        public virtual ICollection<CharacterGarrisonFollowerAbilities> CharacterGarrisonFollowerAbilities { get; set; }
    }
}

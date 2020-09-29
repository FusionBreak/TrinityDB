using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class CreatureClasslevelstats
    {
        public sbyte Level { get; set; }
        public sbyte Class { get; set; }
        public uint Basemana { get; set; }
        public uint Basearmor { get; set; }
        public short Attackpower { get; set; }
        public short Rangedattackpower { get; set; }
        public float DamageBase { get; set; }
        public float DamageExp1 { get; set; }
        public float DamageExp2 { get; set; }
        public float DamageExp3 { get; set; }
        public float DamageExp4 { get; set; }
        public float DamageExp5 { get; set; }
        public string Comment { get; set; }
    }
}

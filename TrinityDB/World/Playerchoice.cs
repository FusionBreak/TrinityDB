using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class Playerchoice
    {
        public int ChoiceId { get; set; }
        public int UiTextureKitId { get; set; }
        public string Question { get; set; }
        public bool HideWarboardHeader { get; set; }
        public short VerifiedBuild { get; set; }
    }
}

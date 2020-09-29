using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpellItemEnchantmentCondition
    {
        public uint Id { get; set; }
        public uint LtOperand1 { get; set; }
        public uint LtOperand2 { get; set; }
        public uint LtOperand3 { get; set; }
        public uint LtOperand4 { get; set; }
        public uint LtOperand5 { get; set; }
        public byte LtOperandType1 { get; set; }
        public byte LtOperandType2 { get; set; }
        public byte LtOperandType3 { get; set; }
        public byte LtOperandType4 { get; set; }
        public byte LtOperandType5 { get; set; }
        public byte Operator1 { get; set; }
        public byte Operator2 { get; set; }
        public byte Operator3 { get; set; }
        public byte Operator4 { get; set; }
        public byte Operator5 { get; set; }
        public byte RtOperandType1 { get; set; }
        public byte RtOperandType2 { get; set; }
        public byte RtOperandType3 { get; set; }
        public byte RtOperandType4 { get; set; }
        public byte RtOperandType5 { get; set; }
        public byte RtOperand1 { get; set; }
        public byte RtOperand2 { get; set; }
        public byte RtOperand3 { get; set; }
        public byte RtOperand4 { get; set; }
        public byte RtOperand5 { get; set; }
        public byte Logic1 { get; set; }
        public byte Logic2 { get; set; }
        public byte Logic3 { get; set; }
        public byte Logic4 { get; set; }
        public byte Logic5 { get; set; }
        public short VerifiedBuild { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSoftware.Common.Enums
{
    public enum IlanVarmi : byte
    {
        [Description("İlan Var")]
        IlanVar = 1,
        [Description("İlan Yok")]
        IlanYok = 2
    }
}

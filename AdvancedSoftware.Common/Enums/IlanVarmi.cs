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
        [Description("İLAN VAR")]
        IlanVar = 1,
        [Description("İLAN YOK")]
        IlanYok = 2
    }
}

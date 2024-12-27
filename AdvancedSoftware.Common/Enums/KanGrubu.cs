using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSoftware.Common.Enums
{
    public enum KanGrubu
    {
        [Description("A RH+")]
        A_RH_Pozitif = 1,
        [Description("A RH-")]
        A_RH_Negatif = 2,
        [Description("B RH+")]
        B_RH_Pozitif = 3,
        [Description("B RH-")]
        B_RH_Negatif = 4,
        [Description("AB RH+")]
        AB_RH_Pozitif = 5,
        [Description("AB RH-")]
        AB_RH_Negatif = 6,
        [Description("0 RH+")]
        Sifir_RH_Pozitif = 7,
        [Description("0 RH-")]
        Sifir_RH_Negatif = 8,
        [Description("Bilinmiyor")]
        Bilinmiyor = 9
    }
}

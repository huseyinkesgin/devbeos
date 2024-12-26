using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSoftware.Common.Enums
{
    public enum Danisman : byte
    {
        [Description("Nedim Akbacak")]
        NedimAkbacak = 1,
        [Description("Ömer Bahadır Gülseren")]
        OmerBahadirGulseren = 2,
        [Description("Abdurrahman Kılıç")]
        AbdurrahmanKilic = 3,
    }
}

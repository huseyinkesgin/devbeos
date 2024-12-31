using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum EkUcretler : byte
    {
        [Description("KDV")]
        KDV = 1,
        [Description("STOPAJ")]
        Stopaj = 2,
        [Description("YOK")]
        Yok = 3
    }
}

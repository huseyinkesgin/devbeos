using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum PortfoyDurumu : byte
    {
        [Description("OLUMLU")]
        Olumlu = 1,
        [Description("OLUMSUZ")]
        Olumsuz = 2,
        [Description("DEVAM EDİYOR")]
        DevamEdiyor = 3,
    }
}

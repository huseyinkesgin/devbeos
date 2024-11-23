using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum KartTuru: byte
    {
        [Description("Kargo Firma Kaydı")]
        KargoFirmasi = 1,

        [Description("İl Kaydı")]
        Il = 2,

        [Description("İlçe Kaydı")]
        Ilce = 3,

        [Description("Ofis")]
        Ofis = 1,

    }
}

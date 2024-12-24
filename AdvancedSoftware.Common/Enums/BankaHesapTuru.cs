using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum BankaHesapTuru : byte
    {
        [Description("Vadesiz Mevduat Hesabı")]
        VadesizMevduatHesabi = 1,
        [Description("Vadeli Mevduat Hesabı")]
        VadeliMevduatHesabi = 2,
        [Description("Kredi Hesabı")]
        KrediHesaabi = 3,
        [Description("Kredi Kartı Hesabı")]
        KrediKartiHesabi = 4,
        [Description("Yatırım Hesabı")]
        KrediHesabi = 5,
        [Description("Altın Hesabı")]
        AltinHesabi = 6,
        [Description("Döviz Hesabı")]
        DovizHesabi = 7,
        [Description("Diğer")]
        Diger = 8
    }
}

using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum BankaHesapTuru : byte
    {
        [Description("VADESİZ MEVDUAT HESABI")]
        VadesizMevduatHesabi = 1,
        [Description("VADELİ MEVDUAT HESABI")]
        VadeliMevduatHesabi = 2,
        [Description("KREDİ HESABI")]
        KrediHesaabi = 3,
        [Description("KREDİ KARTI HESABI")]
        KrediKartiHesabi = 4,
        [Description("YATIRIM HESABI")]
        KrediHesabi = 5,
        [Description("ALTIN HESABI")]
        AltinHesabi = 6,
        [Description("DÖVİZ HESABI")]
        DovizHesabi = 7,
        [Description("DİĞER")]
        Diger = 8
    }
}

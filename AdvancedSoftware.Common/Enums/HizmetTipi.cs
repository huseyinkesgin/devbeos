using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum HizmetTipi : byte
    {
        [Description("ONLINE")]
        Online =1,
        [Description("TELEFON")]
        Telefon = 2,
        [Description("YAZIŞMA")]
        Yazisma = 3,
        [Description("ZİYARET")]
        Ziyaret = 4,
        [Description("DİĞER")]
        Diger = 4,



    }
}

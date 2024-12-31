using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum SozlesmeTuru : byte
    {
        [Description("SİGORTA")]
        Sigorta = 1,
        [Description("KASKO")]
        Kasko = 2,
        [Description("DİĞER")]
        Diger = 3
    }
}

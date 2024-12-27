using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum YetkiliOfis : byte
    {
        [Description("TEK YETKİLİ")]
        TekYetkili = 1,
        [Description("PAYLAŞIMLI")]
        Paylasimli = 2,
        [Description("HAYIR")]
        Hayır = 3
    }
}

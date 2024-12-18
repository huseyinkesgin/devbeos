using AdavancedSoftware.Model.Entities.Base.Interfaces;
using AdvancedSoftware.Common.Enums;

namespace AdavancedSoftware.Model.Entities
{
    public class DokumParametreleri : IBaseEntity
    {
        public string RaporBaslik { get; set; }
        public EvetHayir BaslikEkle { get; set; }
        public RaporuKagidaSigdirmaTuru RaporKagidaSigdir { get; set; }
        public YazdirmaYonu YazdirmaYonu { get; set; }
        public EvetHayir YatayCizgileriGoster { get; set; }
        public EvetHayir DikeyCizgileriGoster { get; set; }
        public EvetHayir SutunBasliklariGoster { get; set; }
        public string YaziciAdi { get; set; }
        public int KopyaSayisi { get; set; }

        public DokumSekli DokumSekli { get; set; }
        public RaporuKagidaSigdirmaTuru RaporuKagidaSigdir { get; set; }
    }
}

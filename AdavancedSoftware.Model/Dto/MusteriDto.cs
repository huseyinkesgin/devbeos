using AdavancedSoftware.Model.Entities;
using AdavancedSoftware.Model.Entities.Base;
using AdvancedSoftware.Common.Enums;

namespace AdavancedSoftware.Model.Dto
{
    public class MusteriS : Musteri
    {
        public string FirmaAdi { get; set; }
        public string MusteriGrupAdi { get; set; }
    }

    public class MusteriL : BaseEntity
    {
        public string MusteriGrupAdi { get; set; }
        public MusteriTuru MusteriTuru { get; set; }
        public string AdSoyad { get; set; }
        public string Eposta { get; set; }
        public string Telefon { get; set; }
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string Adres { get; set; }
        public string Websitesi { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Linkedin { get; set; }
        public string Youtube { get; set; }
        public string Tiktok { get; set; }
        public string VK { get; set; }
        public string FirmaAdi { get; set; }
    }
}

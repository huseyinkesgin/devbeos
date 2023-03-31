using AdavancedSoftware.Model.Entities;
using AdavancedSoftware.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Dto
{
    [NotMapped]
    public class KargoFirmasiS :KargoFirmasi
    {
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
    }

    public class KargoFirmasiL :BaseEntity 
    {
        public string FirmaAdi { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public string MusteriHizmetleri { get; set; }
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string Adres { get; set; }

    }
}

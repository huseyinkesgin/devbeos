using AdavancedSoftware.Model.Entities;
using AdavancedSoftware.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Dto
{
    [NotMapped]
    public class FirmaS : Firma
    {
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string MahalleAdi { get; set; }
    }

    public class FirmaL : BaseEntity
    {
        public string FirmaAdi { get; set; }
        public string FaturaAdi { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string MersisNo { get; set; }
        public string KepAdresi { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string MahalleAdi { get; set; }
        public string Adres { get; set; }
        public string Websitesi { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Linkedin { get; set; }
        public string VK { get; set; }
        public string Youtube { get; set; }
        public string Tiktok { get; set; }
        public string Aciklama { get; set; }

    }
}

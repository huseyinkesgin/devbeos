using AdavancedSoftware.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Entities
{
    public class KargoFirmasi : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique =true)]
        public override string Kod { get; set; }

        [Required, StringLength(50)]
        public string FirmaAdi { get; set; }
        
        [Required, StringLength(15)]
        public string Telefon { get; set; }
        
        [Required, StringLength(70)]
        public string Eposta { get; set; }
        
        [Required, StringLength(50)]
        public string MusteriHizmetleri { get; set; }
        
        public long? IlId { get; set; }
        public long? IlceId { get; set; }
        
        [Required, StringLength(150)]
        public string Adres { get; set; }

        public Il Il { get; set; }
        public Ilce Ilce { get; set; }
    }
}

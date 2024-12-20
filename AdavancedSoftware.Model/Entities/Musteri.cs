using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedSoftware.Common.Enums;

namespace AdavancedSoftware.Model.Entities
{
    public class Musteri : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Müşteri Adı", "txtMusteriAdi")]
        public MusteriTuru MusteriTuru { get; set; } = MusteriTuru.Bireysel;

        public long MusteriGrupId { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }

        public string Eposta { get; set; }

        public string Telefon { get; set; }

        public long IlId { get; set; }
        public long IlceId { get; set; }
        public string Adres { get; set; }

        public string FirmaAdi { get; set; }
        public string FaturaAdi { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string FirmaEposta { get; set; }
        public string FirmaTelefon { get; set; }

        public string FirmaIlId { get; set; }
        public string FirmaIlceId { get; set; }
        public string FirmaAdres { get; set; }

        public string FirmaWebsitesi { get; set; }
        public string FirmaFacebook { get; set; }
        public string FirmaTwitter { get; set; }
        public string FirmaInstagram { get; set; }
        public string FirmaLinkedin { get; set; }
        public string  FirmaYoutube{ get; set; }
        public string FirmaVK { get; set; }
        [StringLength(500)]
        public string FirmaAciklama { get; set; }


        public  MusteriGrup MusteriGrup { get; set; }
        public Il Il { get; set; }
        public Ilce Ilce { get; set; }
    }
}

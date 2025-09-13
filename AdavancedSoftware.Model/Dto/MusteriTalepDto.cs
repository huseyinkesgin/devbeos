using AdavancedSoftware.Model.Entities;
using AdavancedSoftware.Model.Entities.Base;
using AdvancedSoftware.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Dto
{
    [NotMapped]
    public class MusteriTalepS : MusteriTalep
    {
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public string MusteriTelefon { get; set; }
        public string SorumluPersonelAdi { get; set; }
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string MahalleAdi { get; set; }
        public string PortfoyNo { get; set; }
        public string HizmetAdi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
        public string OzelKod3Adi { get; set; }
    }

    public class MusteriTalepL : BaseEntity
    {
        public string TalepBasligi { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriTelefon { get; set; }
        public string TalepTuru { get; set; }
        public string TalepDurumu { get; set; }
        public string OncelikSeviyesi { get; set; }
        public DateTime TalepTarihi { get; set; }
        public DateTime? TalepEdilecekTarih { get; set; }
        public DateTime? TamamlanmaTarihi { get; set; }
        public string SorumluPersonelAdi { get; set; }
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string MahalleAdi { get; set; }
        public decimal? MinBütce { get; set; }
        public decimal? MaxBütce { get; set; }
        public decimal? TeklifTutari { get; set; }
        public string TalepDetayi { get; set; }
        public string MusteriNotlari { get; set; }
        public string PersonelNotlari { get; set; }
        public bool Durum { get; set; }
    }
}

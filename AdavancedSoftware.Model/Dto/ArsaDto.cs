using AdavancedSoftware.Model.Entities;
using AdavancedSoftware.Model.Entities.Base;
using AdvancedSoftware.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Dto
{
    [NotMapped]
    public class ArsaS : Arsa
    {
        public string DanismanAdi { get; set; }
        public string MusteriAdi { get; set; }
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string MahalleAdi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
        public string OzelKod3Adi { get; set; }
        public string OzelKod4Adi { get; set; }
        public string OzelKod5Adi { get; set; }
    }

    public class ArsaL : BaseEntity
    {

        public PortfoyTuru PortfoyTuru { get; set; }
        public ImarDurumu ImarDurumu { get; set; }
        public string Baslik { get; set; }
        public decimal Ucret { get; set; }
        public EkUcretler EkUcretler { get; set; }
        public decimal? ArsaM2 { get; set; }
        public KrediyeUygunluk KrediyeUygunluk { get; set; }
        public VarYok? Takas { get; set; }
        public ArsaTapuTipi ArsaTapuTipi { get; set; }
        public string TasinmazNo { get; set; }
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string MahalleAdi { get; set; }
        public string BolgeAdi { get; set; }
        public int Ada { get; set; }
        public int Parsel { get; set; }
        public decimal Emsal { get; set; }
        public decimal Gabari { get; set; }
        public string Aciklama { get; set; }
        public string DanismanAdi { get; set; }
        public string MusteriAdi { get; set; }
        public IlanVarmi IlanVarmi { get; set; }
        public string Sahibinden { get; set; }
        public string SahibindenLink { get; set; }
        public string HepsiEmlak { get; set; }
        public string HepsiEmlakLink { get; set; }
        public string Zingat { get; set; }
        public string ZingatLink { get; set; }
        public string BuradaYapı { get; set; }
        public string BuradaYapıLink { get; set; }
        public string ArsaBurada { get; set; }
        public string ArsaBuradaLink { get; set; }
        public byte[] UyduGoruntusu { get; set; }
        public byte[] OznitelikGoruntusu { get; set; }
        public byte[] ImarDurumuGoruntusu { get; set; }
        public byte[] EgimGoruntusu { get; set; }
        public byte[] EimarGoruntusu { get; set; }

        public PortfoyDurumu PortfoyDurumu { get; set; }
        public YetkiliOfis YetkiliOfis { get; set; }
        public DateTime KayitTarihi { get; set; }
        public DateTime? IlanKayitTarihi { get; set; }
        public DateTime? IlanCikisTarihi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
        public string OzelKod3Adi { get; set; }
        public string OzelKod4Adi { get; set; }
        public string OzelKod5Adi { get; set; }
    }
}

using AdavancedSoftware.Model.Entities;
using AdavancedSoftware.Model.Entities.Base;
using AdvancedSoftware.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Dto
{
    [NotMapped]
    public class PortfoyS : Portfoy
    {
        public string PortfoyTipiAdi { get; set; }
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

    public class PortfoyL : BaseEntity
    {
        public string PortfoyNo { get; set; }
        public string PortfoyTipiAdi { get; set; }
        public PortfoyTuru PortfoyTuru { get; set; }
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string MahalleAdi { get; set; }
        public ImarDurumu ImarDurumu { get; set; }
        public decimal Ucret { get; set; }
        public decimal M2 { get; set; }
        public int Ada { get; set; }
        public int Parsel { get; set; }
        public string DanismanAdi { get; set; }
        public string MusteriAdi { get; set; }
        public PortfoyDurumu PortfoyDurumu { get; set; }
        public YetkiliOfis YetkiliOfis { get; set; }
        public DateTime KayitTarihi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
        public string OzelKod3Adi { get; set; }
        public string OzelKod4Adi { get; set; }
        public string OzelKod5Adi { get; set; }
    }
}

using AdavancedSoftware.Model.Dto;
using AdavancedSoftware.Model.Entities;
using AdavancedSoftware.Model.Entities.Base;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class ArsaBll : BaseGenelBll<Arsa>, IBaseGenelBll, IBaseCommonBll
    {
        public ArsaBll() : base(KartTuru.Arsa) { }

        public ArsaBll(Control ctrl) : base(ctrl, KartTuru.Arsa) { }

        public override BaseEntity Single(Expression<Func<Arsa, bool>> filter)
        {
            return BaseSingle(filter, x => new ArsaS
            {
                Id = x.Id,
                Kod = x.Kod,
                PortfoyTuru = x.PortfoyTuru,
                ImarDurumu = x.ImarDurumu,
                Baslik = x.Baslik,
                Ucret = x.Ucret,
                EkUcretler = x.EkUcretler,
                ArsaM2 = x.ArsaM2,
                KrediyeUygunluk = x.KrediyeUygunluk,
                Takas = x.Takas,
                ArsaTapuTipi = x.ArsaTapuTipi,
                TasinmazNo = x.TasinmazNo,
                IlId = x.IlId,
                IlAdi = x.Il.IlAdi,
                IlceId = x.IlceId,
                IlceAdi = x.Ilce.IlceAdi,
                MahalleId = x.MahalleId,
                MahalleAdi = x.Mahalle.MahalleAdi,
                BölgeAdi = x.BölgeAdi,
                Ada = x.Ada,
                Parsel = x.Parsel,
                Emsal = x.Emsal,
                Gabari = x.Gabari,
                Aciklama = x.Aciklama,
                DanismanId = x.DanismanId,
                DanismanAdi = x.Danisman.Ad,
                MusteriId = x.MusteriId,
                MusteriAdi = x.Musteri.Ad,
                IlanVarmi = x.IlanVarmi,
                Sahibinden = x.Sahibinden,
                SahibindenLink = x.SahibindenLink,
                HepsiEmlak = x.HepsiEmlak,
                HepsiEmlakLink = x.HepsiEmlakLink,
                BuradaYapı = x.BuradaYapı,
                BuradaYapıLink = x.BuradaYapıLink,
                ArsaBurada = x.ArsaBurada,
                ArsaBuradaLink = x.ArsaBuradaLink,
                UyduGoruntusu = x.UyduGoruntusu,
                OznitelikGoruntusu = x.OznitelikGoruntusu,
                ImarDurumuGoruntusu = x.ImarDurumuGoruntusu,
                EgimGoruntusu = x.EgimGoruntusu,
                EimarGoruntusu = x.EimarGoruntusu,
                PortfoyDurumu = x.PortfoyDurumu,
                YetkiliOfis = x.YetkiliOfis,
                KayitTarihi = x.KayitTarihi,
                IlanKayitTarihi = x.IlanKayitTarihi,
                IlanCikisTarihi = x.IlanCikisTarihi,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                OzelKod3Id = x.OzelKod3Id,
                OzelKod3Adi = x.OzelKod3.OzelKodAdi,
                OzelKod4Id = x.OzelKod4Id,
                OzelKod4Adi = x.OzelKod4.OzelKodAdi,
                OzelKod5Id = x.OzelKod5Id,
                OzelKod5Adi = x.OzelKod5.OzelKodAdi,
                Durum = x.Durum,
               
            });
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<Arsa, bool>> filter)
        {
            return BaseList(filter, x => new ArsaL
            {
                Id = x.Id,
                Kod = x.Kod,
                PortfoyTuru = x.PortfoyTuru,
                ImarDurumu = x.ImarDurumu,
                Baslik = x.Baslik,
                Ucret = x.Ucret,
                EkUcretler = x.EkUcretler,
                ArsaM2 = x.ArsaM2,
                KrediyeUygunluk = x.KrediyeUygunluk,
                Takas = x.Takas,
                ArsaTapuTipi = x.ArsaTapuTipi,
                TasinmazNo = x.TasinmazNo,
                IlAdi = x.Il.IlAdi,
                IlceAdi = x.Ilce.IlceAdi,
                MahalleAdi = x.Mahalle.MahalleAdi,
                BolgeAdi = x.BölgeAdi,
                Ada = x.Ada,
                Parsel = x.Parsel,
                //Emsal = x.Emsal,
                //Gabari = x.Gabari,
                Aciklama = x.Aciklama,
                DanismanAdi = x.Danisman.Ad,
                MusteriAdi = x.Musteri.Ad,
                IlanVarmi = x.IlanVarmi,
                Sahibinden = x.Sahibinden,
                SahibindenLink = x.SahibindenLink,
                HepsiEmlak = x.HepsiEmlak,
                HepsiEmlakLink = x.HepsiEmlakLink,
                BuradaYapı = x.BuradaYapı,
                BuradaYapıLink = x.BuradaYapıLink,
                ArsaBurada = x.ArsaBurada,
                ArsaBuradaLink = x.ArsaBuradaLink,
                UyduGoruntusu = x.UyduGoruntusu,
                OznitelikGoruntusu = x.OznitelikGoruntusu,
                ImarDurumuGoruntusu = x.ImarDurumuGoruntusu,
                EgimGoruntusu = x.EgimGoruntusu,
                EimarGoruntusu = x.EimarGoruntusu,
                PortfoyDurumu = x.PortfoyDurumu,
                YetkiliOfis = x.YetkiliOfis,
                KayitTarihi = x.KayitTarihi,
                IlanKayitTarihi = x.IlanKayitTarihi,
                IlanCikisTarihi = x.IlanCikisTarihi,     
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                OzelKod3Adi = x.OzelKod3.OzelKodAdi,
                OzelKod4Adi = x.OzelKod4.OzelKodAdi,
                OzelKod5Adi = x.OzelKod5.OzelKodAdi,
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}

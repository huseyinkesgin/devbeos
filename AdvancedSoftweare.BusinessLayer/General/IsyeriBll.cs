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
    public class IsyeriBll : BaseGenelBll<Isyeri>, IBaseGenelBll, IBaseCommonBll
    {
        public IsyeriBll() : base(KartTuru.Isyeri) { }

        public IsyeriBll(Control ctrl) : base(ctrl, KartTuru.Isyeri) { }

        public override BaseEntity Single(Expression<Func<Isyeri, bool>> filter)
        {
            return BaseSingle(filter, x => new IsyeriS
            {
                Id = x.Id,
                Kod = x.Kod,
                IsyeriTipiId = x.IsyeriTipiId,
                IsyeriTipiAdi = x.IsyeriTipi.IsyeriTipiAdi,
                PortfoyTuru = x.PortfoyTuru,
                ImarDurumu = x.ImarDurumu,
                Baslik = x.Baslik,
                Ucret = x.Ucret,
                AcikAlan = x.AcikAlan,
                KapaliAlan = x.KapaliAlan,
                IsletmeAlani = x.IsletmeAlani,
                OfisAlani = x.OfisAlani,
                KWAEnerji = x.KWAEnerji,
                VincVarmi = x.VincVarmi,
                VincAciklama = x.VincAciklama,
                Katsayisi = x.Katsayisi,
                M2TasimaKapasitesi = x.M2TasimaKapasitesi,
                GirisYuksekligi = x.GirisYuksekligi,
                YapimYili = x.YapimYili,
                KiraciVarmi = x.KiraciVarmi,
                IsitmaId = x.IsitmaId,
                IsitmaAdi = x.Isitma.IsitmaAdi,
                YapininDurumu = x.YapininDurumu,
                KullanimDurumu = x.KullanimDurumu,
                KrediyeUygunluk = x.KrediyeUygunluk,
                IsyeriTapuTipi = x.IsyeriTapuTipi,
                TasinmazNo = x.TasinmazNo,
                IlId = x.IlId,
                IlAdi = x.Il.IlAdi,
                IlceId = x.IlceId,
                IlceAdi = x.Ilce.IlceAdi,
                Mahalle = x.Mahalle,
                Ada = x.Ada,
                Parsel = x.Parsel,
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
                Zingat = x.Zingat,
                ZingatLink = x.ZingatLink,
                BuradaYapı = x.BuradaYapı,
                BuradaYapıLink = x.BuradaYapıLink,
                DepoFabrika = x.DepoFabrika,
                DepoFabrikaLink = x.DepoFabrikaLink,
                UyduGoruntusu = x.UyduGoruntusu,
                OznitelikGoruntusu = x.OznitelikGoruntusu,
                ImarDurumuGoruntusu = x.ImarDurumuGoruntusu,
                AutoCadDosyaAdi = x.AutoCadDosyaAdi,
                AutoCadDosyaYolu = x.AutoCadDosyaYolu,
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
        public override IEnumerable<BaseEntity> List(Expression<Func<Isyeri, bool>> filter)
        {
            return BaseList(filter, x => new IsyeriL
            {
                Id = x.Id,
                Kod = x.Kod,
                IsyeriTipiAdi = x.IsyeriTipi.IsyeriTipiAdi,
                PortfoyTuru = x.PortfoyTuru,
                ImarDurumu = x.ImarDurumu,
                Baslik = x.Baslik,
                Ucret = x.Ucret,
                AcikAlan = x.AcikAlan,
                KapaliAlan = x.KapaliAlan,
                IsletmeAlani = x.IsletmeAlani,
                OfisAlani = x.OfisAlani,
                KWAEnerji = x.KWAEnerji,
                VincVarmi = x.VincVarmi,
                VincAciklama = x.VincAciklama,
                Katsayisi = x.Katsayisi,
                M2TasimaKapasitesi = x.M2TasimaKapasitesi,
                GirisYuksekligi = x.GirisYuksekligi,
                YapimYili = x.YapimYili,
                KiraciVarmi = x.KiraciVarmi,
                IsitmaAdi = x.Isitma.IsitmaAdi,
                YapininDurumu = x.YapininDurumu,
                KullanimDurumu = x.KullanimDurumu,
                KrediyeUygunluk = x.KrediyeUygunluk,
                IsyeriTapuTipi = x.IsyeriTapuTipi,
                TasinmazNo = x.TasinmazNo,
                IlAdi = x.Il.IlAdi,
                IlceAdi = x.Ilce.IlceAdi,
                Mahalle = x.Mahalle,
                Ada = x.Ada,
                Parsel = x.Parsel,
                Aciklama = x.Aciklama,
                DanismanAdi = x.Danisman.Ad,
                MusteriAdi = x.Musteri.Ad,
                IlanVarmi = x.IlanVarmi,
                Sahibinden = x.Sahibinden,
                SahibindenLink = x.SahibindenLink,
                HepsiEmlak = x.HepsiEmlak,
                HepsiEmlakLink = x.HepsiEmlakLink,
                Zingat = x.Zingat,
                ZingatLink = x.ZingatLink,
                BuradaYapı = x.BuradaYapı,
                BuradaYapıLink = x.BuradaYapıLink,
                DepoFabrika = x.DepoFabrika,
                DepoFabrikaLink = x.DepoFabrikaLink,
                UyduGoruntusu = x.UyduGoruntusu,
                OznitelikGoruntusu = x.OznitelikGoruntusu,
                ImarDurumuGoruntusu = x.ImarDurumuGoruntusu,
                AutoCadDosyaAdi = x.AutoCadDosyaAdi,
                AutoCadDosyaYolu = x.AutoCadDosyaYolu,
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

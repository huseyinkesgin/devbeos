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
    public class MusteriBll : BaseGenelBll<Musteri>, IBaseGenelBll, IBaseCommonBll
    {
        public MusteriBll() : base(KartTuru.Musteri) { }

        public MusteriBll(Control ctrl) : base(ctrl, KartTuru.Musteri) { }

        public override BaseEntity Single(Expression<Func<Musteri, bool>> filter)
        {
            return BaseSingle(filter, x => new MusteriS
            {
                Id = x.Id,
                Kod = x.Kod,
                MusteriTuru = x.MusteriTuru,
                KategoriId = x.KategoriId,
                KategoriAdi = x.Kategori.KategoriAdi,
                Ad = x.Ad,
                Soyad = x.Soyad,
                TcKimlikNo = x.TcKimlikNo,
                Eposta = x.Eposta,
                Telefon = x.Telefon,
                IlId = x.IlId,
                IlAdi = x.Il.IlAdi,
                IlceId = x.IlceId,
                IlceAdi = x.Ilce.IlceAdi,
                MahalleId = x.MahalleId,
                MahalleAdi = x.Mahalle.MahalleAdi,
                Adres = x.Adres,
                Websitesi = x.Websitesi,
                Facebook = x.Facebook,
                Twitter = x.Twitter,
                Instagram = x.Instagram,
                Linkedin = x.Linkedin,
                Youtube = x.Youtube,
                Tiktok = x.Tiktok,
                VK = x.VK,
                FirmaId = x.FirmaId,
                FirmaAdi = x.Firma.FirmaAdi,
                Aciklama = x.Aciklama,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi =x.OzelKod1.OzelKodAdi,
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
        public override IEnumerable<BaseEntity> List(Expression<Func<Musteri, bool>> filter)
        {
            return BaseList(filter, x => new MusteriL
            {
                Id = x.Id,
                Kod = x.Kod,
                MusteriTuru = x.MusteriTuru,
                KategoriAdi = x.Kategori.KategoriAdi,
                Ad = x.Ad,
                Soyad = x.Soyad,
                TcKimlikNo = x.TcKimlikNo,
                Eposta = x.Eposta,
                Telefon = x.Telefon,
                IlAdi = x.Il.IlAdi,
                IlceAdi = x.Ilce.IlceAdi,
                MahalleAdi = x.Mahalle.MahalleAdi,
                Adres = x.Adres,
                Websitesi = x.Websitesi,
                Facebook = x.Facebook,
                Twitter = x.Twitter,
                Instagram = x.Instagram,
                Linkedin = x.Linkedin,
                Youtube = x.Youtube,
                Tiktok = x.Tiktok,
                VK = x.VK,
                FirmaAdi = x.Firma.FirmaAdi,
                Aciklama = x.Aciklama,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                OzelKod3Adi = x.OzelKod3.OzelKodAdi,
                OzelKod4Adi = x.OzelKod4.OzelKodAdi,
                OzelKod5Adi = x.OzelKod5.OzelKodAdi,
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}

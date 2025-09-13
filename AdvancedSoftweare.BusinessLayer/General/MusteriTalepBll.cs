using AdavancedSoftware.Model.Dto;
using AdavancedSoftware.Model.Entities;
using AdavancedSoftware.Model.Entities.Base;
using AdnavcedSoftware.Data.Contexts;
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
    public class MusteriTalepBll : BaseGenelBll<MusteriTalep>, IBaseGenelBll, IBaseCommonBll
    {
        public MusteriTalepBll() : base(KartTuru.MusteriTalep) { }

        public MusteriTalepBll(Control ctrl) : base(ctrl, KartTuru.MusteriTalep) { }

        public override BaseEntity Single(Expression<Func<MusteriTalep, bool>> filter)
        {
            return BaseSingle(filter, x => new MusteriTalepS
            {
                Id = x.Id,
                Kod = x.Kod,
                TalepBasligi = x.TalepBasligi,
                MusteriId = x.MusteriId,
                MusteriAdi = x.Musteri != null ? x.Musteri.Ad : "",
                MusteriSoyadi = x.Musteri != null ? x.Musteri.Soyad : "",
                MusteriTelefon = x.Musteri != null ? x.Musteri.Telefon : "",
                TalepTuru = x.TalepTuru,
                TalepDurumu = x.TalepDurumu,
                OncelikSeviyesi = x.OncelikSeviyesi,
                TalepTarihi = x.TalepTarihi,
                TalepEdilecekTarih = x.TalepEdilecekTarih,
                TamamlanmaTarihi = x.TamamlanmaTarihi,
                SorumluPersonelId = x.SorumluPersonelId,
                SorumluPersonelAdi = x.SorumluPersonel != null ? x.SorumluPersonel.Ad : "",
                IlId = x.IlId,
                IlAdi = x.Il != null ? x.Il.IlAdi : "",
                IlceId = x.IlceId,
                IlceAdi = x.Ilce != null ? x.Ilce.IlceAdi : "",
                MahalleId = x.MahalleId,
                MahalleAdi = x.Mahalle != null ? x.Mahalle.MahalleAdi : "",
                Adres = x.Adres,
                PortfoyId = x.PortfoyId,
                PortfoyNo = x.Portfoy != null ? x.Portfoy.PortfoyNo : "",
                HizmetId = x.HizmetId,
                HizmetAdi = x.Hizmet != null ? x.Hizmet.HizmetAdi : "",
                MinBütce = x.MinBütce,
                MaxBütce = x.MaxBütce,
                TeklifTutari = x.TeklifTutari,
                MinMetrekare = x.MinMetrekare,
                MaxMetrekare = x.MaxMetrekare,
                TalepDetayi = x.TalepDetayi,
                MusteriNotlari = x.MusteriNotlari,
                PersonelNotlari = x.PersonelNotlari,
                RedNedeni = x.RedNedeni,
                IptalNedeni = x.IptalNedeni,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1 != null ? x.OzelKod1.OzelKodAdi : "",
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2 != null ? x.OzelKod2.OzelKodAdi : "",
                OzelKod3Id = x.OzelKod3Id,
                OzelKod3Adi = x.OzelKod3 != null ? x.OzelKod3.OzelKodAdi : "",
                Durum = x.Durum
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<MusteriTalep, bool>> filter)
        {
            return BaseList(filter, x => new MusteriTalepL
            {
                Id = x.Id,
                Kod = x.Kod,
                TalepBasligi = x.TalepBasligi,
                MusteriAdi = x.Musteri != null ? (x.Musteri.Ad + " " + x.Musteri.Soyad) : "",
                MusteriTelefon = x.Musteri != null ? x.Musteri.Telefon : "",
                TalepTuru = x.TalepTuru.ToString(),
                TalepDurumu = x.TalepDurumu.ToString(),
                OncelikSeviyesi = x.OncelikSeviyesi.ToString(),
                TalepTarihi = x.TalepTarihi,
                TalepEdilecekTarih = x.TalepEdilecekTarih,
                TamamlanmaTarihi = x.TamamlanmaTarihi,
                SorumluPersonelAdi = x.SorumluPersonel != null ? x.SorumluPersonel.Ad : "",
                IlAdi = x.Il != null ? x.Il.IlAdi : "",
                IlceAdi = x.Ilce != null ? x.Ilce.IlceAdi : "",
                MahalleAdi = x.Mahalle != null ? x.Mahalle.MahalleAdi : "",
                MinBütce = x.MinBütce,
                MaxBütce = x.MaxBütce,
                TeklifTutari = x.TeklifTutari,
                TalepDetayi = x.TalepDetayi,
                MusteriNotlari = x.MusteriNotlari,
                PersonelNotlari = x.PersonelNotlari,
                Durum = x.Durum
            }).OrderBy(x => x.Kod).ToList();
        }

    }
}

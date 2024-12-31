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
    public class PersonelBll : BaseGenelBll<Personel>, IBaseGenelBll, IBaseCommonBll
    {
        public PersonelBll() : base(KartTuru.Personel) { }

        public PersonelBll(Control ctrl) : base(ctrl, KartTuru.Personel) { }

        public override BaseEntity Single(Expression<Func<Personel, bool>> filter)
        {
            return BaseSingle(filter, x => new PersonelS
            {
                Id = x.Id,
                Kod = x.Kod,
                Ad = x.Ad,
                Soyad = x.Soyad,
                TcKimlikNo = x.TcKimlikNo,
                Cinsiyet = x.Cinsiyet,
                DogumTarihi = x.DogumTarihi,
                DogumYeri = x.DogumYeri,
                BabaAdi = x.BabaAdi,
                AnneAdi = x.AnneAdi,
                MedeniDurum = x.MedeniDurum,
                CocukVarmi = x.CocukVarmi,
                CocukSayisi = x.CocukSayisi,
                KanGrubu = x.KanGrubu,
                Ehliyet = x.Ehliyet,
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
                DepartmanId = x.DepartmanId,
                DepartmanAdi = x.Departman.DepartmanAdi,
                UnvanId = x.UnvanId,
                UnvanAdi = x.Unvan.UnvanAdi,
                BankaId = x.BankaId,
                BankaAdi = x.Banka.BankaAdi,
                SubeId = x.SubeId,
                SubeAdi = x.Sube.SubeAdi,
                IBAN = x.IBAN,
                PersonelDurumu = x.PersonelDurumu,
                IseGirisTarihi = x.IseGirisTarihi,
                IstenCikisTarihi = x.IstenCikisTarihi,
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
        public override IEnumerable<BaseEntity> List(Expression<Func<Personel, bool>> filter)
        {
            return BaseList(filter, x => new PersonelL
            {
                Id = x.Id,
                Kod = x.Kod,
                Ad = x.Ad,
                Soyad = x.Soyad,
                TcKimlikNo = x.TcKimlikNo,
                Cinsiyet = x.Cinsiyet,
                DogumTarihi = x.DogumTarihi,
                DogumYeri = x.DogumYeri,
                BabaAdi = x.BabaAdi,
                AnneAdi = x.AnneAdi,
                MedeniDurum = x.MedeniDurum,
                CocukVarmi = x.CocukVarmi,
                CocukSayisi = x.CocukSayisi,
                KanGrubu = x.KanGrubu,
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
                DepartmanAdi = x.Departman.DepartmanAdi,
                UnvanAdi = x.Unvan.UnvanAdi,
                BankaAdi = x.Banka.BankaAdi,
                SubeAdi = x.Sube.SubeAdi,
                IBAN = x.IBAN,
                PersonelDurumu = x.PersonelDurumu,
                IseGirisTarihi = x.IseGirisTarihi,
                IstenCikisTarihi = x.IstenCikisTarihi,
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

using AdavancedSoftware.Model.Dto;
using AdavancedSoftware.Model.Entities;
using AdavancedSoftware.Model.Entities.Base;
using AdnavcedSoftware.Data.Contexts;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Linq;
using AdvancedSoftweare.BusinessLayer.Interfaces;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class KargoFirmasiBll : BaseBll<KargoFirmasi, DataContext>, IBaseGenelBll
    {
        public KargoFirmasiBll() { }

        public KargoFirmasiBll(Control ctrl) : base(ctrl) { }

        public BaseEntity Single(Expression<Func<KargoFirmasi, bool>> filter)
        {
            return BaseSingle(filter, x => new KargoFirmasiS
            {
                Id = x.Id,
                Kod = x.Kod,
                FirmaAdi = x.FirmaAdi,
                Telefon = x.Telefon,
                Eposta = x.Eposta,
                MusteriHizmetleri = x.MusteriHizmetleri,
                IlId = x.IlId,
                IlAdi = x.Il.IlAdi,
                IlceId = x.IlceId,
                IlceAdi = x.Ilce.IlceAdi,
                Adres = x.Adres,
                Durum = x.Durum,
            });
        }
        public IEnumerable<BaseEntity> List(Expression<Func<KargoFirmasi, bool>> filter)
        {
            return BaseList(filter, x => new KargoFirmasiL
            {
                Id = x.Id,
                Kod = x.Kod,
                FirmaAdi = x.FirmaAdi,
                Telefon = x.Telefon,
                Eposta = x.Eposta,
                MusteriHizmetleri = x.MusteriHizmetleri,
                IlAdi = x.Il.IlAdi,
                IlceAdi = x.Ilce.IlceAdi,
                Adres = x.Adres,
            }).OrderBy(x => x.Kod).ToList();
        }

        public bool Insert(BaseEntity entity) 
        { 
            return BaseInsert(entity, x => x.Kod ==  entity.Kod);
        }

        public bool Update(BaseEntity oldEntity, BaseEntity currentEntity)
        {
            return BaseUpdate(oldEntity, currentEntity, x => x.Kod == currentEntity.Kod);
        }

        public bool Delete(BaseEntity entity) 
        {
            return BaseDelete(entity, KartTuru.KargoFirmasi);
        }

        public string YeniKodVer()
        {
            return BaseYeniKodver(KartTuru.KargoFirmasi, x => x.Kod);
        }
    }
}

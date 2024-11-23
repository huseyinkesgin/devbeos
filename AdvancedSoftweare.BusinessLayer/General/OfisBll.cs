using AdavancedSoftware.Model.Dto;
using AdavancedSoftware.Model.Entities.Base;
using AdavancedSoftware.Model.Entities;
using AdnavcedSoftware.Data.Contexts;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class OfisBll : BaseBll<Ofis, DataContext>, IBaseGenelBll
    {
        public OfisBll() { }

        public OfisBll(Control ctrl) : base(ctrl) { }

        public BaseEntity Single(Expression<Func<Ofis, bool>> filter)
        {
            return BaseSingle(filter, x => new OfisS
            {
                Id = x.Id,
                Kod = x.Kod,
                OfisAdi = x.OfisAdi,
                Telefon = x.Telefon,
                Eposta = x.Eposta,
                IlId = x.IlId,
                IlAdi = x.Il.IlAdi,
                IlceId = x.IlceId,
                IlceAdi = x.Ilce.IlceAdi,
                Adres = x.Adres,
                Durum = x.Durum,
            });
        }
        public IEnumerable<BaseEntity> List(Expression<Func<Ofis, bool>> filter)
        {
            return BaseList(filter, x => new OfisL
            {
                Id = x.Id,
                Kod = x.Kod,
                OfisAdi = x.OfisAdi,
                Telefon = x.Telefon,
                Eposta = x.Eposta,
                IlAdi = x.Il.IlAdi,
                IlceAdi = x.Ilce.IlceAdi,
                Adres = x.Adres,
            }).OrderBy(x => x.Kod).ToList();
        }

        public bool Insert(BaseEntity entity)
        {
            return BaseInsert(entity, x => x.Kod == entity.Kod);
        }

        public bool Update(BaseEntity oldEntity, BaseEntity currentEntity)
        {
            return BaseUpdate(oldEntity, currentEntity, x => x.Kod == currentEntity.Kod);
        }

        public bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, KartTuru.Ofis);
        }

        public string YeniKodVer()
        {
            return BaseYeniKodver(KartTuru.Ofis, x => x.Kod);
        }
    }
}

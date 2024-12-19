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
    public class OfisBll : BaseGenelBll<Ofis>, IBaseGenelBll, IBaseCommonBll
    {
        public OfisBll(): base(KartTuru.Ofis) { }

        public OfisBll(Control ctrl) : base(ctrl, KartTuru.Ofis) { }


        public override BaseEntity Single(Expression<Func<Ofis, bool>> filter)
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

       
        public override IEnumerable<BaseEntity> List(Expression<Func<Ofis, bool>> filter)
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

      

       
    }
}

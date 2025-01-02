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
    public class YakitHarcamaBll : BaseGenelBll<YakitHarcama>, IBaseGenelBll, IBaseCommonBll
    {
        public YakitHarcamaBll(): base(KartTuru.YakitHarcama) { }

        public YakitHarcamaBll(Control ctrl) : base(ctrl, KartTuru.YakitHarcama) { }


        public override BaseEntity Single(Expression<Func<YakitHarcama, bool>> filter)
        {
            return BaseSingle(filter, x => new YakitHarcamaS
            {
                Id = x.Id,
                Kod = x.Kod,
                AracId = x.AracId,
                AracPlakaNo = x.AracPlakaNo.PlakaNo,
                PersonelId = x.PersonelId,
                PersonelAdi = x.Personel.Ad,
                OdemeMetoduId = x.OdemeMetoduId,
                OdemeMetoduAdi = x.OdemeMetodu.OdemeMetoduAdi,
                KasaId = x.KasaId,
                KasaAdi = x.Kasa.KasaAdi,
                Tarih = x.Tarih,
                Litre = x.Litre,
                YakitCinsi = x.YakitCinsi,
                Tutar = x.Tutar,
                BelgeNo = x.BelgeNo,
                Aciklama = x.Aciklama,
                Durum = x.Durum,
            });
           
        }

       
        public override IEnumerable<BaseEntity> List(Expression<Func<YakitHarcama, bool>> filter)
        {
            return BaseList(filter, x => new YakitHarcamaL
            {
                Id = x.Id,
                Kod = x.Kod,
                AracPlakaNo = x.AracPlakaNo.PlakaNo,
                PersonelAdi = x.Personel.Ad,
                OdemeMetoduAdi = x.OdemeMetodu.OdemeMetoduAdi,
                KasaAdi = x.Kasa.KasaAdi,
                Tarih = x.Tarih,
                Litre = x.Litre,
                YakitCinsi = x.YakitCinsi,
                Tutar = x.Tutar,
                BelgeNo = x.BelgeNo,
                Aciklama = x.Aciklama,


            }).OrderBy(x => x.Kod).ToList();
        }
     
    }
}

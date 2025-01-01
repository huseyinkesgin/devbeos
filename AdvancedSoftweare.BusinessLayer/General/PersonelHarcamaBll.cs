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
    public class PersonelHarcamaBll : BaseGenelBll<PersonelHarcama>, IBaseGenelBll, IBaseCommonBll
    {
        public PersonelHarcamaBll(): base(KartTuru.PersonelHarcama) { }

        public PersonelHarcamaBll(Control ctrl) : base(ctrl, KartTuru.PersonelHarcama) { }


        public override BaseEntity Single(Expression<Func<PersonelHarcama, bool>> filter)
        {
            return BaseSingle(filter, x => new PersonelHarcamaS
            {
                Id = x.Id,
                PersonelId = x.PersonelId,
                PersonelAdi = x.Personel.Ad,
                OdemeMetoduId = x.OdemeMetoduId,
                OdemeMetoduAdi = x.OdemeMetodu.OdemeMetoduAdi,
                KasaId = x.KasaId,
                KasaAdi = x.Kasa.KasaAdi,
                KategoriId = x.KategoriId,
                KategoriAdi = x.Kategori.KategoriAdi,
                Tarih = x.Tarih,
                Tutar = x.Tutar,
                BelgeTuru = x.BelgeTuru,
                BelgeNo = x.BelgeNo,
                Aciklama = x.Aciklama,
                Durum = x.Durum,

            });
           
        }

       
        public override IEnumerable<BaseEntity> List(Expression<Func<PersonelHarcama, bool>> filter)
        {
            return BaseList(filter, x => new PersonelHarcamaL
            {
                Id = x.Id,
                Kod =x.Kod,
                PersonelAdi = x.Personel.Ad,
                OdemeMetoduAdi = x.OdemeMetodu.OdemeMetoduAdi,
                KasaAdi = x.Kasa.KasaAdi,
                KategoriAdi = x.Kategori.KategoriAdi,
                Tarih = x.Tarih,
                Tutar = x.Tutar,
                BelgeTuru = x.BelgeTuru.ToString(),
                BelgeNo = x.BelgeNo,
                Aciklama = x.Aciklama,
            }).OrderBy(x => x.Kod).ToList();
           
        }
     
    }
}

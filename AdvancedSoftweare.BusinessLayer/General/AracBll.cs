using AdavancedSoftware.Model.Dto;
using AdavancedSoftware.Model.Entities.Base;
using AdavancedSoftware.Model.Entities;
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
    public class AracBll : BaseGenelBll<Arac>, IBaseGenelBll, IBaseCommonBll
    {
        public AracBll() : base(KartTuru.Arac) { }

        public AracBll(Control ctrl) : base(ctrl, KartTuru.Arac) { }

        public override BaseEntity Single(Expression<Func<Arac, bool>> filter)
        {
            return BaseSingle(filter, x => new AracS
            {
                Id = x.Id,
                Kod = x.Kod,
                PlakaNo = x.PlakaNo,
                MarkaId = x.MarkaId,
                MarkaAdi = x.Marka.MarkaAdi,
                ModelId = x.ModelId,
                ModelAdi = x.Model.ModelAdi,
                TescilTarihi = x.TescilTarihi,
                IlkTescilTarihi = x.IlkTescilTarihi,
                AracMotorNo = x.AracMotorNo,
                AracSasiNo = x.AracSasiNo,
                MotorGucu = x.MotorGucu,
                SilindirHacmi = x.SilindirHacmi,
                YakitCinsi = x.YakitCinsi,
                VitesTuru = x.VitesTuru,
                AracRenk = x.AracRenk,
                ModelYil = x.ModelYil,
                AracSinifId = x.AracSinifId,
                AracSinifAdi = x.AracSinif.AracSinifAdi,
                AracCinsi = x.AracCinsi,
                BelgeNo = x.BelgeNo,
                SeriNo = x.SeriNo,
                TescilSiraNo = x.TescilSiraNo,

                Aciklama = x.Aciklama,
                Durum = x.Durum,
            });
        }


        public override IEnumerable<BaseEntity> List(Expression<Func<Arac, bool>> filter)
        {
            return BaseList(filter, x => new AracL
            {
                Id = x.Id,
                Kod = x.Kod,
                PlakaNo = x.PlakaNo,
                MarkaAdi = x.Marka.MarkaAdi,
                ModelAdi = x.Model.ModelAdi,
                IlkTescilTarihi = x.IlkTescilTarihi,
                TescilTarihi = x.TescilTarihi,               
                AracMotorNo = x.AracMotorNo,
                AracSasiNo = x.AracSasiNo,
                MotorGucu = x.MotorGucu,
                SilindirHacmi = x.SilindirHacmi,
                YakitCinsi = x.YakitCinsi,
                VitesTuru = x.VitesTuru,
                AracRenk = x.AracRenk,
                ModelYil = x.ModelYil,
                AracSinifAdi = x.AracSinif.AracSinifAdi,
                AracCinsi = x.AracCinsi,
                BelgeNo = x.BelgeNo,
                SeriNo = x.SeriNo,
                TescilSiraNo = x.TescilSiraNo,
                Aciklama = x.Aciklama,
            }).OrderBy(x => x.Kod).ToList();
        }

    }
}

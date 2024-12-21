using AdavancedSoftware.Model.Dto;
using AdavancedSoftware.Model.Entities;
using AdavancedSoftware.Model.Entities.Base;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using System.Windows.Forms;
using System.Linq;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class BankaSubeBll : BaseGenelBll<BankaSube>, IBaseGenelBll, IBaseCommonBll
    {
        public BankaSubeBll():base(KartTuru.BankaSube) { }

        public BankaSubeBll(Control ctrl) : base(ctrl, KartTuru.BankaSube) { }

        public override BaseEntity Single(Expression<Func<BankaSube, bool>> filter)
        {
            return BaseSingle(filter, x => new BankaSubeS
            {
                Id = x.Id,
                Kod = x.Kod,
                SubeAdi = x.SubeAdi,
                BankaId = x.BankaId,
                BankaAdi = x.Banka.BankaAdi,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama,
                Durum = x.Durum,
            });
        }


        public override IEnumerable<BaseEntity> List(Expression<Func<BankaSube, bool>> filter)
        {
            return BaseList(filter, x => new BankaSubeL
            {
                Id = x.Id,
                Kod = x.Kod,
                SubeAdi = x.SubeAdi,
                BankaAdi =x.Banka.BankaAdi,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama,
            }).OrderBy(x => x.Kod).ToList();
        }

    }
}

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
    public class PortfoyBll : BaseGenelBll<Portfoy>, IBaseGenelBll, IBaseCommonBll
    {
        public PortfoyBll() : base(KartTuru.Portfoy) { }

        public PortfoyBll(Control ctrl) : base(ctrl, KartTuru.Portfoy) { }

        public override BaseEntity Single(Expression<Func<Portfoy, bool>> filter)
        {
            return BaseSingle(filter, x => new PortfoyS
            {
                Id = x.Id,
                Kod = x.Kod,
                PortfoyNo = x.PortfoyNo,
                PortfoyTipiId = x.PortfoyTipiId,
                PortfoyTipiAdi = x.PortfoyTipi.PortfoyTipiAdi,
                PortfoyTuru = x.PortfoyTuru,
                IlId = x.IlId,
                IlAdi = x.Il.IlAdi,
                IlceId = x.IlceId,
                IlceAdi = x.Ilce.IlceAdi,
                MahalleId = x.MahalleId,
                MahalleAdi = x.Mahalle.MahalleAdi,
                ImarDurumu = x.ImarDurumu,              
                Ucret = x.Ucret,
                M2 = x.M2,
                Ada = x.Ada,
                Parsel = x.Parsel,
                DanismanId = x.DanismanId,
                DanismanAdi = x.Danisman.Ad,
                MusteriId = x.MusteriId,
                MusteriAdi = x.Musteri.Ad,
                PortfoyDurumu = x.PortfoyDurumu,
                YetkiliOfis = x.YetkiliOfis,
                KayitTarihi = x.KayitTarihi,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
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
        public override IEnumerable<BaseEntity> List(Expression<Func<Portfoy, bool>> filter)
        {
            return BaseList(filter, x => new PortfoyL
            {
                Id = x.Id,
                Kod = x.Kod,
                PortfoyNo = x.PortfoyNo,
                PortfoyTipiAdi = x.PortfoyTipi.PortfoyTipiAdi,
                PortfoyTuru = x.PortfoyTuru,
                IlAdi = x.Il.IlAdi,
                IlceAdi = x.Ilce.IlceAdi,
                MahalleAdi = x.Mahalle.MahalleAdi,
                ImarDurumu = x.ImarDurumu,
                Ucret = x.Ucret,
                M2 = x.M2,
                Ada = x.Ada,
                Parsel = x.Parsel,
                DanismanAdi = x.Danisman.Ad,
                MusteriAdi = x.Musteri.Ad,
                PortfoyDurumu = x.PortfoyDurumu,
                YetkiliOfis = x.YetkiliOfis,
                KayitTarihi = x.KayitTarihi,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                OzelKod3Adi = x.OzelKod3.OzelKodAdi,
                OzelKod4Adi = x.OzelKod4.OzelKodAdi,

                OzelKod5Adi = x.OzelKod5.OzelKodAdi,
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}

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
    public class FirmaBll : BaseGenelBll<Firma>, IBaseGenelBll, IBaseCommonBll
    {
        public FirmaBll(): base(KartTuru.Firma) { }

        public FirmaBll(Control ctrl) : base(ctrl, KartTuru.Firma) { }


        public override BaseEntity Single(Expression<Func<Firma, bool>> filter)
        {
            return BaseSingle(filter, x => new FirmaS
            {
                Id = x.Id,
                Kod = x.Kod,
                FirmaAdi = x.FirmaAdi,
                FaturaAdi = x.FaturaAdi,
                VergiDairesi = x.VergiDairesi,
                VergiNo = x.VergiNo,
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

       
        public override IEnumerable<BaseEntity> List(Expression<Func<Firma, bool>> filter)
        {
            return BaseList(filter, x => new FirmaL
            {
                Id = x.Id,
                Kod = x.Kod,
                FirmaAdi = x.FirmaAdi,
                FaturaAdi = x.FaturaAdi,
                VergiDairesi = x.VergiDairesi,
                VergiNo = x.VergiNo,
                MersisNo = x.MersisNo,
                KepAdresi = x.KepAdresi,
                Telefon = x.Telefon,
                Eposta = x.Eposta,
                IlAdi = x.Il.IlAdi,
                IlceAdi = x.Ilce.IlceAdi,
                Adres = x.Adres,
                Websitesi = x.Websitesi,
                Facebook = x.Facebook,
                Twitter = x.Twitter,
                Instagram = x.Instagram,
                Linkedin = x.Linkedin,
                VK = x.VK,
                Youtube = x.Youtube,
                Tiktok = x.Tiktok,
            }).OrderBy(x => x.Kod).ToList();
        }
     
    }
}

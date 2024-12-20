using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using System.Windows.Forms;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class MusteriGrupBll : BaseGenelBll<MusteriGrup>, IBaseGenelBll, IBaseCommonBll
    {
        public MusteriGrupBll():base(KartTuru.MusteriGrup) { }

        public MusteriGrupBll(Control ctrl) : base(ctrl, KartTuru.MusteriGrup) { }

      
    }
}

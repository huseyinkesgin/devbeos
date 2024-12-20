using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using System.Windows.Forms;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class UnvanBll : BaseGenelBll<Unvan>, IBaseGenelBll, IBaseCommonBll
    {
        public UnvanBll():base(KartTuru.Unvan) { }

        public UnvanBll(Control ctrl) : base(ctrl, KartTuru.Unvan) { }

      
    }
}

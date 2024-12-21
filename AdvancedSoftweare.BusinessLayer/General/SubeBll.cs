using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using System.Windows.Forms;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class SubeBll : BaseGenelBll<Sube>, IBaseGenelBll, IBaseCommonBll
    {
        public SubeBll():base(KartTuru.Sube) { }

        public SubeBll(Control ctrl) : base(ctrl, KartTuru.Sube) { }

      
    }
}

using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using System.Windows.Forms;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class MarkaBll : BaseGenelBll<Marka>, IBaseGenelBll, IBaseCommonBll
    {
        public MarkaBll():base(KartTuru.Marka) { }

        public MarkaBll(Control ctrl) : base(ctrl, KartTuru.Marka) { }

      
    }
}

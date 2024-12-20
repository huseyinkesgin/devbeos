using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using System.Windows.Forms;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class IsitmaBll : BaseGenelBll<Isitma>, IBaseGenelBll, IBaseCommonBll
    {
        public IsitmaBll():base(KartTuru.Isitma) { }

        public IsitmaBll(Control ctrl) : base(ctrl, KartTuru.Isitma) { }

      
    }
}

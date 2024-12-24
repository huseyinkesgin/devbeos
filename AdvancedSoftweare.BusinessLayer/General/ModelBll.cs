using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using System.Windows.Forms;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class ModelBll : BaseGenelBll<Model>, IBaseCommonBll
    {
        public ModelBll():base(KartTuru.Model) { }

        public ModelBll(Control ctrl) : base(ctrl, KartTuru.Model) { }
      
    }
}

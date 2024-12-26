using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using System.Windows.Forms;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class KategoriBll : BaseGenelBll<Kategori>, IBaseGenelBll, IBaseCommonBll
    {
        public KategoriBll():base(KartTuru.Kategori) { }

        public KategoriBll(Control ctrl) : base(ctrl, KartTuru.Kategori) { }

      
    }
}

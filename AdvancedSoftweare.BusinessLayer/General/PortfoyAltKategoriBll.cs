using AdavancedSoftware.Model.Entities.Base;
using AdavancedSoftware.Model.Entities;
using AdnavcedSoftware.Data.Contexts;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvancedSoftweare.BusinessLayer.Interfaces;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class PortfoyAltKategoriBll : BaseBll<PortfoyAltKategori, DataContext>,IBaseCommonBll
    {
        public PortfoyAltKategoriBll() { }

        public PortfoyAltKategoriBll(Control ctrl) : base(ctrl) { }

        public BaseEntity Single(Expression<Func<PortfoyAltKategori, bool>> filter)
        {
            return BaseSingle(filter, x => x);

        }
        public IEnumerable<BaseEntity> List(Expression<Func<PortfoyAltKategori, bool>> filter)
        {
            return BaseList(filter, x => x).OrderBy(x => x.Kod).ToList();
        }

        public bool Insert(BaseEntity entity, Expression<Func<PortfoyAltKategori, bool>> filter)
        {
            return BaseInsert(entity, filter);
        }

        public bool Update(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<PortfoyAltKategori, bool>> filter)
        {
            return BaseUpdate(oldEntity, currentEntity, filter);
        }

        public bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, KartTuru.PortfoyAltKategori);
        }

        public string YeniKodVer(Expression<Func<PortfoyAltKategori, bool>> filter)
        {
            return BaseYeniKodver(KartTuru.PortfoyAltKategori, x => x.Kod, filter);
        }
    }
}

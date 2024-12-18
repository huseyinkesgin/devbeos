using AdavancedSoftware.Model.Entities;
using AdavancedSoftware.Model.Entities.Base;
using AdnavcedSoftware.Data.Contexts;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class FiltreBll : BaseBll<Filtre, DataContext>, IBaseCommonBll
    {
        public FiltreBll() { }

        public FiltreBll(Control ctrl) : base(ctrl) { }

        public BaseEntity Single(Expression<Func<Filtre, bool>> filter)
        {
            return BaseSingle(filter, x => x);

        }
        public IEnumerable<BaseEntity> List(Expression<Func<Filtre, bool>> filter)
        {
            return BaseList(filter, x => x).OrderBy(x => x.Kod).ToList();
        }

        public bool Insert(BaseEntity entity, Expression<Func<Filtre, bool>> filter)
        {
            return BaseInsert(entity, filter);
        }

        public bool Update(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<Filtre, bool>> filter)
        {
            return BaseUpdate(oldEntity, currentEntity, filter);
        }

        public bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, KartTuru.Filtre);
        }

        public string YeniKodVer(Expression<Func<Filtre, bool>> filter)
        {
            return BaseYeniKodver(KartTuru.Filtre, x => x.Kod, filter);
        }
    }
}

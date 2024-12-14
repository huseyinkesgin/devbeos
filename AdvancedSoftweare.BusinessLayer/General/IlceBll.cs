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
using System.Windows.Forms;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class IlceBll : BaseBll<Ilce, DataContext>
    {
        public IlceBll() { }

        public IlceBll(Control ctrl) : base(ctrl) { }

        public BaseEntity Single(Expression<Func<Ilce, bool>> filter)
        {
            return BaseSingle(filter, x => x);
           
        }
        public IEnumerable<BaseEntity> List(Expression<Func<Ilce, bool>> filter)
        {
            return BaseList(filter, x => x).OrderBy(x => x.Kod).ToList();
        }

        public bool Insert(BaseEntity entity, Expression<Func<Ilce, bool>> filter)
        {
            return BaseInsert(entity, filter);
        }

        public bool Update(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<Ilce, bool>> filter)
        {
            return BaseUpdate(oldEntity, currentEntity, filter);
        }

        public bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, KartTuru.Ilce);
        }

        public string YeniKodVer(Expression<Func<Ilce, bool>> filter)
        {
            return BaseYeniKodver(KartTuru.Ilce, x => x.Kod, filter);
        }

      
    }
}

using AdavancedSoftware.Model.Entities.Base;

namespace AdvancedSoftweare.BusinessLayer.Interfaces
{
    public interface IBaseGenelBll
    {
        bool Insert(BaseEntity entity);
        bool Update(BaseEntity oldEntity, BaseEntity currentEntity);
        string YeniKodVer();
    }
}

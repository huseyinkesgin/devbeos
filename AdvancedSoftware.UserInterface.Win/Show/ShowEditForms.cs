using AdavancedSoftware.Model.Entities.Base.Interfaces;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Show.Interfaces;
using System;

namespace AdvancedSoftware.UserInterface.Win.Show
{
    public class ShowEditForms<TForm>: IBaseFormShow where TForm:BaseEditForm 
    {
        public long ShowDialogEditForm(KartTuru kartTuru, long id)//, params object[] prm)
        {
            // Yetki Konttrolü

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
                frm.BaseIslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                frm.Id = id;
                frm.Yukle();
                frm.ShowDialog();
                return frm.RefreshYapilacak ? frm.Id : 0;
            }
        }

        public static long ShowDialogEditForm(KartTuru kartTuru, long id, params object[] prm)
        {
            // Yetki Konttrolü

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.BaseIslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                frm.Id = id;
                frm.Yukle();
                frm.ShowDialog();
                return frm.RefreshYapilacak ? frm.Id : 0;
            }
        }

        public static T ShowDialogEditForm<T>(params object[] prm) where T : IBaseEntity
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.Yukle();
                frm.ShowDialog();
                return (T)frm.ReturnEntity();
            }
        }
    }
}

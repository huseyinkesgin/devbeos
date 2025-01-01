using AdavancedSoftware.Model.Dto;
using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.AracSinifForms;
using AdvancedSoftware.UserInterface.Win.Forms.BankaForms;
using AdvancedSoftware.UserInterface.Win.Forms.BankaSubeForms;
using AdvancedSoftware.UserInterface.Win.Forms.DepartmanForms;
using AdvancedSoftware.UserInterface.Win.Forms.FirmaForms;
using AdvancedSoftware.UserInterface.Win.Forms.IsıtmaForms;
using AdvancedSoftware.UserInterface.Win.Forms.KasaForms;
using AdvancedSoftware.UserInterface.Win.Forms.MahalleForms;
using AdvancedSoftware.UserInterface.Win.Forms.MarkaForms;
using AdvancedSoftware.UserInterface.Win.Forms.ModelForms;
using AdvancedSoftware.UserInterface.Win.Forms.MusteriForms;
using AdvancedSoftware.UserInterface.Win.Forms.MusteriGrupForms;
using AdvancedSoftware.UserInterface.Win.Forms.OdemeTuru;
using AdvancedSoftware.UserInterface.Win.Forms.OzelKod;
using AdvancedSoftware.UserInterface.Win.Forms.PersonelForms;
using AdvancedSoftware.UserInterface.Win.Forms.PortfoyTipiForms;
using AdvancedSoftware.UserInterface.Win.Forms.SiparisForms.IlceForms;
using AdvancedSoftware.UserInterface.Win.Forms.SiparisForms.IlForms;
using AdvancedSoftware.UserInterface.Win.Forms.TapuTipiForms;
using AdvancedSoftware.UserInterface.Win.Forms.UnvanForms;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftware.UserInterface.Win.UserControls.Controls;
using System;

namespace AdvancedSoftware.UserInterface.Win.Functions
{
    public class SelectFunctions : IDisposable
    {
        #region Değişkenler
        
        private MyButtonEdit _btnEdit;
        private MyButtonEdit _prmEdit;
        private KartTuru _kartTuru; 

        #endregion

        public void Sec(MyButtonEdit btnEdit)
        {
            _btnEdit = btnEdit;
            SecimYap();
        }

        public void Sec(MyButtonEdit btnEdit,KartTuru kartTuru)
        {
            _btnEdit = btnEdit;
            _kartTuru = kartTuru;
            SecimYap();
        }

        public void Sec(MyButtonEdit btnEdit, MyButtonEdit prmEdit)   
        {
            _btnEdit = btnEdit;
            _prmEdit = prmEdit;
            SecimYap();
        }

        private void SecimYap()
        {
            switch (_btnEdit.Name)
            {
                case "txtDogumYeri":
                case "txtIl":
                    {
                        var entity = (Il)ShowListForms<IlListForm>.ShowDialogListForm(KartTuru.Il, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IlAdi;
                        }
                    }
                    break;

                case "txtIlce":
                    {
                        var entity = (Ilce)ShowListForms<IlceListForm>.ShowDialogListForm(KartTuru.Ilce, _btnEdit.Id, _prmEdit.Id, _prmEdit.Text);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IlceAdi;
                        }
                    }
                    break;
                case "txtMahalle":
                    {
                        var entity = (Mahalle)ShowListForms<MahalleListForm>.ShowDialogListForm(KartTuru.Mahalle, _btnEdit.Id, _prmEdit.Id, _prmEdit.Text);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.MahalleAdi;
                        }
                    }
                    break;

                case "txtPortfoyTipiAdi":
                    {
                        var entity = (PortfoyTipi)ShowListForms<PortfoyTipiListForm>.ShowDialogListForm(KartTuru.PortfoyTipi, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.PortfoyTipiAdi;
                        }
                    }
                    break;

                case "txtIsyeriTipi":
                    {
                        var entity = (IsyeriTipi)ShowListForms<IsyeriTipiListForm>.ShowDialogListForm(KartTuru.IsyeriTipi, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IsyeriTipiAdi;
                        }
                    }
                    break;

            
                case "txtOzelKod1":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod, _btnEdit.Id,OzelKodTuru.OzelKod1,_kartTuru);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;

                case "txtOzelKod2":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod, _btnEdit.Id, OzelKodTuru.OzelKod2, _kartTuru);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;

                case "txtOzelKod3":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod, _btnEdit.Id, OzelKodTuru.OzelKod3, _kartTuru);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;
                case "txtOzelKod4":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod, _btnEdit.Id, OzelKodTuru.OzelKod4, _kartTuru);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;
                case "txtOzelKod5":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod, _btnEdit.Id, OzelKodTuru.OzelKod5, _kartTuru);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;

                case "txtBanka":
                    {
                        var entity = (BankaL)ShowListForms<BankaListForm>.ShowDialogListForm(KartTuru.Banka, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.BankaAdi;
                        }
                    }
                    break;

                case "txtBankaSube":
                    {
                        var entity = (BankaSubeL)ShowListForms<BankaSubeListForm>.ShowDialogListForm(KartTuru.BankaSube, _btnEdit.Id, _prmEdit.Id, _prmEdit.Text);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.SubeAdi;
                        }
                    }
                    break;

                case "txtFirma":
                    {
                        var entity = (FirmaL)ShowListForms<FirmaListForm>.ShowDialogListForm(KartTuru.Firma, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.FirmaAdi;
                        }
                    }
                    break;

                case "txtKategori":
                    {
                        var entity = (Kategori)ShowListForms<KategoriListForm>.ShowDialogListForm(KartTuru.Kategori, _btnEdit.Id, KategoriTuru.Kategori, _kartTuru);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.KategoriAdi;
                        }
                    }
                    break;

                case "txtDepartman":
                    {
                        var entity = (Departman)ShowListForms<DepartmanListForm>.ShowDialogListForm(KartTuru.Departman, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.DepartmanAdi;
                        }
                    }
                    break;

                case "txtUnvan":
                    {
                        var entity = (Unvan)ShowListForms<UnvanListForm>.ShowDialogListForm(KartTuru.Unvan, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.UnvanAdi;
                        }
                    }
                    break;
                case "txtPersonel":
                case "txtDanisman":
                    {
                        var entity = (PersonelL)ShowListForms<PersonelListForm>.ShowDialogListForm(KartTuru.Personel, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.Ad;
                        }
                    }
                    break;

                case "txtMusteri":
                    {
                        var entity = (MusteriL)ShowListForms<MusteriListForm>.ShowDialogListForm(KartTuru.Musteri, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.Ad;
                        }
                    }
                    break;

                case "txtIsitma":
                    {
                        var entity = (Isitma)ShowListForms<IsitmaListForm>.ShowDialogListForm(KartTuru.Isitma, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IsitmaAdi;
                        }
                    }
                    break;

                case "txtAracSinif":
                    {
                        var entity = (AracSinif)ShowListForms<AracSinifListForm>.ShowDialogListForm(KartTuru.AracSinif, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.AracSinifAdi;
                        }
                    }
                    break;
                case "txtMarka":
                    {
                        var entity = (Marka)ShowListForms<MarkaListForm>.ShowDialogListForm(KartTuru.Marka, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.MarkaAdi;
                        }
                    }
                    break;
                case "txtModel":
                    {
                        var entity = (Model)ShowListForms<ModelListForm>.ShowDialogListForm(KartTuru.Model, _btnEdit.Id, _prmEdit.Id, _prmEdit.Text);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.ModelAdi;
                        }
                    }
                    break;
                case "txtKasa":
                    {
                        var entity = (KasaL)ShowListForms<KasaListForm>.ShowDialogListForm(KartTuru.Kasa, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.KasaAdi;
                        }
                    }
                    break;

                case "txtOdemeMetodu":
                    {
                        var entity = (OdemeMetodu)ShowListForms<OdemeMetoduList>.ShowDialogListForm(KartTuru.OdemeMetodu, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OdemeMetoduAdi;
                        }
                    }
                    break;



            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

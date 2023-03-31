﻿using AdvancedSoftware.Common.Enums;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace AdvancedSoftware.Common.Messages
{
    public class Messages
    {
        public static void HataMesaji(string hataMesaji)
        {
            XtraMessageBox.Show(hataMesaji, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void UyariMesaji(string uyariMesaji)
        {
            XtraMessageBox.Show(uyariMesaji, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult EvetSeciliEvetHayir(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj,baslik,MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
        }

        public static DialogResult HayirSeciliEvetHayir(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }
        public static DialogResult EvetSeciliEvetHayirIptal(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult SilMesaji(string kartAdi)
        {
            return HayirSeciliEvetHayir($"Seçtiğiniz {kartAdi} silinecektir.Onaylıyor musunuz?", "Silme Onayı");
        }

        public static DialogResult KapanisMesaj()
        {
            return EvetSeciliEvetHayirIptal("Yapılan değişiklikler kayıt edilsin mi?","Çıkış Onay");
        }

        public static DialogResult KayitMesaj()
        {
            return EvetSeciliEvetHayir("Yapılan değişiklikler kayıt edilsin mi?", "Kayıt Onay");
        }

        public static void KartSecmemeUyariMesaji()
        {
            UyariMesaji("Lütfen bir kayıt seçiniz");
        }
    }
}

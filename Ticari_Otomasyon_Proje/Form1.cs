using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticari_Otomasyon_Proje.Formlar;

namespace Ticari_Otomasyon_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void BtnUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUrunler frm = new FrmUrunler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnbarkod_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBarkod frm = new FrmBarkod();
          
            frm.Show();


        }

        private void btnKategoriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKategoriler frm = new FrmKategoriler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BrnUrunistatistikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Frmistatistikler frm = new Formlar.Frmistatistikler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnKategoriİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmKategoriİstatistik frm = new Formlar.FrmKategoriİstatistik();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmKategoriEkle fr = new Formlar.FrmKategoriEkle();
            fr.Show();
        }

        private void BtnYeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmUrunEkle fr = new Formlar.FrmUrunEkle();
            fr.Show();
        }

        private void BtnCariListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariListesi fr = new Formlar.FrmCariListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYeniCari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCariKart fr = new FrmCariKart();
            fr.Show();
        }

        private void BtnCariistatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariistatistik frm = new Formlar.FrmCariistatistik();
            frm.MdiParent= this;
            frm.Show();
        }

        private void BtnCariHareket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariHareket frm = new Formlar.FrmCariHareket();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmPersonel frm = new Formlar.FrmPersonel();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmDepartman frm = new Formlar.FrmDepartman();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmKasaListesi frm = new Formlar.FrmKasaListesi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnGider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGider frm = new Formlar.FrmGider();

            frm.Show();
        }

        private void BtnKurlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmKurlar frm = new Formlar.FrmKurlar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnDonusum_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Formlar.FrmDonusum frm = new Formlar.FrmDonusum();            
            frm.Show();
            

        }

        private void BtnAjanda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           FrmAjanda a = new FrmAjanda();
            
            a.Show();

        }

        private void BtnYeniNot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniNot frm = new Formlar.FrmYeniNot();
            
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
           
        }

        private void BtnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");

        }

        private void BtnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void BtnGauge_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {
            // Ribbon içerisinde gauge butonunun bulunduğu yerde, ilgili butonun visibility değerini false yapabilirsiniz.
            ribbonPageGroup1.ItemLinks.Remove(BtnGauge);  // gaugeButtonItem butonunun adıdır.
            
            ribbonPageGroup1.ItemLinks.Remove(btnajandda);
            ribbonPageGroup1.ItemLinks.Remove(barButtonItem1);
        }

        private void BtnYoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYoutube frm = new Formlar.FrmYoutube();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnYardim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            XtraMessageBox.Show("Kullandığınız otomasyonla ilgili her türlü arıza ve gördüğünüz eksiklikler için bize ticariotomasyon23@gmail.com mail adresi üzerinden ulaşabilirsiniz. " +
                "\nBunun yanı sıra 05078932333 numaralı hattı arayarak ya da WhatsApp üzerinden iletişime geçerek daha hızlı ulaşabilirsiniz. ", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information
                );


        }

        private void BtnHarita_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmHarita frm = new Formlar.FrmHarita();
            frm.MdiParent = this;
            frm.Show();
        }

        Formlar.FrmAnaForm frm1;
        private void BtnAna_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frm1 == null || frm1.IsDisposed)
            {
               frm1  =new Formlar.FrmAnaForm();
               frm1.MdiParent = this;
               frm1.Show();
            }
           
        }

        private void btnajandda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void BtnQR_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.FrmQr frmQr = new Formlar.FrmQr();
           
            frmQr.Show();
        }
    }
}

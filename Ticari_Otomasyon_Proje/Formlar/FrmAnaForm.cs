using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticari_Otomasyon_Proje.Entity;

namespace Ticari_Otomasyon_Proje.Formlar
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private async void FrmAnaForm_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.CoreWebView2.Navigate("https://www.tcmb.gov.tr/wps/wcm/connect/tr/tcmb+tr/main+page+site+area/bugun");

            var urun_stok = from x in db.TBLURUN
                            select new
                            {
                                x.URUNAD,
                                x.STOK
                            };
            gridControl1.DataSource = urun_stok.ToList();


            var son5satis = from x in db.TBLCARIHAREKET
                            select new
                            {
                                x.TBLURUN.URUNAD,
                                x.ADET,
                                x.TOPLAM,
                                x.SATISID
                            };
            gridControl2.DataSource= son5satis.OrderByDescending(x=>x.SATISID).Take(10).ToList();
            gridView2.Columns["SATISID"].Visible = false;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl3_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Today;
            var bugunyapilacaklar = (from x in db.TBLNOTLAR
                                     select new
                                     {
                                        x.BASLIK,
                                        x.SAAT,
                                        x.TARIH
                                     }).Where(x=>x.TARIH == bugun).ToList();
            gridControl3.DataSource = bugunyapilacaklar;
            gridView3.Columns["TARIH"].Visible=false;
        }

        private void gridControl4_Click(object sender, EventArgs e)
        {
            var personelbilgi = (from x in db.TBLCARI
                                 select new
                                 {
                                     x.AD,
                                     x.SOYAD,
                                     x.TELEFON
                                 }).ToList();
            gridControl4.DataSource = personelbilgi;
        }

        private void groupControl5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }
    }
}

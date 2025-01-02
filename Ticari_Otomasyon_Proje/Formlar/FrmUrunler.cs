using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
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

namespace Ticari_Otomasyon_Proje
{
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }
        DbTicariOtomasyonEntities db =new DbTicariOtomasyonEntities();
        void urunler()
        {
            gridControl1.DataSource = (from x in db.TBLURUN
                                       select new
                                       {
                                           x.URUNID,
                                           x.URUNAD,
                                           x.STOK,
                                           x.ALISFIYAT,
                                           x.SATISFIYAT,
                                           x.TBLKATEGORI.KATEGORİAD,
                                       }).ToList();
        }
        private void FrmUrunler_Load(object sender, EventArgs e)
        {          
            lookUpEdit1.Properties.DataSource = (from x in db.TBLKATEGORI
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.KATEGORİAD
                                                 }).ToList();



        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.URUNAD = TxtAd.Text;
            t.STOK = short.Parse(TxtStok.Text);
            t.ALISFIYAT = decimal.Parse(TxtAlisFiyat.Text);
            t.SATISFIYAT = decimal.Parse(TxtSatisFiyat.Text);
            t.KATEGORI = int.Parse(lookUpEdit1.EditValue.ToString());
            db.TBLURUN.Add(t);
            db.SaveChanges();

            XtraMessageBox.Show("Ürün ekleme işlemi başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            urunler();
            BtnListele_Click(sender, e);

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource= (from x in db.TBLURUN
                                      select new
                                      { 
                                          x.URUNID,
                                          x.URUNAD,
                                          x.STOK,
                                          x.ALISFIYAT,
                                          x.SATISFIYAT,
                                          x.TBLKATEGORI.KATEGORİAD,
                                      }).ToList();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (TxtID.Text != "")
            {
                int id = int.Parse(TxtID.Text);
                var x =db.TBLURUN.Find(id);
                db.TBLURUN.Remove(x);
                db.SaveChanges();
                XtraMessageBox.Show("Ürünü başarılı bi şekilde sildiniz.", "Silme işlemi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                XtraMessageBox.Show("Lütfen verileri listedikten sonra silmek istediğiniz kaydı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text= gridView1.GetFocusedRowCellValue("URUNID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("URUNAD").ToString();
            TxtAlisFiyat.Text = gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
            TxtSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
            TxtStok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("KATEGORİAD").ToString();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id =int.Parse(TxtID.Text);
            var x = db.TBLURUN.Find(id);
            x.URUNAD = TxtAd.Text;
            x.ALISFIYAT = decimal.Parse(TxtAlisFiyat.Text);
            x.SATISFIYAT = decimal.Parse(TxtSatisFiyat.Text);
            x.STOK = short.Parse(TxtStok.Text);
            x.KATEGORI = int.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();

            XtraMessageBox.Show("Verileriniz başarılı bir şekilde güncellendi.", "Güncellenm Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}

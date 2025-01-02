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
using Ticari_Otomasyon_Proje.Entity;

namespace Ticari_Otomasyon_Proje.Formlar
{
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }
       
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void BtnListele_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource= (from x in db.TBLCARI
                                      select new
                                      {
                                         x.CARIID,
                                         x.AD,
                                         x.SOYAD,
                                         x.IL,
                                         x.ILCE,
                                         x.ADRES,
                                         x.MAIL,
                                         x.TC,
                                         x.TELEFON,
                                         x.VERGIDAIRESI
                                      }).ToList();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TBLCARI t = new TBLCARI();
            t.AD = TxtAd.Text;
            t.SOYAD = TxtSoyad.Text;
            t.IL = lookUpEditIl.Text;
            t.ILCE = lookUpEditIlce.Text;
            t.TELEFON = TxtTelefon.Text;
            t.ADRES = TxtAdres.Text;
            t.MAIL = TxtMail.Text;
            t.TC = TxtTC.Text;
            t.VERGIDAIRESI = TxtVergiDairesi.Text;

            db.TBLCARI.Add(t);
            db.SaveChanges();

            XtraMessageBox.Show("Cari sisteme başarılı bir şekilde eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BtnListele_Click(sender, e);
        }

        private void TxtVergiDairesi_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            lookUpEditIl.Properties.DataSource= (from x in db.TBLILLER
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.SEHIR
                                                 }).ToList();


            
        }

        private void lookUpEditIlce_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void lookUpEditIl_EditValueChanged(object sender, EventArgs e)
        {
            int secilen;
            secilen = int.Parse(lookUpEditIl.EditValue.ToString());
            lookUpEditIlce.Properties.DataSource = (from y in db.TBLILCELER
                                                    select new
                                                    {
                                                        y.ID,
                                                        y.ILCE,
                                                        y.SEHIR
                                                    }).Where(z => z.SEHIR == secilen).ToList();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtCariID.Text = gridView1.GetFocusedRowCellValue("CARIID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            TxtSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
            TxtTC.Text = gridView1.GetFocusedRowCellValue("TC").ToString();
            TxtMail.Text = gridView1.GetFocusedRowCellValue("MAIL").ToString();
            TxtTelefon.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
            TxtAdres.Text = gridView1.GetFocusedRowCellValue("ADRES").ToString();
            TxtVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VERGIDAIRESI").ToString();
            lookUpEditIl.Text = gridView1.GetFocusedRowCellValue("IL").ToString();
            lookUpEditIlce.Text = gridView1.GetFocusedRowCellValue("ILCE").ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (TxtCariID.Text!= "" )
            {
                int id = int.Parse(TxtCariID.Text);
                var x = db.TBLCARI.Find(id);
                db.TBLCARI.Remove(x);
                db.SaveChanges();

                XtraMessageBox.Show("Cari başarılı bir şekilde silindi.", "Silme işlem", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                XtraMessageBox.Show("Lütfen verileri listeledikten sonra bir satıra tıklayıp silmek istediğiniz kaydı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            BtnListele_Click(sender, e);
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {

            
                // ID'nin geçerli olup olmadığını kontrol et
                int id = int.Parse(TxtCariID.Text); // ID'yi al
                var x = db.TBLCARI.Find(id); // Veritabanındaki kaydı bul

                if (x != null)
                {
                    // Eğer kayıt varsa, güncellemeyi yap
                    x.AD = TxtAd.Text;
                    x.SOYAD = TxtSoyad.Text;
                    x.TELEFON = TxtTelefon.Text;
                    x.ADRES = TxtAdres.Text;
                    x.MAIL = TxtMail.Text;
                    x.TC = TxtTC.Text;
                    x.IL = lookUpEditIl.Text; // Diğer kontrolleri de buraya ekleyin
                    x.ILCE = lookUpEditIlce.Text;
                    x.VERGIDAIRESI = TxtVergiDairesi.Text;

                    // Değişiklikleri kaydet
                    db.SaveChanges();

                    // Başarı mesajı göster
                    XtraMessageBox.Show("Verileriniz başarılı bir şekilde güncellendi.", "Güncelleme Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Eğer kayıt bulunamazsa hata mesajı göster
                    XtraMessageBox.Show("Bu ID'ye ait kayıt bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            BtnListele_Click(sender, e);
        }


    }
}

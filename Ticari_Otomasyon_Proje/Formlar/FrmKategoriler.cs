using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;
using Ticari_Otomasyon_Proje.Entity;

namespace Ticari_Otomasyon_Proje
{
    public partial class FrmKategoriler : Form
    {
        public FrmKategoriler()
        {
            InitializeComponent();
        }

        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();

        // Kategorileri listelemek
        private void BtnListele_Click(object sender, EventArgs e)
        {
            var kategoriler = from x in db.TBLKATEGORI
                              select new
                              {
                                  x.ID,
                                  x.KATEGORİAD
                              };
            gridControl1.DataSource = kategoriler.ToList();
        }

        // Kategori ekleme
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            // Kategori Adı alınıyor
            string kategoriAdi = textBox2.Text;

            if (!string.IsNullOrEmpty(kategoriAdi)) // Boş olmadığından emin olunuyor
            {
                TBLKATEGORI yeniKategori = new TBLKATEGORI
                {
                    KATEGORİAD = kategoriAdi
                };

                // ID alanını manuel olarak belirlemiyoruz, veritabanı otomatik arttıracak
                db.TBLKATEGORI.Add(yeniKategori);
                db.SaveChanges();

                XtraMessageBox.Show("Kategori ekleme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnListele_Click(sender, e);
            }
            else
            {
                XtraMessageBox.Show("Kategori adı boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Kategori silme
        private void BtnSil_Click(object sender, EventArgs e)
        {
            // ID'nin geçerli bir sayı olup olmadığını kontrol ediyoruz
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !int.TryParse(textBox1.Text, out int id))
            {
                XtraMessageBox.Show("Lütfen geçerli bir ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // Eğer ID geçerli değilse fonksiyon sonlanır
            }

            // Geçerli bir ID var, veritabanından silme işlemi yapılıyor
            var kategori = db.TBLKATEGORI.Find(id);
            if (kategori != null)
            {
                db.TBLKATEGORI.Remove(kategori);
                db.SaveChanges();
                XtraMessageBox.Show("Kategori başarıyla silindi.", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Bu ID'ye ait kategori bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Kategori güncelleme
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            // ID'nin geçerli bir sayı olup olmadığını kontrol ediyoruz
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !int.TryParse(textBox1.Text, out int id))
            {
                XtraMessageBox.Show("Lütfen geçerli bir ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // Eğer ID geçerli değilse fonksiyon sonlanır
            }

            var kategori = db.TBLKATEGORI.Find(id);
            if (kategori != null)
            {
                // Kategori adı güncelleniyor
                kategori.KATEGORİAD = textBox2.Text;
                db.SaveChanges();
                XtraMessageBox.Show("Veriler başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Bu ID'ye ait kategori bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

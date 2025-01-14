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
    public partial class FrmSifremiUnuttum : Form
    {
        public FrmSifremiUnuttum()
        {
            InitializeComponent();
        }

        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void FrmSifremiUnuttum_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Enter tuşuna basıldığında
            {
                btn_kaydet.PerformClick(); // Giriş Yap butonuna tıklanmış gibi çalıştır
            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Veritabanı bağlantısını açıyoruz
                var yonetici = db.TBLADMIN.FirstOrDefault(x => x.KULLANICIAD == txt_kullaniciadi.Text);

                if (yonetici != null)  // Kullanıcı adı veritabanında varsa
                {
                    // Şifre eşleşiyorsa
                    if (txt_yenisifre.Text == txt_sifre1.Text)
                    {
                        yonetici.SIFRE = txt_yenisifre.Text;  // Şifreyi güncelliyoruz
                        db.SaveChanges();  // Değişiklikleri kaydediyoruz

                        MessageBox.Show("Şifreniz başarıyla güncellendi.");
                        this.Hide();  // Bu formu gizliyoruz
                    }
                    else
                    {
                        MessageBox.Show("Girmiş olduğunuz şifreler farklı. Lütfen tekrar giriniz.");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                // TextBox'ları temizliyoruz
                txt_kullaniciadi.Text = "";
                txt_yenisifre.Clear();
                txt_sifre1.Text = "";
            }

            // Şifre değiştirme işleminden sonra yönlendirme
            Form anasayfa = new FrmLogin();  // AnaSayfaForm yerine uygun form ismini yazın
            anasayfa.Show();
            this.Hide();  // Bu formu gizliyoruz

        }
    }
}

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

namespace Ticari_Otomasyon_Proje.Formlar
{
    public partial class FrmBarkod : Form
    {
        public FrmBarkod()
        {
            InitializeComponent();
        }

        private void Bolustur_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textEdit1.Text))
            {
                try
                {
                    // Code128 barkod çizme işlemi
                    Zen.Barcode.Code128BarcodeDraw brkd = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                    pictureEdit1.Image = brkd.Draw(textEdit1.Text, 35); // barkodu çiz
                }
                catch (Exception ex)
                {
                    // Hata mesajını kullanıcıya göster
                    XtraMessageBox.Show("Barkod oluşturulurken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Eğer textEdit1 boşsa kullanıcıyı uyar
                XtraMessageBox.Show("Barkod için geçerli bir metin giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Bcozumle_Click(object sender, EventArgs e)
        {
            // OpenFileDialog oluşturuyoruz
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Dosya türünü belirliyoruz (resim dosyaları)
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            // Kullanıcının dosyayı seçmesini bekliyoruz
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Resmi yükleyip pictureEdit1'e atıyoruz
                pictureEdit1.Image = new Bitmap(openFileDialog.FileName);
            }
        }
    }
}

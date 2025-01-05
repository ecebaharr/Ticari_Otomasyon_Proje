using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace Ticari_Otomasyon_Proje.Formlar
{
    public partial class FrmQr : Form
    {
        public FrmQr()
        {
            InitializeComponent();
        }

        private void FrmQr_Load(object sender, EventArgs e)
        {
            
        }

        private void btnQRolustur_Click(object sender, EventArgs e)
        {
            QRCodeEncoder kod = new QRCodeEncoder();
            pictureEdit1.Image = kod.Encode(textEdit1.Text);
        }

        private void QRcozumle_Click(object sender, EventArgs e)
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

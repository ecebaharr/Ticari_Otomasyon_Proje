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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void textEditSifre_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        int hak = 3;
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBLADMIN where x.KULLANICIAD == textEditKullanici.Text& x.SIFRE==textEditSifre.Text select x;
            if (sorgu.Any()) 
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            
            else
            {
                hak--;
                XtraMessageBox.Show("Hatalı giriş yaptınız.Lütfen yeniden deneyiniz ve" + hak +" tane deneme hakkınızın olduğunu unutmayınız!");
                textEditKullanici.Clear();
                textEditSifre.Clear();
                if (hak == 0)
                {
                    XtraMessageBox.Show("Uygulamadan çıkışınınz yapılıyor.");
                    this.Close();
                }
            }


        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUnuttum_Click(object sender, EventArgs e)
        {
            Formlar.FrmSifremiUnuttum frm = new Formlar.FrmSifremiUnuttum();

            frm.Show();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Enter tuşuna basıldığında
            {
                BtnGiris.PerformClick(); // Giriş Yap butonuna tıklanmış gibi çalıştır
            }
        }
    }
}

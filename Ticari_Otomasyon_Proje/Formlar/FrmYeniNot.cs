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
    public partial class FrmYeniNot : Form
    {
        public FrmYeniNot()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
        DbTicariOtomasyonEntities db= new DbTicariOtomasyonEntities ();
        private void FrmYeniNot_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TBLNOTLAR t =new TBLNOTLAR();
            t.BASLIK = TxtBaslik.Text;
            t.TARIH = DateTime.Parse(dateEdit1.Text);
            t.SAAT = TimeSpan.Parse(timeSpanEdit1.Text);
            t.ICERIK = memoEdit1.Text;
            t.DURUM = checkEdit1.Checked;
            db.TBLNOTLAR.Add (t);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni notlar ajandaya başarıyla eklendi.", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();

        }

        private void Btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

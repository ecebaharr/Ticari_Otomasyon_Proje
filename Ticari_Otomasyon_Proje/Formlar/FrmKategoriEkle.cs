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
    public partial class FrmKategoriEkle : Form
    {
        public FrmKategoriEkle()
        {
            InitializeComponent();
        }

        private void FrmKategoriEkle_Load(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
            try 
            {
                 TBLKATEGORI t = new TBLKATEGORI();
                t.KATEGORİAD = TxtKategoriAd.Text;
                db.TBLKATEGORI.Add(t);
                db.SaveChanges();

                XtraMessageBox.Show("Kategori ekleme işlemi başarılı bir şekilde gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            } 
            catch (Exception)
            {
                XtraMessageBox.Show("Hatalı ekleme işlemi gerçekleştirdiniz. Lütfen kategori adını boş bırakmayınız ya da 20 karakterden fazla girmeyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

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
    public partial class FrmCariKart : Form
    {
        public FrmCariKart()
        {
            InitializeComponent();
        }

        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void FrmCariKart_Load(object sender, EventArgs e)
        {
            lookUpEditIl.Properties.DataSource = (from x in db.TBLILLER
                                                  select new
                                                  {
                                                      x.ID,
                                                      x.SEHIR
                                                  }).ToList();

        }
        

        private void lookUpEditIl_EditValueChanged_1(object sender, EventArgs e)
        {
            int secilen;
            secilen = int.Parse(lookUpEditIl.EditValue.ToString());
            lookUpEditIlce.Properties.DataSource = (from y in db.TBLILCELER
                                                    select new
                                                    {
                                                        y.ID,
                                                        y.ILCE,
                                                        y.SEHIR,
                                                    }).Where(z => z.SEHIR == secilen).ToList();
        }

        private void lookUpEditIlce_EditValueChanged(object sender, EventArgs e)
        {

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
            t.VERGIDAIRESI = TxtVergi.Text;
            db.TBLCARI.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Cari sisteme başarılı bir şekilde eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
       


 

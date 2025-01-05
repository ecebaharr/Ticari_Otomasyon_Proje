using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
    public partial class FrmGider : Form
    {
        public FrmGider()
        {
            InitializeComponent();
        }

        private void FrmGider_Load(object sender, EventArgs e)
        {
            
        }

        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            /* TBLGIDERLER t = new TBLGIDERLER();
             t.TUTAR = decimal.Parse(TxtTutar.Text); // Tutar alanı
             t.ACIKLAMA = memoEdit.Text;     // MemoEdit kullanılarak açıklama alanı
             t.TARIH = dateEdit1.DateTime;       // DateEdit kullanılarak tarih alanı
             db.TBLGIDERLER.Add(t);
             db.SaveChanges();

             TBLKASA t2 = new TBLKASA();
             t2.TUTAR = decimal.Parse(TxtTutar.Text); // Tutar alanı
             t2.TARİH = dateEdit1.DateTime;       // DateEdit kullanılarak tarih alanı
             t2.TUR = "Çıkış";                        // Tür alanı
             db.TBLKASA.Add(t2);
             db.SaveChanges();

             XtraMessageBox.Show("Gider sisteme başarılı bir şekilde eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
             */
           
                try
                {
                    // Tutar kontrolü
                    if (string.IsNullOrWhiteSpace(TxtTutar.Text))
                    {
                        XtraMessageBox.Show("Tutar alanı boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    decimal tutar;
                    if (!decimal.TryParse(TxtTutar.Text, out tutar))
                    {
                        XtraMessageBox.Show("Lütfen geçerli bir tutar giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Gider ekleme
                    TBLGIDERLER t = new TBLGIDERLER
                    {
                        TUTAR = tutar,
                        ACIKLAMA = memoEdit.Text,
                        TARIH = dateEdit1.DateTime
                    };
                    db.TBLGIDERLER.Add(t);
                    db.SaveChanges();

                    // Kasa ekleme
                    TBLKASA t2 = new TBLKASA
                    {
                        TUTAR = tutar,
                        TARİH = dateEdit1.DateTime,
                        TUR = "Çıkış"
                    };
                    db.TBLKASA.Add(t2);
                    db.SaveChanges();

                    XtraMessageBox.Show("Gider sisteme başarılı bir şekilde eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void Btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
    }
    

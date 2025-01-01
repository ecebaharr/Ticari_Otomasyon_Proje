using DevExpress.XtraCharts;
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
    public partial class FrmKategoriİstatistik : Form
    {
        public FrmKategoriİstatistik()
        {
            InitializeComponent();
        }

        private void FrmKategoriİstatistik_Load(object sender, EventArgs e)
        {
           
               DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
               gridControl1.DataSource = (from x in db.TBLKATEGORI
                                          select new
                                          {
                                              x.ID,
                                              x.KATEGORİAD,
                                          }).ToList();
            

                chartControl1.Series["Kategori"].Points.AddPoint("Beyaz Eşya", 25);
                chartControl1.Series["Kategori"].Points.AddPoint("Küçük Ev Aletleri", 14);
                chartControl1.Series["Kategori"].Points.AddPoint("Bilgisayar", 18);
            
        }
    }
}

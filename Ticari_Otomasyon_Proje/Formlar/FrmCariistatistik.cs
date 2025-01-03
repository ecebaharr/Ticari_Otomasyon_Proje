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
    public partial class FrmCariistatistik : Form
    {
        public FrmCariistatistik()
        {
            InitializeComponent();
        }

        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void FrmCariistatistik_Load(object sender, EventArgs e)
        {
            var degerler = db.TBLCARI
    .OrderBy(x => x.IL)
    .GroupBy(y => y.IL)
    .Select(z => new { IL = z.Key, TOPLAM = z.Count() }).ToList();

            // GridControl'e veri atama
            gridControl1.DataSource = degerler;

            // GridView'de kolon başlıklarını düzenleyebilirsiniz
            gridView1.Columns["IL"].Caption = "İl";
            gridView1.Columns["TOPLAM"].Caption = "Toplam";

            var iller = db.TBLCARI
                           .OrderBy(x => x.IL)
                           .GroupBy(y => y.IL)
                           .Select(z => new { IL = z.Key, TOPLAM = z.Count() }).ToList();

            foreach (var x in iller)
            {
                chartControl1.Series["İller"].Points.AddPoint(x.IL, short.Parse(x.TOPLAM.ToString()));
            }

        }
    }
}

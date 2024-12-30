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
    public partial class Frmistatistikler : Form
    {
        public Frmistatistikler()
        {
            InitializeComponent();
        }

        private void panelControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void Frmistatistikler_Load(object sender, EventArgs e)
        {
            LblUrunSayisi.Text=db.TBLURUN.Count().ToString();
            LblKategoriSayisi.Text=db.TBLKATEGORI.Count().ToString();
            LblMusteriSayisi.Text=db.TBLCARI.Count().ToString();
            LblPersonelSayisi.Text= db.TBLPERSONEL.Count().ToString();

            LblToplamStok.Text= db.TBLURUN.Sum(x=> x.STOK).ToString();

            LblBeyazEsya.Text= db.TBLURUN.Where(x=> x.KATEGORI==1).Sum(y=> y.STOK).ToString();
            LblKucukEvAleti.Text=db.TBLURUN.Where(x=>x.KATEGORI==4).Sum(y=> y.STOK).ToString();
            LblKritikSeviye.Text=db.TBLURUN.Count(x=>x.KRITIKSEVİYE==true).ToString();
            LblEnYuksekFiyatliurun.Text=db.TBLURUN.OrderByDescending(x=>x.SATISFIYAT).Select(y=>y.URUNAD).FirstOrDefault().ToString();
            LblEnDusukFiyatliurun.Text = db.TBLURUN.OrderBy(x => x.SATISFIYAT).Select(y => y.URUNAD).FirstOrDefault().ToString();
            LblEnCokStok.Text = db.TBLURUN.OrderByDescending(x => x.STOK).Select(y => y.URUNAD).FirstOrDefault().ToString();
            LblEnAzStok.Text = db.TBLURUN.OrderBy(x => x.STOK).Select(y => y.URUNAD).FirstOrDefault().ToString();


        }
    }
}

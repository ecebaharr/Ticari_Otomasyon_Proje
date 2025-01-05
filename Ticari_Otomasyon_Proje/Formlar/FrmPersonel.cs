using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticari_Otomasyon_Proje.Entity;

namespace Ticari_Otomasyon_Proje.Formlar
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {

            // "Sil" öğesini ekle
            ToolStripMenuItem silMenuItem = new ToolStripMenuItem("Sil");
            silMenuItem.Click += SilMenuItem_Click;

            // "İptal" öğesini ekle
            ToolStripMenuItem iptalMenuItem = new ToolStripMenuItem("İptal");
            iptalMenuItem.Click += IptalMenuItem_Click;

            // "Çıkış" öğesini ekle
            ToolStripMenuItem cikisMenuItem = new ToolStripMenuItem("Çıkış");
            cikisMenuItem.Click += CikisMenuItem_Click;

            // ContextMenuStrip'e öğeleri ekle
            contextMenuStrip1.Items.Add(silMenuItem);
            contextMenuStrip1.Items.Add(iptalMenuItem);
            contextMenuStrip1.Items.Add(cikisMenuItem);
            


            db.TBLPERSONEL.Load();
            bindingSource1.DataSource= db.TBLPERSONEL.Local;
            repositoryItemLookUpEdit1.DataSource= (from x in db.TBLDEPARTMAN
                                                   select new
                                                   {
                                                       x.ID,
                                                       x.DEPARTMANAD
                                                   }).ToList();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

     
        }
        // Sil menüsü için tıklama olayı
        private void SilMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            MessageBox.Show("Kayıt silindi.");
        }

        // İptal menüsü için tıklama olayı
        private void IptalMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İptal.");
        }

        // Çıkış menüsü için tıklama olayı
        private void CikisMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Uygulamayı kapatma
        }
        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)  // Sağ tıklama kontrolü
            {
                contextMenuStrip1.Show(gridControl1, e.Location);  // Sağ tıklama menüsünü açma
            }
        }
    }
}

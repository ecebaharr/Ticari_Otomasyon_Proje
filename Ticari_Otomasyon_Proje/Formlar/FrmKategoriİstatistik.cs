﻿using DevExpress.XtraCharts;
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
            

               

            LblKategoriSayisi.Text=db.TBLKATEGORI.Count().ToString();
                        LblSonEklenenKategori.Text = db.TBLKATEGORI.OrderByDescending(x=>x.ID).Select(y=> y.KATEGORİAD).FirstOrDefault().ToString();
                        var deger = db.TBLURUN.GroupBy(x=> x.KATEGORI).OrderByDescending(z=>z.Count()).Select(y=>y.Key).FirstOrDefault();
            LblEnFazlaÜrünKategori.Text = db.TBLKATEGORI.Where(x => x.ID == deger).Select(y => y.KATEGORİAD).FirstOrDefault().ToString();

            var degerler = db.TBLURUN.ToList();
            foreach(var x in degerler)
            {
                chartControl1.Series["Kategori"].Points.AddPoint(x.URUNAD,short.Parse(x.STOK.ToString()));
            }


        }
    }
}

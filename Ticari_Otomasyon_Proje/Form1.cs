﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticari_Otomasyon_Proje.Formlar;

namespace Ticari_Otomasyon_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUrunler frm = new FrmUrunler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnKategoriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKategoriler frm = new FrmKategoriler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BrnUrunistatistikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Frmistatistikler frm = new Formlar.Frmistatistikler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnKategoriİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmKategoriİstatistik frm = new Formlar.FrmKategoriİstatistik();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmKategoriEkle fr = new Formlar.FrmKategoriEkle();
            fr.Show();
        }

        private void BtnYeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmUrunEkle fr = new Formlar.FrmUrunEkle();
            fr.Show();
        }

        private void BtnCariListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariListesi fr = new Formlar.FrmCariListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYeniCari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCariKart fr = new FrmCariKart();
            fr.Show();
        }

        private void BtnCariistatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariistatistik frm = new Formlar.FrmCariistatistik();
            frm.MdiParent= this;
            frm.Show();
        }

        private void BtnCariHareket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariHareket frm = new Formlar.FrmCariHareket();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmPersonel frm = new Formlar.FrmPersonel();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

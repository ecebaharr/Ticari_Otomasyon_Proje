﻿namespace Ticari_Otomasyon_Proje.Formlar
{
    partial class FrmKategoriİstatistik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.LblKategoriSayisi = new DevExpress.XtraEditors.LabelControl();
            this.bb = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.LblSonEklenenKategori = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.LblEnFazlaÜrünKategori = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(364, 452);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl1.Controls.Add(this.LblKategoriSayisi);
            this.panelControl1.Controls.Add(this.bb);
            this.panelControl1.Location = new System.Drawing.Point(394, 12);
            this.panelControl1.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelControl1.LookAndFeel.SkinName = "DevExpress Style";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(263, 138);
            this.panelControl1.TabIndex = 1;
            // 
            // LblKategoriSayisi
            // 
            this.LblKategoriSayisi.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKategoriSayisi.Appearance.ForeColor = System.Drawing.Color.Black;
            this.LblKategoriSayisi.Appearance.Options.UseFont = true;
            this.LblKategoriSayisi.Appearance.Options.UseForeColor = true;
            this.LblKategoriSayisi.Location = new System.Drawing.Point(88, 81);
            this.LblKategoriSayisi.Name = "LblKategoriSayisi";
            this.LblKategoriSayisi.Size = new System.Drawing.Size(16, 36);
            this.LblKategoriSayisi.TabIndex = 4;
            this.LblKategoriSayisi.Text = "0";
            // 
            // bb
            // 
            this.bb.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bb.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bb.Appearance.ForeColor = System.Drawing.Color.Black;
            this.bb.Appearance.Options.UseBackColor = true;
            this.bb.Appearance.Options.UseFont = true;
            this.bb.Appearance.Options.UseForeColor = true;
            this.bb.Location = new System.Drawing.Point(88, 23);
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(109, 21);
            this.bb.TabIndex = 1;
            this.bb.Text = "Kategori Sayısı";
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelControl2.Appearance.BorderColor = System.Drawing.Color.White;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Appearance.Options.UseBorderColor = true;
            this.panelControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl2.Controls.Add(this.LblSonEklenenKategori);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Location = new System.Drawing.Point(676, 12);
            this.panelControl2.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelControl2.LookAndFeel.SkinName = "DevExpress Style";
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(263, 138);
            this.panelControl2.TabIndex = 2;
            // 
            // LblSonEklenenKategori
            // 
            this.LblSonEklenenKategori.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSonEklenenKategori.Appearance.ForeColor = System.Drawing.Color.Black;
            this.LblSonEklenenKategori.Appearance.Options.UseFont = true;
            this.LblSonEklenenKategori.Appearance.Options.UseForeColor = true;
            this.LblSonEklenenKategori.Location = new System.Drawing.Point(54, 81);
            this.LblSonEklenenKategori.Name = "LblSonEklenenKategori";
            this.LblSonEklenenKategori.Size = new System.Drawing.Size(16, 36);
            this.LblSonEklenenKategori.TabIndex = 5;
            this.LblSonEklenenKategori.Text = "0";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(54, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(157, 21);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Son Eklenen Kategori\r\n";
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelControl3.Appearance.BorderColor = System.Drawing.Color.White;
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.Appearance.Options.UseBorderColor = true;
            this.panelControl3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl3.Controls.Add(this.LblEnFazlaÜrünKategori);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Location = new System.Drawing.Point(959, 12);
            this.panelControl3.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelControl3.LookAndFeel.SkinName = "DevExpress Style";
            this.panelControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(263, 138);
            this.panelControl3.TabIndex = 3;
            // 
            // LblEnFazlaÜrünKategori
            // 
            this.LblEnFazlaÜrünKategori.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblEnFazlaÜrünKategori.Appearance.ForeColor = System.Drawing.Color.Black;
            this.LblEnFazlaÜrünKategori.Appearance.Options.UseFont = true;
            this.LblEnFazlaÜrünKategori.Appearance.Options.UseForeColor = true;
            this.LblEnFazlaÜrünKategori.Location = new System.Drawing.Point(44, 81);
            this.LblEnFazlaÜrünKategori.Name = "LblEnFazlaÜrünKategori";
            this.LblEnFazlaÜrünKategori.Size = new System.Drawing.Size(16, 36);
            this.LblEnFazlaÜrünKategori.TabIndex = 6;
            this.LblEnFazlaÜrünKategori.Text = "0";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(44, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(183, 21);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "En Fazla Ürünlü Kategori";
            // 
            // chartControl1
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Location = new System.Drawing.Point(394, 155);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "Kategori";
            series1.SeriesID = 2;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(828, 296);
            this.chartControl1.TabIndex = 4;
            // 
            // FrmKategoriİstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 454);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmKategoriİstatistik";
            this.Text = "Kategori İstatistik";
            this.Load += new System.EventHandler(this.FrmKategoriİstatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl bb;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl LblKategoriSayisi;
        private DevExpress.XtraEditors.LabelControl LblSonEklenenKategori;
        private DevExpress.XtraEditors.LabelControl LblEnFazlaÜrünKategori;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}
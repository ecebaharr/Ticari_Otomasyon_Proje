namespace Ticari_Otomasyon_Proje.Formlar
{
    partial class FrmBarkod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBarkod));
            this.Bcozumle = new DevExpress.XtraEditors.SimpleButton();
            this.Bolustur = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Bcozumle
            // 
            this.Bcozumle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Bcozumle.ImageOptions.Image")));
            this.Bcozumle.Location = new System.Drawing.Point(192, 277);
            this.Bcozumle.Name = "Bcozumle";
            this.Bcozumle.Size = new System.Drawing.Size(179, 39);
            this.Bcozumle.TabIndex = 9;
            this.Bcozumle.Text = "Barkod Çözümle";
            this.Bcozumle.Click += new System.EventHandler(this.Bcozumle_Click);
            // 
            // Bolustur
            // 
            this.Bolustur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Bolustur.ImageOptions.Image")));
            this.Bolustur.Location = new System.Drawing.Point(12, 277);
            this.Bolustur.Name = "Bolustur";
            this.Bolustur.Size = new System.Drawing.Size(179, 39);
            this.Bolustur.TabIndex = 8;
            this.Bolustur.Text = "Barkod Oluştur";
            this.Bolustur.Click += new System.EventHandler(this.Bolustur_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(121, 34);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(246, 24);
            this.textEdit1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Metni Giriniz: ";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(12, 81);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(355, 177);
            this.pictureEdit1.TabIndex = 5;
            // 
            // FrmBarkod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 328);
            this.Controls.Add(this.Bcozumle);
            this.Controls.Add(this.Bolustur);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureEdit1);
            this.Name = "FrmBarkod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barkod";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Bcozumle;
        private DevExpress.XtraEditors.SimpleButton Bolustur;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}
namespace Ticari_Otomasyon_Proje.Formlar
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblkullaniciadi = new DevExpress.XtraEditors.LabelControl();
            this.textEditKullanici = new DevExpress.XtraEditors.TextEdit();
            this.textEditSifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.BtnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUnuttum = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditKullanici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblkullaniciadi
            // 
            this.lblkullaniciadi.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkullaniciadi.Appearance.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblkullaniciadi.Appearance.Options.UseFont = true;
            this.lblkullaniciadi.Appearance.Options.UseForeColor = true;
            this.lblkullaniciadi.Location = new System.Drawing.Point(390, 104);
            this.lblkullaniciadi.Name = "lblkullaniciadi";
            this.lblkullaniciadi.Size = new System.Drawing.Size(114, 21);
            this.lblkullaniciadi.TabIndex = 0;
            this.lblkullaniciadi.Text = "Kullanıcı Adı:";
            // 
            // textEditKullanici
            // 
            this.textEditKullanici.Location = new System.Drawing.Point(530, 101);
            this.textEditKullanici.Name = "textEditKullanici";
            this.textEditKullanici.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEditKullanici.Properties.Appearance.Options.UseFont = true;
            this.textEditKullanici.Size = new System.Drawing.Size(245, 28);
            this.textEditKullanici.TabIndex = 1;
            // 
            // textEditSifre
            // 
            this.textEditSifre.Location = new System.Drawing.Point(530, 162);
            this.textEditSifre.Name = "textEditSifre";
            this.textEditSifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEditSifre.Properties.Appearance.Options.UseFont = true;
            this.textEditSifre.Size = new System.Drawing.Size(245, 28);
            this.textEditSifre.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(390, 165);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 21);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Şifre:";
            // 
            // BtnGiris
            // 
            this.BtnGiris.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGiris.Appearance.Options.UseFont = true;
            this.BtnGiris.Location = new System.Drawing.Point(530, 236);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(245, 47);
            this.BtnGiris.TabIndex = 4;
            this.BtnGiris.Text = "Giriş Yap";
            // 
            // BtnUnuttum
            // 
            this.BtnUnuttum.Appearance.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnUnuttum.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUnuttum.Appearance.ForeColor = System.Drawing.Color.Red;
            this.BtnUnuttum.Appearance.Options.UseBackColor = true;
            this.BtnUnuttum.Appearance.Options.UseFont = true;
            this.BtnUnuttum.Appearance.Options.UseForeColor = true;
            this.BtnUnuttum.Location = new System.Drawing.Point(530, 305);
            this.BtnUnuttum.Name = "BtnUnuttum";
            this.BtnUnuttum.Size = new System.Drawing.Size(245, 47);
            this.BtnUnuttum.TabIndex = 5;
            this.BtnUnuttum.Text = "Şifremi Unuttum!";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(430, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(306, 40);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "EBTicaret Yönetim";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(0, 10);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(357, 359);
            this.pictureEdit1.TabIndex = 7;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 381);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.BtnUnuttum);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.textEditSifre);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEditKullanici);
            this.Controls.Add(this.lblkullaniciadi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            ((System.ComponentModel.ISupportInitialize)(this.textEditKullanici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblkullaniciadi;
        private DevExpress.XtraEditors.TextEdit textEditKullanici;
        private DevExpress.XtraEditors.TextEdit textEditSifre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton BtnGiris;
        private DevExpress.XtraEditors.SimpleButton BtnUnuttum;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}
namespace Ticari_Otomasyon_Proje.Formlar
{
    partial class FrmMetniSeslendir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMetniSeslendir));
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.BtnSeslendir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(1, 0);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.memoEdit1.Properties.Appearance.Options.UseFont = true;
            this.memoEdit1.Size = new System.Drawing.Size(648, 363);
            this.memoEdit1.TabIndex = 0;
            // 
            // BtnSeslendir
            // 
            this.BtnSeslendir.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSeslendir.Appearance.Options.UseFont = true;
            this.BtnSeslendir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSeslendir.ImageOptions.Image")));
            this.BtnSeslendir.Location = new System.Drawing.Point(235, 384);
            this.BtnSeslendir.Name = "BtnSeslendir";
            this.BtnSeslendir.Size = new System.Drawing.Size(178, 45);
            this.BtnSeslendir.TabIndex = 1;
            this.BtnSeslendir.Text = "Seslendir";
            this.BtnSeslendir.Click += new System.EventHandler(this.BtnSeslendir_Click);
            // 
            // FrmMetniSeslendir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 455);
            this.Controls.Add(this.BtnSeslendir);
            this.Controls.Add(this.memoEdit1);
            this.Name = "FrmMetniSeslendir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMetniSeslendir";
            this.Load += new System.EventHandler(this.FrmMetniSeslendir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.SimpleButton BtnSeslendir;
    }
}
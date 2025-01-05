using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon_Proje.Formlar
{
    public partial class FrmYoutube : Form
    {
        public FrmYoutube()
        {
            InitializeComponent();
        }

        private async void FrmYoutube_Load(object sender, EventArgs e)
        {
            
                await webView21.EnsureCoreWebView2Async(null);
                webView21.CoreWebView2.Navigate("https://www.youtube.com/");


            
        }
    }
}

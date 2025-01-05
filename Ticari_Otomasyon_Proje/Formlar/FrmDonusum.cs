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
    public partial class FrmDonusum : Form
    {
        public FrmDonusum()
        {
            InitializeComponent();
        }

        private void FrmDonusum_Load(object sender, EventArgs e)
        {

        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar = 0;
            kur= Convert.ToDouble(TxtKur.Text);
            miktar= Convert.ToDouble(TxtMiktar.Text);
            tutar = kur * miktar;
            TxtTutar.Text=tutar.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

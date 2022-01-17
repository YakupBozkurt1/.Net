using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bufe_Paneli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasa = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int mısır, su, cay, bilet, toplam;
            mısır = Convert.ToInt32(txtMisir.Text);
            su = Convert.ToInt32(txtSu.Text);
            cay = Convert.ToInt32(txtCay.Text);
            bilet = Convert.ToInt32(txtBilet.Text);
            toplam = mısır * 4 + su * 1 + cay * 2 + bilet * 8;
            lbltoplam.Text = toplam.ToString();
            kasa += toplam;
            lblkasa.Text = kasa.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMisir.Text = "";
            txtSu.Text = "";
            txtCay.Text = "";
            txtBilet.Text = "";
            txtMisir.Focus();
        }
    }
}

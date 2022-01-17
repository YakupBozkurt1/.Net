using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siniflar_Ornek
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Araba rb2 = new Araba();

            rb2.renk = "Yeşil";
            rb2.fiyat = 2000;
            rb2.hız = 143;
            rb2.motor = 234.34;
            rb2.durum = 'i';

            label1.Text = rb2.renk;
            label2.Text = rb2.fiyat.ToString();
            label3.Text = rb2.durum.ToString();
            label4.Text = rb2.motor.ToString();
            label5.Text = rb2.hız.ToString();

        }
    }
}

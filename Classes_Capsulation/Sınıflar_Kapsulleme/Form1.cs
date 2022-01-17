using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınıflar_Kapsulleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba rb = new Araba();

            rb.hız = 175;
            rb.fiyat = 3000;
            rb.durum = 's';
            rb.motor = 450.3;
            rb.renk = "Yeşil";
            rb.MARKASI = "Polo";
            rb.Year = 2014;

            rb.muayene = 2017;
            rb.sahip = "Yakup Bozkurt";
            rb.plaka = "34 BC 6304";

            label1.Text = rb.hız.ToString();
            label2.Text = rb.motor.ToString();
            label3.Text = rb.fiyat.ToString();
            label4.Text = rb.durum.ToString();
            label5.Text = rb.renk;
            label6.Text = rb.MARKASI;
            label7.Text = rb.Year.ToString();
            label8.Text = rb.plaka;
            label9.Text = rb.sahip;
            label10.Text = rb.muayene.ToString();

        }
    }
}

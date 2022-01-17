using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            string[] sembol1 = { "a", "b", "c", "d", "e", "f", "g" };
            string[] sembol2 = { "+", "-", "*", "/", "#" };

            int s1, s2, s3;

            s1 = rnd.Next(0, 7);
            s2 = rnd.Next(0, 5);
            s3 = rnd.Next(1, 10);

            label1.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + s3.ToString();
        }
    }
}

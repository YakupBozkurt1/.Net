using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int cnt = 0;
            int[] sınavlar = { 12, 14, 5, 8, 20, 22 };
            foreach(int x in sınavlar)
            {
                if (x % 4 == 0)
                {
                    listBox1.Items.Add(x);
                    toplam += x;
                    cnt++;
                }
            }
            label1.Text = toplam.ToString();
            label2.Text = cnt.ToString();
        }

        
    }
}

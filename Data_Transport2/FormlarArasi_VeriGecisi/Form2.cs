using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarArasi_VeriGecisi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string mesaj, kimden, nereden, neden;
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = mesaj;
            textBox1.Text = kimden;
            listBox1.Items.Add(nereden);
            richTextBox1.Text = neden;
            comboBox1.Items.Add(mesaj);
        }
    }
}

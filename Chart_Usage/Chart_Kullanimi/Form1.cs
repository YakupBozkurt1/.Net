using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            chart1.Series["BasketOynama"].Points.AddXY(2, 60);
            chart1.Series["BasketOynama"].Points.AddXY(3, 80);
            chart1.Series["BasketOynama"].Points.AddXY(4, 120);
            chart1.Series["BasketOynama"].Points.AddXY(5, 20);
            chart1.Series["BasketOynama"].Points.AddXY(6, 10);
            chart1.Series["BasketOynama"].Points.AddXY(7, 70);
        }
    }
}

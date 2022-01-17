using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Point_Yapisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Point pnt = new Point();
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
            pnt.X = 0;
            pnt.Y = 0;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnt.X++;
            pnt.Y++;
            pictureBox1.Location = pnt;
        }
    }
}

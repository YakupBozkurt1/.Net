using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dİnamik_Yapilar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btnpoint = new Point(20, 10);
            Label lbl = new Label();
            Point lblpoint = new Point(200, 50);

            btn.Location = btnpoint;

            btn.Name = "button1";
            btn.Text = "Hello";
            btn.BackColor = Color.AliceBlue;
            btn.Height = 50;
            btn.Width = 150;
            this.Controls.Add(btn);

            lbl.Location = lblpoint;

            lbl.Name = "label1";
            lbl.Text = "Whassup";
            lbl.BackColor = Color.Red;
            lbl.AutoSize = true;
            this.Controls.Add(lbl);

            

            for (int i = 1; i <= 5; i++)
            {
                TextBox txt = new TextBox();
                Point txtpoint = new Point(350, i * 30);
                txt.Location = txtpoint;
                txt.Name = "TextBox" + i;
                txt.Text = i + ". Whassup";
                txt.Height = 30;
                txt.Width = 150;
                this.Controls.Add(txt);



            }           
        }
    }
}

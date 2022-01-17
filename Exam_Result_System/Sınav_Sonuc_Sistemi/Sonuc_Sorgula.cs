using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Sınav_Sonuc_Sistemi
{
    public partial class Sonuc_Sorgula : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-AK5Q0PBD\\SQLEXPRESS;Initial Catalog=Sınav_Sistemi;Integrated Security=True");
        public Sonuc_Sorgula()
        {
            InitializeComponent();
        }
        public string Mesaj_Ad, MesaJ_Soyad, Mesaj_Sehir, Mesaj_Puan, Mesaj_Numara;

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Metin Belgesi";
            saveFileDialog1.Filter = "Metin Belgesi | *.txt";
            saveFileDialog1.ShowDialog();
            StreamWriter sr = new StreamWriter(saveFileDialog1.FileName);
            sr.WriteLine(label1.Text + lbl_Ad.Text + "\n" + label2.Text + lbl_Soyad.Text + "\n" + label3.Text + lbl_Sehir.Text + "\n" + label4.Text + lbl_Puan.Text + "\n" + label5.Text + lbl_Numara.Text + "\n");
            sr.Close();
        }

        private void Sonuc_Sorgula_Load(object sender, EventArgs e)
        {
            AnaForm frm1 = new AnaForm();
            lbl_Ad.Text = Mesaj_Ad;
            lbl_Soyad.Text = MesaJ_Soyad;
            lbl_Sehir.Text = Mesaj_Sehir;
            lbl_Puan.Text = Mesaj_Puan;
            lbl_Numara.Text = Mesaj_Numara;
            if (Convert.ToDouble(lbl_Puan.Text) >= 300)
                MessageBox.Show("Tebrikler! Yerleşmeye hak kazandınız.");
            else
                MessageBox.Show("Yerleşmeye hak kazanamadınız.");
        }
    }
}

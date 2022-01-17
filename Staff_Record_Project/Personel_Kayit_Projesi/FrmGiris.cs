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

namespace Personel_Kayit_Projesi
{
    public partial class FrmGiris : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-AK5Q0PBD\\SQLEXPRESS; Initial Catalog = PersonelVeriTabani; Integrated Security = True");

        public FrmGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Giris where KullanıcıAdı = @p1 and Sifre = @p2", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr1 = komut.ExecuteReader();
            if (dr1.Read())
            {
                AnaForm frm = new AnaForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da Şifreniz yanlış");
            }
            baglanti.Close();
        }
    }
}

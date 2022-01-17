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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-AK5Q0PBD\\SQLEXPRESS; Initial Catalog = PersonelVeriTabani; Integrated Security = True");
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            //Toplam Personeli Alma
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select Count(*) from Tbl_Personel", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblTopPer.Text = dr1[0].ToString();
            }
            baglanti.Close();
        }
    }
}

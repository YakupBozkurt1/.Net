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
    public partial class FrmStats : Form
    {
        public FrmStats()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-AK5Q0PBD\\SQLEXPRESS; Initial Catalog = PersonelVeriTabani; Integrated Security = True");
        private void FrmStats_Load(object sender, EventArgs e)
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

            //Evli Personeli Alma
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select count(*) from Tbl_Personel where PerDurum = 1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblEvliPer.Text = dr2[0].ToString();
            }
            baglanti.Close();

            //Bekar Personeli Alma
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select count(*) from Tbl_Personel where PerDurum = 0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblBekarPer.Text = dr3[0].ToString();
            }
            baglanti.Close();

            //Şehir Sayısı Alma
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select count (distinct(PerSehir)) from Tbl_Personel", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblSehir.Text = dr4[0].ToString();
            }
            baglanti.Close();

            //Toplam Maas Alma
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(PerMaas) from Tbl_Personel", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblTopMaas.Text = dr5[0].ToString();
            }
            baglanti.Close();

            //Ort Maas Alma
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select Avg(PerMaas) from Tbl_Personel", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblAvgMaas.Text = dr6[0].ToString();
            }
            baglanti.Close();
        }
    }
}

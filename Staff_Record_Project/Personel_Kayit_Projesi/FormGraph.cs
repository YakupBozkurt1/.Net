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
    public partial class FormGraph : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-AK5Q0PBD\\SQLEXPRESS; Initial Catalog = PersonelVeriTabani; Integrated Security = True");
        public FormGraph()
        {
            InitializeComponent();
        }

        private void FormGraph_Load(object sender, EventArgs e)
        {
            //1.Grafik
            baglanti.Open();
            SqlCommand komutg1 = new SqlCommand("select PerSehir, count(*) from Tbl_Personel group by PerSehir", baglanti);
            SqlDataReader drg1 = komutg1.ExecuteReader();
            while (drg1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(drg1[0], drg1[1]);
            }
            baglanti.Close();

            //2.Grafik
            baglanti.Open();
            SqlCommand komutg2 = new SqlCommand("Select PerMeslek, Avg(PerMaas) from Tbl_Personel group by PerMeslek", baglanti);
            SqlDataReader drg2 = komutg2.ExecuteReader();
            while (drg2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(drg2[0], drg2[1]);
            }
            baglanti.Close();
        
        }
    }
}

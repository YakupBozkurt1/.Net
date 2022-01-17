using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Projesi
{
    public partial class FrmHastaBilgiDuzenle : Form
    {
        public FrmHastaBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string TcNo;
        SqlBaglanti bgl = new SqlBaglanti();
        private void FrmHastaBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskTCNo.Text = TcNo;

            SqlCommand komut = new SqlCommand("Select * from Tbl_Hasta where HastaTC = '" + TcNo + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                MskTelNo.Text = dr[4].ToString();
                TxtSifre.Text = dr[5].ToString();
                CmbCins.Text = dr[6].ToString();

            }
        }

        private void BtnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update Tbl_Hasta set HastaAd= @p1, HastaSoyad=@p2, HastaTel=@p3, HastaSifre = @p4, HastaCins = @p5 where HastaTC = @p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut2.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", MskTelNo.Text);
            komut2.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komut2.Parameters.AddWithValue("@p5", CmbCins.SelectedItem);
            komut2.Parameters.AddWithValue("@p6", MskTCNo.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Bilgiler Guncellendi.");
        }
    }
}

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

namespace Hastane_Projesi
{
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string tcno2;

        SqlBaglanti bgl = new SqlBaglanti();
        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            //Bilgiler Textboxlara aktarma
            MskTCNo.Text = tcno2;
            SqlCommand komut = new SqlCommand("Select DoktorAd, DoktorSoyad, DoktorBrans, DoktorSifre from Tbl_Doktor where DoktorTC = '" + MskTCNo.Text + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[0].ToString();
                TxtSoyad.Text = dr[1].ToString();
                CmbBrans.Text = dr[2].ToString();
                TxtSifre.Text = dr[3].ToString();
            }
            bgl.baglanti().Close();

            //Comboboxa bransları ekleme
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
        }

        private void BtnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update Tbl_Doktor set DoktorAd = @p1, DoktorSoyad = @p2, DoktorBrans = @p3, DoktorSifre = @p4 where DoktorTC= @p5 ", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut2.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komut2.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komut2.Parameters.AddWithValue("@p5", MskTCNo.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgiler Guncellendi!");

        }
    }
}

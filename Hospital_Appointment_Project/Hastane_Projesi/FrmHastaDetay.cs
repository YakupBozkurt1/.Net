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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;

        SqlBaglanti bgl = new SqlBaglanti();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            //TC ve Ad Soyad Çekme

            LblTcNo.Text = tc;
            
            SqlCommand komut = new SqlCommand("Select HastaAd, HastaSoyad from Tbl_Hasta where HastaTC = @k1", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", LblTcNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Branş Ekleme

            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Brans ", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            //Randevu Geçmişi Görüntüleme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevu where HastaTC = '" + LblTcNo.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Doktor Ekleme
            CmbDoktor.Items.Clear();

            SqlCommand komut3 = new SqlCommand("Select DoktorAd, DoktorSoyad from Tbl_Doktor where DoktorBrans = @p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }

            

        }

        private void LnlBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaBilgiDuzenle fr = new FrmHastaBilgiDuzenle();
            fr.TcNo = LblTcNo.Text;
            fr.Show();

        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aktif Randevuları Listeleme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevu where RandevuBrans = '" + CmbBrans.Text + "'" + "and RandevuDoktor = '" + CmbDoktor.Text + "' and RandevuDurum = 0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            CmbBrans.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            CmbDoktor.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Randevu set RandevuDurum = 1, HastaTC = @p2, HastaSikayet = @p3 where Randevuid = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtID.Text);
            komut.Parameters.AddWithValue("@p2", LblTcNo.Text);
            komut.Parameters.AddWithValue("@p3", RchSikayet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

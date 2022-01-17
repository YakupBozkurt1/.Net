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
    public partial class AnaForm : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-AK5Q0PBD\\SQLEXPRESS;Initial Catalog=Sınav_Sistemi;Integrated Security=True");

        private void temizle()
        {
            txt_Ad.Text = "";
            txt_Soyad.Text = "";
            txt_Sehir.Text = "";
            txt_Puan.Text = "";
            txt_Numara.Text = "";
            txt_Ad.Focus();
        }
        public AnaForm()
        {
            InitializeComponent();
        }

        

        private void AnaForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sınav_SistemiDataSet.Tbl_Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_OgrenciTableAdapter.Fill(this.sınav_SistemiDataSet.Tbl_Ogrenci);

        }

        private void Btn_Listele_Click(object sender, EventArgs e)
        {
            this.tbl_OgrenciTableAdapter.Fill(this.sınav_SistemiDataSet.Tbl_Ogrenci);
        }

        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into Tbl_Ogrenci(Ad, Soyad, Sehir, Puan, Numara) values (@p1, @p2, @p3, @p4, @p5)", baglanti);
            komut2.Parameters.AddWithValue("@p1", txt_Ad.Text);
            komut2.Parameters.AddWithValue("@p2", txt_Soyad.Text);
            komut2.Parameters.AddWithValue("@p3", txt_Sehir.Text);
            komut2.Parameters.AddWithValue("@p4", Convert.ToDouble(txt_Puan.Text));
            komut2.Parameters.AddWithValue("@p5", Convert.ToInt32(txt_Numara.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txt_Ad.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_Soyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_Sehir.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_Puan.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txt_Numara.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Delete from Tbl_Ogrenci where Numara = @k1", baglanti);
            komut3.Parameters.AddWithValue("@k1", txt_Numara.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Update Tbl_Ogrenci Set Ad = @a1, Soyad = @a2, Sehir = @a3, Puan = @a4, Numara = @a5 where Numara = @a5", baglanti);
            komut4.Parameters.AddWithValue("@a1", txt_Ad.Text);
            komut4.Parameters.AddWithValue("@a2", txt_Soyad.Text);
            komut4.Parameters.AddWithValue("@a3", txt_Sehir.Text);
            komut4.Parameters.AddWithValue("@a4", Convert.ToDouble(txt_Puan.Text));
            komut4.Parameters.AddWithValue("@a5", txt_Numara.Text);
            komut4.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btn_Sorgula_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sonuc_Sorgula frm = new Sonuc_Sorgula();
            frm.Mesaj_Ad = txt_Ad.Text;
            frm.MesaJ_Soyad = txt_Soyad.Text;
            frm.Mesaj_Sehir = txt_Sehir.Text;
            frm.Mesaj_Puan = txt_Puan.Text;
            frm.Mesaj_Numara = txt_Numara.Text;
            frm.Show();
            
        }

       
    }
}

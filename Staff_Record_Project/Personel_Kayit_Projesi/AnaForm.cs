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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-AK5Q0PBD\\SQLEXPRESS; Initial Catalog = PersonelVeriTabani; Integrated Security = True");
        
        void temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtSehir.Text = "";
            txtMaas.Text = "";
            txtMeslek.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtAd.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // TODO: Bu kod satırı 'personelVeriTabaniDataSet.Tbl_Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerIsim, PerSoyad, PerSehir, PerMaas, PerMeslek, PerDurum) values (@p1, @p2, @p3, @p4, @p5, @p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtSehir.Text);
            komut.Parameters.AddWithValue("@p4", txtMaas.Text);
            komut.Parameters.AddWithValue("@p5", txtMeslek.Text);
            if (radioButton1.Checked)
                komut.Parameters.AddWithValue("@p6", "true");
            else if (radioButton2.Checked)
                komut.Parameters.AddWithValue("@p6", "false");
            komut.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Personel Eklendi");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString() == "True")
                radioButton1.Checked = true;
            else if (dataGridView1.Rows[secilen].Cells[5].Value.ToString() == "False")
                radioButton2.Checked = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Personel Where PerID = @k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", txtID.Text);
            komutsil.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Kayıt Silindi!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut_guncelle = new SqlCommand("Update Tbl_Personel Set PerIsim = @a1, PerSoyad = @a2, PerSehir = @a3, PerMaas = @a4, PerDurum = @a5, PerMeslek = @a6 where PerID = @a7", baglanti);
            komut_guncelle.Parameters.AddWithValue("@a1", txtAd.Text);
            komut_guncelle.Parameters.AddWithValue("@a2", txtSoyad.Text);
            komut_guncelle.Parameters.AddWithValue("@a3", txtSehir.Text);
            komut_guncelle.Parameters.AddWithValue("@a4", txtMaas.Text);
            komut_guncelle.Parameters.AddWithValue("@a6", txtMeslek.Text);
            komut_guncelle.Parameters.AddWithValue("@a7", txtID.Text);
            if (radioButton1.Checked)
                komut_guncelle.Parameters.AddWithValue("@a5", true);
            else if (radioButton2.Checked)
                komut_guncelle.Parameters.AddWithValue("@a5", false);
            komut_guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bilgiler Güncellendi.");
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            FrmStats fr = new FrmStats();
            fr.Show();
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            FormGraph frg = new FormGraph();
            frg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

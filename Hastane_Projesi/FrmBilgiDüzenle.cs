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
    public partial class FrmBilgiDüzenle : Form
    {
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
        }
        public string TCno;
        SqlBaglantısı bgl = new SqlBaglantısı();    
        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            maskedTc.Text= TCno;    
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTc= @p1", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", maskedTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                MaskedNumara.Text = dr[4].ToString();
                txtsifre.Text = dr[5].ToString();
                cmbCinsiyet.Text = dr[6].ToString();

                bgl.baglantı().Close();

            }

        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd = @p1, HastaSoyad = @p2, HastaTelefon = @p3, HastaSifre = @p4, HastaCinsiyet = @p5 where HastaTc = @p6", bgl.baglantı());
            komut2.Parameters.AddWithValue("@p1", txtAd.Text);
            komut2.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", MaskedNumara.Text);
            komut2.Parameters.AddWithValue("@p4", txtsifre.Text);
            komut2.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", maskedTc.Text);
            komut2.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Bilgileriniz Güncellendi" , "Bilgi :", MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

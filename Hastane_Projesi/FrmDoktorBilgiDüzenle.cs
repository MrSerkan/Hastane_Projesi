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
    public partial class FrmDoktorBilgiDüzenle : Form
    {
        public FrmDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }
        SqlBaglantısı bgl = new SqlBaglantısı();
        public string TCNO;

        private void FrmDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            maskedTc.Text = TCNO;

            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTc= @p1", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", maskedTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) 
            {
             txtAd.Text = dr[1].ToString();
             txtSoyad.Text = dr[2].ToString();
             cmbBrans.Text = dr[3].ToString();  
             txtsifre.Text = dr[5].ToString();   

            }
            bgl.baglantı().Close();

        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd = @p1, DoktorSoyad = @p2,DoktorBrans = @p3, Doktorsifre = @p4 where DoktorTc = @p5", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@p4", txtsifre.Text);
            komut.Parameters.AddWithValue("@p5", maskedTc.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Kayıt Güncellendi");


        }
    }
}

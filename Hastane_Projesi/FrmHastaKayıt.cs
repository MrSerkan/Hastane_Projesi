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
    public partial class FrmHastaKayıt : Form
    {
        public FrmHastaKayıt()
        {
            InitializeComponent();
        }
        SqlBaglantısı bgl = new SqlBaglantısı();    
     

        private void BtnKayıt_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (HastaAd, HastaSoyad, HastaTc, HastaTelefon, HastaSifre, HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedTc.Text);
            komut.Parameters.AddWithValue("@p4", MaskedNumara.Text);
            komut.Parameters.AddWithValue("@p5", txtsifre.Text);
            komut.Parameters.AddWithValue("@p6", cmbCinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            
            MessageBox.Show("Kaydınız Gerçekleşmiştir" + txtsifre.Text ," Bilgi  ",MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtAd.Text = " ";
            txtSoyad.Text = " ";
            maskedTc.Text = " ";
            MaskedNumara.Text = " ";    
            txtsifre.Text =   " ";
            cmbCinsiyet.Text = " ";    

        }

        private void FrmHastaKayıt_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }
        SqlBaglantısı bgl = new SqlBaglantısı();

        private void linkÜyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayıt fr = new FrmHastaKayıt();
            fr.Show();
        }

        private void btngiriş_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar Where HastaTc = @p1 and HastaSifre = @p2", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", maskedTc.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmHastaDetay fr = new FrmHastaDetay();
                fr.tc= maskedTc.Text;   
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş" );
                maskedTc.Text = "";
                txtsifre.Text = "";    
            }
            bgl.baglantı().Close();
        }
        int a = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            a++;
            if (a % 2 == 0)
            {
                txtsifre.UseSystemPasswordChar =false;
            }
            else
            {
                txtsifre.UseSystemPasswordChar = true;
            }

           
        }

        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}

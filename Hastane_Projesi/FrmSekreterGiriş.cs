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
    public partial class FrmSekreterGiriş : Form
    {
        public FrmSekreterGiriş()
        {
            InitializeComponent();
        }
        SqlBaglantısı bgl = new SqlBaglantısı();
        private void FrmSekreterGiriş_Load(object sender, EventArgs e)
        {

        }

        private void btngiriş_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Sekreter where SekreterTc = @p1 and SekreterSifre = @p2", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1" , maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2" , txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmSekreterDetay frs = new FrmSekreterDetay();
                frs.TCnumarası = maskedTextBox1.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Tc veya Şifre");
            }
            bgl.baglantı().Close();
            maskedTextBox1.Text = "";
            txtsifre.Text = "";    
        }
        int a = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            a++;
            if (a % 2 == 0)
            {
                txtsifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtsifre.UseSystemPasswordChar = true;
            }
        }
    }
}

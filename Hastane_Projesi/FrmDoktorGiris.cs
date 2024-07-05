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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        SqlBaglantısı bgl = new SqlBaglantısı();
        private void btngiriş_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Doktorlar where DoktorTc = @p1 and DoktorSifre = @p2", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) 
            {
            FrmDoktorDetay fr = new FrmDoktorDetay();
                fr.TC = maskedTextBox1.Text;
                fr.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre");
                

            }
            bgl.baglantı().Close();
            maskedTextBox1.Text = "";
            txtsifre.Text = "";

        }

        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {

        }
    }
}

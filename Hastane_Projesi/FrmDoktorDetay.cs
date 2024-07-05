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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        SqlBaglantısı bgl = new SqlBaglantısı();
        public string TC;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TC;

            // doktor Ad && Soyad//

            SqlCommand komut = new SqlCommand("Select DoktorAd , DoktorSoyad From Tbl_Doktorlar Where DoktorTC = @p1", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

                lblAdSoyad.Text = dr[0] + " " + dr[1];


            }
            bgl.baglantı().Close();

            //Randevular

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where RandevuDoktor ='"+ lblAdSoyad.Text + "'", bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource= dt;   

        }

        private void btndüzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDüzenle fr = new FrmDoktorBilgiDüzenle();
            fr.TCNO = lblTC.Text;
            fr.Show();

        }

        private void btnduyuru_Click(object sender, EventArgs e)
        {
            FrmDuyurular frd = new FrmDuyurular();
            frd.Show();
        }

        private void btnçıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rtxtboxDetay.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();


        }
    }
}

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
    public partial class FrmDoktorPaneli : Form
    {
        SqlBaglantısı bgl = new SqlBaglantısı();
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
      
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneProjeDataSet1.Tbl_Doktorlar' table. You can move, or remove it, as needed.
            this.tbl_DoktorlarTableAdapter.Fill(this.hastaneProjeDataSet1.Tbl_Doktorlar);

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Doktorlar", bgl.baglantı());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            // Combobox a aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Brans", bgl.baglantı());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                Combobrans.Items.Add(dr2[0]);
            }
            bgl.baglantı().Close();

        }

        private void btnEkle_Click(object sender, EventArgs e) // That's not working and ı don't know why//
        {
            SqlCommand komut = new SqlCommand("İnsert into Tbl_Doktorlar ( DoktorAd, DoktorSoyad, DoktorBrans, DoktorTc, DoktorSifre ) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglantı());
            komut.Parameters.AddWithValue("@d1", txtAd.Text);
            komut.Parameters.AddWithValue("@d2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", Combobrans.Text);
            komut.Parameters.AddWithValue("@d4", maskedTC.Text);
            komut.Parameters.AddWithValue("@d5", txtSifre.Text);
            komut.ExecuteNonQueryAsync();
            bgl.baglantı().Close();
            MessageBox.Show("Doktor Eklendi","Bilgi " ,MessageBoxButtons.OK , MessageBoxIcon.Information);
            this.tbl_DoktorlarTableAdapter.Fill(this.hastaneProjeDataSet1.Tbl_Doktorlar);

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Doktorlar where DoktorTc = @p1", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1",maskedTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Kayıt Silindi", " Uyarı ", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set ( doktorad, doktorsoyad ,doktorbrans ,doktorsifre ) values (@d1,@d2,@d3,@d5) where DoktorTC = @d4", bgl.baglantı());
            komut.Parameters.AddWithValue("@d1", txtAd.Text);
            komut.Parameters.AddWithValue("@d2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", Combobrans.Text);
            komut.Parameters.AddWithValue("@d4", maskedTC.Text);
            komut.Parameters.AddWithValue("@d5", txtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Doktor Güncellendi", "Bilgi ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.tbl_DoktorlarTableAdapter.Fill(this.hastaneProjeDataSet1.Tbl_Doktorlar);

        }// it does not working too//

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            Combobrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Refresh();    
        }
    }
}

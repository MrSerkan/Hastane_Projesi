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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string TCnumarası;
        SqlBaglantısı bgl = new SqlBaglantısı();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TCnumarası;
            // Ad Soyad
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTc = @p1", bgl.baglantı());
            komut1.Parameters.AddWithValue("@p1",lblTC.Text );
           SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblAdSoyad.Text = dr1[0].ToString();
            }
            bgl.baglantı().Close();

            // Branşları Datagridview e aktarma

            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Brans", bgl.baglantı());
            da.Fill(dt1);
            DataBranşlar.DataSource= dt1;   
            
            // Doktorları listeye aktarma

            DataTable dt2 =new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (doktorAd + ' ' + doktorSoyad) as 'Doktorlar', doktorbrans From Tbl_Doktorlar",bgl.baglantı());
            da2.Fill(dt2);
            DataDoktorlar.DataSource= dt2;

            // Branşı combobox a aktarma

            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Brans", bgl.baglantı());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                Combobrans.Items.Add(dr2[0]);
            }
            bgl.baglantı().Close();


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,Randevusaat,RandevuBrans,Randevudoktor) values (@r1,@r2,@r3,@r4)", bgl.baglantı());
            komutkaydet.Parameters.AddWithValue("@r1", maskedTarih.Text );
            komutkaydet.Parameters.AddWithValue("@r2", maskedSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", Combobrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", combodoktor.Text);
            komutkaydet.ExecuteNonQuery();  
            bgl.baglantı().Close() ;
            MessageBox.Show("Randevu Oluşturuldu ");

        }

        private void Combobrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            combodoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans = @p1", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", Combobrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                combodoktor.Items.Add(dr[0]+ " "+ dr[1]);
            }
            bgl.baglantı().Close();

        }

        private void BtnOluştur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)", bgl.baglantı());
            komut.Parameters.AddWithValue("@d1",richtxtDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Duyuru Oluşturuldu" );
            richtxtDuyuru.Text = "";

        }

        private void BtnDoktorPanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli dp = new FrmDoktorPaneli();
            dp.Show();


        }

      

        private void BtnBranşPanel_Click(object sender, EventArgs e)
        {
            FrmBrans frb  = new FrmBrans();
            frb.Show();


        }

        private void BtnRandevuListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frrandevu = new FrmRandevuListesi();
            frrandevu.Show();
        }

        private void btnduyuru_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}

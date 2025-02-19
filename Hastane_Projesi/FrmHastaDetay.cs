﻿using System;
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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;        
        SqlBaglantısı bgl = new SqlBaglantısı();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text = tc;    
            // Ad Soyad çekme
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTc = @p1", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();   
            while(dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " +dr[1];

            }
            bgl.baglantı().Close();
            
            // Randeu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTc="+ tc,bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //Branşları çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Brans", bgl.baglantı());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglantı().Close();
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            CmbDoktor.Text = " ";
            SqlCommand komut3 = new SqlCommand("Select DoktorAd, DoktorSoyad From Tbl_Doktorlar where DoktorBrans = @p1", bgl.baglantı());
            komut3.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0]+ " "+ dr3[1]);
            }
            bgl.baglantı().Close();    
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans = '" + cmbBrans.Text+ "'" +" and RandevuDoktor = '"+ CmbDoktor.Text + "' and RandevuDurum=0", bgl.baglantı());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void linkDüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDüzenle fr = new FrmBilgiDüzenle();
            fr.TCno = lblTc.Text;
            fr.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();    

        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Randevular Set RandevuDurum = 1, HastaTc = @p1, HastaSikayet=@p2 where Randevuid = @p3", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            komut.Parameters.AddWithValue("@p2", rchsikayet.Text);
            komut.Parameters.AddWithValue("@p3", txtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Randevu Alındı","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            lblTc.Text = " ";
            rchsikayet.Text = " ";
            txtId.Text = "";

        }
    }
}

namespace Hastane_Projesi
{
    partial class FrmSekreterDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richtxtDuyuru = new System.Windows.Forms.RichTextBox();
            this.BtnOluştur = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.checkBoxDurum = new System.Windows.Forms.CheckBox();
            this.maskedTC = new System.Windows.Forms.MaskedTextBox();
            this.combodoktor = new System.Windows.Forms.ComboBox();
            this.Combobrans = new System.Windows.Forms.ComboBox();
            this.maskedSaat = new System.Windows.Forms.MaskedTextBox();
            this.maskedTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DataBranşlar = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DataDoktorlar = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnduyuru = new System.Windows.Forms.Button();
            this.BtnRandevuListe = new System.Windows.Forms.Button();
            this.BtnBranşPanel = new System.Windows.Forms.Button();
            this.BtnDoktorPanel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBranşlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataDoktorlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblAdSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(110, 72);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(78, 23);
            this.LblAdSoyad.TabIndex = 3;
            this.LblAdSoyad.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(96, 28);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(120, 23);
            this.lblTC.TabIndex = 1;
            this.lblTC.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC NO:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richtxtDuyuru);
            this.groupBox2.Controls.Add(this.BtnOluştur);
            this.groupBox2.Location = new System.Drawing.Point(12, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // richtxtDuyuru
            // 
            this.richtxtDuyuru.Location = new System.Drawing.Point(10, 27);
            this.richtxtDuyuru.Name = "richtxtDuyuru";
            this.richtxtDuyuru.Size = new System.Drawing.Size(211, 152);
            this.richtxtDuyuru.TabIndex = 1;
            this.richtxtDuyuru.Text = "";
            // 
            // BtnOluştur
            // 
            this.BtnOluştur.Location = new System.Drawing.Point(10, 190);
            this.BtnOluştur.Name = "BtnOluştur";
            this.BtnOluştur.Size = new System.Drawing.Size(211, 33);
            this.BtnOluştur.TabIndex = 0;
            this.BtnOluştur.Text = "Oluştur";
            this.BtnOluştur.UseVisualStyleBackColor = true;
            this.BtnOluştur.Click += new System.EventHandler(this.BtnOluştur_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKaydet);
            this.groupBox3.Controls.Add(this.checkBoxDurum);
            this.groupBox3.Controls.Add(this.maskedTC);
            this.groupBox3.Controls.Add(this.combodoktor);
            this.groupBox3.Controls.Add(this.Combobrans);
            this.groupBox3.Controls.Add(this.maskedSaat);
            this.groupBox3.Controls.Add(this.maskedTarih);
            this.groupBox3.Controls.Add(this.txtID);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(245, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 357);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(43, 277);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(121, 37);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // checkBoxDurum
            // 
            this.checkBoxDurum.AutoSize = true;
            this.checkBoxDurum.Location = new System.Drawing.Point(83, 244);
            this.checkBoxDurum.Name = "checkBoxDurum";
            this.checkBoxDurum.Size = new System.Drawing.Size(81, 27);
            this.checkBoxDurum.TabIndex = 17;
            this.checkBoxDurum.Text = "Durum";
            this.checkBoxDurum.UseVisualStyleBackColor = true;
            // 
            // maskedTC
            // 
            this.maskedTC.Location = new System.Drawing.Point(82, 210);
            this.maskedTC.Mask = "00000000000";
            this.maskedTC.Name = "maskedTC";
            this.maskedTC.Size = new System.Drawing.Size(122, 28);
            this.maskedTC.TabIndex = 16;
            this.maskedTC.ValidatingType = typeof(System.DateTime);
            // 
            // combodoktor
            // 
            this.combodoktor.FormattingEnabled = true;
            this.combodoktor.Location = new System.Drawing.Point(83, 173);
            this.combodoktor.Name = "combodoktor";
            this.combodoktor.Size = new System.Drawing.Size(121, 31);
            this.combodoktor.TabIndex = 15;
            // 
            // Combobrans
            // 
            this.Combobrans.FormattingEnabled = true;
            this.Combobrans.Location = new System.Drawing.Point(83, 136);
            this.Combobrans.Name = "Combobrans";
            this.Combobrans.Size = new System.Drawing.Size(121, 31);
            this.Combobrans.TabIndex = 14;
            this.Combobrans.SelectedIndexChanged += new System.EventHandler(this.Combobrans_SelectedIndexChanged);
            // 
            // maskedSaat
            // 
            this.maskedSaat.Location = new System.Drawing.Point(83, 101);
            this.maskedSaat.Mask = "00:00";
            this.maskedSaat.Name = "maskedSaat";
            this.maskedSaat.Size = new System.Drawing.Size(122, 28);
            this.maskedSaat.TabIndex = 13;
            this.maskedSaat.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTarih
            // 
            this.maskedTarih.Location = new System.Drawing.Point(83, 65);
            this.maskedTarih.Mask = "00/00/0000";
            this.maskedTarih.Name = "maskedTarih";
            this.maskedTarih.Size = new System.Drawing.Size(122, 28);
            this.maskedTarih.TabIndex = 12;
            this.maskedTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(83, 32);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(122, 28);
            this.txtID.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "TC:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Doktor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Branş:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Saat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DataBranşlar);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(458, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(342, 210);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // DataBranşlar
            // 
            this.DataBranşlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataBranşlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBranşlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataBranşlar.Location = new System.Drawing.Point(3, 24);
            this.DataBranşlar.Name = "DataBranşlar";
            this.DataBranşlar.Size = new System.Drawing.Size(336, 183);
            this.DataBranşlar.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(336, 183);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DataDoktorlar);
            this.groupBox5.Controls.Add(this.dataGridView4);
            this.groupBox5.Location = new System.Drawing.Point(458, 216);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(342, 247);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // DataDoktorlar
            // 
            this.DataDoktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataDoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDoktorlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataDoktorlar.Location = new System.Drawing.Point(3, 24);
            this.DataDoktorlar.Name = "DataDoktorlar";
            this.DataDoktorlar.Size = new System.Drawing.Size(336, 220);
            this.DataDoktorlar.TabIndex = 1;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 24);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(336, 220);
            this.dataGridView4.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnduyuru);
            this.groupBox6.Controls.Add(this.BtnRandevuListe);
            this.groupBox6.Controls.Add(this.BtnBranşPanel);
            this.groupBox6.Controls.Add(this.BtnDoktorPanel);
            this.groupBox6.Location = new System.Drawing.Point(12, 363);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(446, 100);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // btnduyuru
            // 
            this.btnduyuru.Location = new System.Drawing.Point(339, 27);
            this.btnduyuru.Name = "btnduyuru";
            this.btnduyuru.Size = new System.Drawing.Size(102, 36);
            this.btnduyuru.TabIndex = 22;
            this.btnduyuru.Text = "Duyurular";
            this.btnduyuru.UseVisualStyleBackColor = true;
            this.btnduyuru.Click += new System.EventHandler(this.btnduyuru_Click);
            // 
            // BtnRandevuListe
            // 
            this.BtnRandevuListe.Location = new System.Drawing.Point(231, 27);
            this.BtnRandevuListe.Name = "BtnRandevuListe";
            this.BtnRandevuListe.Size = new System.Drawing.Size(102, 36);
            this.BtnRandevuListe.TabIndex = 21;
            this.BtnRandevuListe.Text = "Randevu";
            this.BtnRandevuListe.UseVisualStyleBackColor = true;
            this.BtnRandevuListe.Click += new System.EventHandler(this.BtnRandevuListe_Click);
            // 
            // BtnBranşPanel
            // 
            this.BtnBranşPanel.Location = new System.Drawing.Point(118, 27);
            this.BtnBranşPanel.Name = "BtnBranşPanel";
            this.BtnBranşPanel.Size = new System.Drawing.Size(107, 36);
            this.BtnBranşPanel.TabIndex = 20;
            this.BtnBranşPanel.Text = "Branş ";
            this.BtnBranşPanel.UseVisualStyleBackColor = true;
            this.BtnBranşPanel.Click += new System.EventHandler(this.BtnBranşPanel_Click);
            // 
            // BtnDoktorPanel
            // 
            this.BtnDoktorPanel.Location = new System.Drawing.Point(6, 27);
            this.BtnDoktorPanel.Name = "BtnDoktorPanel";
            this.BtnDoktorPanel.Size = new System.Drawing.Size(107, 36);
            this.BtnDoktorPanel.TabIndex = 19;
            this.BtnDoktorPanel.Text = "Doktor";
            this.BtnDoktorPanel.UseVisualStyleBackColor = true;
            this.BtnDoktorPanel.Click += new System.EventHandler(this.BtnDoktorPanel_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(812, 469);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSekreterDetay";
            this.Text = "FrmSekreterDetay";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataBranşlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataDoktorlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richtxtDuyuru;
        private System.Windows.Forms.Button BtnOluştur;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.CheckBox checkBoxDurum;
        private System.Windows.Forms.MaskedTextBox maskedTC;
        private System.Windows.Forms.ComboBox combodoktor;
        private System.Windows.Forms.ComboBox Combobrans;
        private System.Windows.Forms.MaskedTextBox maskedSaat;
        private System.Windows.Forms.MaskedTextBox maskedTarih;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DataBranşlar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView DataDoktorlar;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnRandevuListe;
        private System.Windows.Forms.Button BtnBranşPanel;
        private System.Windows.Forms.Button BtnDoktorPanel;
        private System.Windows.Forms.Button btnduyuru;
    }
}
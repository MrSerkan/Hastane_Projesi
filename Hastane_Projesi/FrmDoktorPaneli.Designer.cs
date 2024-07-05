namespace Hastane_Projesi
{
    partial class FrmDoktorPaneli
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorPaneli));
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTC = new System.Windows.Forms.MaskedTextBox();
            this.Combobrans = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doktorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorBransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDoktorlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneProjeDataSet1 = new Hastane_Projesi.HastaneProjeDataSet1();
            this.btnEkle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.hastaneProjeDataSet = new Hastane_Projesi.HastaneProjeDataSet();
            this.hastaneProjeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_DoktorlarTableAdapter = new Hastane_Projesi.HastaneProjeDataSet1TableAdapters.Tbl_DoktorlarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoktorlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad:";
            // 
            // maskedTC
            // 
            this.maskedTC.Location = new System.Drawing.Point(124, 117);
            this.maskedTC.Mask = "00000000000";
            this.maskedTC.Name = "maskedTC";
            this.maskedTC.Size = new System.Drawing.Size(122, 28);
            this.maskedTC.TabIndex = 4;
            this.maskedTC.ValidatingType = typeof(System.DateTime);
            // 
            // Combobrans
            // 
            this.Combobrans.FormattingEnabled = true;
            this.Combobrans.Location = new System.Drawing.Point(125, 80);
            this.Combobrans.Name = "Combobrans";
            this.Combobrans.Size = new System.Drawing.Size(121, 31);
            this.Combobrans.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(82, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "TC:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Branş:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(124, 12);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(122, 28);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(124, 46);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(122, 28);
            this.txtSoyad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Soyad:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(124, 151);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(122, 28);
            this.txtSifre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Şifre:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doktorIdDataGridViewTextBoxColumn,
            this.doktorAdDataGridViewTextBoxColumn,
            this.doktorSoyadDataGridViewTextBoxColumn,
            this.doktorBransDataGridViewTextBoxColumn,
            this.doktorTcDataGridViewTextBoxColumn,
            this.doktorSifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDoktorlarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(302, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(628, 255);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // doktorIdDataGridViewTextBoxColumn
            // 
            this.doktorIdDataGridViewTextBoxColumn.DataPropertyName = "DoktorId";
            this.doktorIdDataGridViewTextBoxColumn.HeaderText = "DoktorId";
            this.doktorIdDataGridViewTextBoxColumn.Name = "doktorIdDataGridViewTextBoxColumn";
            this.doktorIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doktorAdDataGridViewTextBoxColumn
            // 
            this.doktorAdDataGridViewTextBoxColumn.DataPropertyName = "DoktorAd";
            this.doktorAdDataGridViewTextBoxColumn.HeaderText = "DoktorAd";
            this.doktorAdDataGridViewTextBoxColumn.Name = "doktorAdDataGridViewTextBoxColumn";
            // 
            // doktorSoyadDataGridViewTextBoxColumn
            // 
            this.doktorSoyadDataGridViewTextBoxColumn.DataPropertyName = "DoktorSoyad";
            this.doktorSoyadDataGridViewTextBoxColumn.HeaderText = "DoktorSoyad";
            this.doktorSoyadDataGridViewTextBoxColumn.Name = "doktorSoyadDataGridViewTextBoxColumn";
            // 
            // doktorBransDataGridViewTextBoxColumn
            // 
            this.doktorBransDataGridViewTextBoxColumn.DataPropertyName = "DoktorBrans";
            this.doktorBransDataGridViewTextBoxColumn.HeaderText = "DoktorBrans";
            this.doktorBransDataGridViewTextBoxColumn.Name = "doktorBransDataGridViewTextBoxColumn";
            // 
            // doktorTcDataGridViewTextBoxColumn
            // 
            this.doktorTcDataGridViewTextBoxColumn.DataPropertyName = "DoktorTc";
            this.doktorTcDataGridViewTextBoxColumn.HeaderText = "DoktorTc";
            this.doktorTcDataGridViewTextBoxColumn.Name = "doktorTcDataGridViewTextBoxColumn";
            // 
            // doktorSifreDataGridViewTextBoxColumn
            // 
            this.doktorSifreDataGridViewTextBoxColumn.DataPropertyName = "DoktorSifre";
            this.doktorSifreDataGridViewTextBoxColumn.HeaderText = "DoktorSifre";
            this.doktorSifreDataGridViewTextBoxColumn.Name = "doktorSifreDataGridViewTextBoxColumn";
            // 
            // tblDoktorlarBindingSource
            // 
            this.tblDoktorlarBindingSource.DataMember = "Tbl_Doktorlar";
            this.tblDoktorlarBindingSource.DataSource = this.hastaneProjeDataSet1;
            // 
            // hastaneProjeDataSet1
            // 
            this.hastaneProjeDataSet1.DataSetName = "HastaneProjeDataSet1";
            this.hastaneProjeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Lime;
            this.btnEkle.Location = new System.Drawing.Point(121, 189);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(60, 36);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.Red;
            this.BtnSil.Location = new System.Drawing.Point(190, 189);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(60, 36);
            this.BtnSil.TabIndex = 7;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.Blue;
            this.btnGüncelle.Location = new System.Drawing.Point(124, 231);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(122, 36);
            this.btnGüncelle.TabIndex = 8;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(574, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Data Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // hastaneProjeDataSet
            // 
            this.hastaneProjeDataSet.DataSetName = "HastaneProjeDataSet";
            this.hastaneProjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaneProjeDataSetBindingSource
            // 
            this.hastaneProjeDataSetBindingSource.DataSource = this.hastaneProjeDataSet;
            this.hastaneProjeDataSetBindingSource.Position = 0;
            // 
            // tbl_DoktorlarTableAdapter
            // 
            this.tbl_DoktorlarTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(975, 292);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.maskedTC);
            this.Controls.Add(this.Combobrans);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorPaneli";
            this.Text = "FrmDoktorPaneli";
            this.Load += new System.EventHandler(this.FrmDoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoktorlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTC;
        private System.Windows.Forms.ComboBox Combobrans;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource hastaneProjeDataSetBindingSource;
        private HastaneProjeDataSet hastaneProjeDataSet;
        private HastaneProjeDataSet1 hastaneProjeDataSet1;
        private System.Windows.Forms.BindingSource tblDoktorlarBindingSource;
        private HastaneProjeDataSet1TableAdapters.Tbl_DoktorlarTableAdapter tbl_DoktorlarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorBransDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorSifreDataGridViewTextBoxColumn;
    }
}
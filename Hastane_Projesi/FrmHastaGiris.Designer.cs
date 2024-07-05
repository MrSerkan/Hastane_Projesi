namespace Hastane_Projesi
{
    partial class FrmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkÜyeol = new System.Windows.Forms.LinkLabel();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.btngiriş = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTc = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(163, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // linkÜyeol
            // 
            this.linkÜyeol.AutoSize = true;
            this.linkÜyeol.Location = new System.Drawing.Point(397, 209);
            this.linkÜyeol.Name = "linkÜyeol";
            this.linkÜyeol.Size = new System.Drawing.Size(58, 23);
            this.linkÜyeol.TabIndex = 3;
            this.linkÜyeol.TabStop = true;
            this.linkÜyeol.Text = "Üye Ol";
            this.linkÜyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkÜyeol_LinkClicked);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(234, 154);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(124, 28);
            this.txtsifre.TabIndex = 2;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // btngiriş
            // 
            this.btngiriş.Location = new System.Drawing.Point(252, 203);
            this.btngiriş.Name = "btngiriş";
            this.btngiriş.Size = new System.Drawing.Size(86, 35);
            this.btngiriş.TabIndex = 5;
            this.btngiriş.Text = "Giriş Yap";
            this.btngiriş.UseVisualStyleBackColor = true;
            this.btngiriş.Click += new System.EventHandler(this.btngiriş_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hasta Giriş Paneli";
            // 
            // maskedTc
            // 
            this.maskedTc.Location = new System.Drawing.Point(234, 108);
            this.maskedTc.Mask = "00000000000";
            this.maskedTc.Name = "maskedTc";
            this.maskedTc.Size = new System.Drawing.Size(124, 28);
            this.maskedTc.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sitka Subheading", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(365, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmHastaGiris
            // 
            this.AcceptButton = this.btngiriş;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(580, 264);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btngiriş);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.linkÜyeol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaGiris";
            this.Text = "Hasta Giriş";
            this.Load += new System.EventHandler(this.FrmHastaGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkÜyeol;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button btngiriş;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTc;
        private System.Windows.Forms.Button button1;
    }
}
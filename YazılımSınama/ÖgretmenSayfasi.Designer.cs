namespace YazılımSınama
{
    partial class ÖgretmenSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÖgretmenSayfasi));
            this.btnSoruEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSoruDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.rdbtnA = new System.Windows.Forms.RadioButton();
            this.rdbtnC = new System.Windows.Forms.RadioButton();
            this.rdbtnB = new System.Windows.Forms.RadioButton();
            this.rdbtnD = new System.Windows.Forms.RadioButton();
            this.btnGorselEkle = new DevExpress.XtraEditors.SimpleButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picGorselEkle = new System.Windows.Forms.PictureBox();
            this.cmBoxKategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxSoruEkle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGorselEkle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSoruEkle
            // 
            this.btnSoruEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSoruEkle.Appearance.Options.UseFont = true;
            this.btnSoruEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSoruEkle.ImageOptions.Image")));
            this.btnSoruEkle.Location = new System.Drawing.Point(643, 431);
            this.btnSoruEkle.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.btnSoruEkle.Name = "btnSoruEkle";
            this.btnSoruEkle.Size = new System.Drawing.Size(168, 48);
            this.btnSoruEkle.TabIndex = 0;
            this.btnSoruEkle.Text = "Soru Kaydet";
            this.btnSoruEkle.Click += new System.EventHandler(this.btnSoruEkle_Click);
            // 
            // btnSoruDuzenle
            // 
            this.btnSoruDuzenle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSoruDuzenle.Appearance.Options.UseFont = true;
            this.btnSoruDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSoruDuzenle.ImageOptions.Image")));
            this.btnSoruDuzenle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSoruDuzenle.Location = new System.Drawing.Point(34, 431);
            this.btnSoruDuzenle.Name = "btnSoruDuzenle";
            this.btnSoruDuzenle.Size = new System.Drawing.Size(186, 48);
            this.btnSoruDuzenle.TabIndex = 1;
            this.btnSoruDuzenle.Text = "  Soru Düzenle";
            this.btnSoruDuzenle.Click += new System.EventHandler(this.btnSoruDuzenle_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(34, 180);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(151, 39);
            this.txtA.TabIndex = 6;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(236, 180);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(151, 39);
            this.txtB.TabIndex = 7;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(34, 237);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(151, 39);
            this.txtC.TabIndex = 8;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(236, 237);
            this.txtD.Multiline = true;
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(151, 39);
            this.txtD.TabIndex = 9;
            // 
            // rdbtnA
            // 
            this.rdbtnA.AutoSize = true;
            this.rdbtnA.Location = new System.Drawing.Point(11, 192);
            this.rdbtnA.Name = "rdbtnA";
            this.rdbtnA.Size = new System.Drawing.Size(17, 16);
            this.rdbtnA.TabIndex = 10;
            this.rdbtnA.TabStop = true;
            this.rdbtnA.UseVisualStyleBackColor = true;
            // 
            // rdbtnC
            // 
            this.rdbtnC.AutoSize = true;
            this.rdbtnC.Location = new System.Drawing.Point(11, 251);
            this.rdbtnC.Name = "rdbtnC";
            this.rdbtnC.Size = new System.Drawing.Size(17, 16);
            this.rdbtnC.TabIndex = 11;
            this.rdbtnC.TabStop = true;
            this.rdbtnC.UseVisualStyleBackColor = true;
            // 
            // rdbtnB
            // 
            this.rdbtnB.AutoSize = true;
            this.rdbtnB.Location = new System.Drawing.Point(213, 192);
            this.rdbtnB.Name = "rdbtnB";
            this.rdbtnB.Size = new System.Drawing.Size(17, 16);
            this.rdbtnB.TabIndex = 12;
            this.rdbtnB.TabStop = true;
            this.rdbtnB.UseVisualStyleBackColor = true;
            // 
            // rdbtnD
            // 
            this.rdbtnD.AutoSize = true;
            this.rdbtnD.Location = new System.Drawing.Point(213, 251);
            this.rdbtnD.Name = "rdbtnD";
            this.rdbtnD.Size = new System.Drawing.Size(17, 16);
            this.rdbtnD.TabIndex = 13;
            this.rdbtnD.TabStop = true;
            this.rdbtnD.UseVisualStyleBackColor = true;
            // 
            // btnGorselEkle
            // 
            this.btnGorselEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGorselEkle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnGorselEkle.Appearance.Options.UseFont = true;
            this.btnGorselEkle.Appearance.Options.UseForeColor = true;
            this.btnGorselEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGorselEkle.ImageOptions.Image")));
            this.btnGorselEkle.Location = new System.Drawing.Point(496, 57);
            this.btnGorselEkle.Name = "btnGorselEkle";
            this.btnGorselEkle.Size = new System.Drawing.Size(149, 39);
            this.btnGorselEkle.TabIndex = 14;
            this.btnGorselEkle.Text = "Görsel Ekle";
            this.btnGorselEkle.Click += new System.EventHandler(this.btnGorselEkle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // picGorselEkle
            // 
            this.picGorselEkle.Location = new System.Drawing.Point(480, 114);
            this.picGorselEkle.Name = "picGorselEkle";
            this.picGorselEkle.Size = new System.Drawing.Size(202, 162);
            this.picGorselEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGorselEkle.TabIndex = 16;
            this.picGorselEkle.TabStop = false;
            // 
            // cmBoxKategori
            // 
            this.cmBoxKategori.FormattingEnabled = true;
            this.cmBoxKategori.Location = new System.Drawing.Point(704, 68);
            this.cmBoxKategori.Name = "cmBoxKategori";
            this.cmBoxKategori.Size = new System.Drawing.Size(121, 24);
            this.cmBoxKategori.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(721, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Kategoriler";
            // 
            // txtBoxSoruEkle
            // 
            this.txtBoxSoruEkle.Location = new System.Drawing.Point(11, 12);
            this.txtBoxSoruEkle.Multiline = true;
            this.txtBoxSoruEkle.Name = "txtBoxSoruEkle";
            this.txtBoxSoruEkle.Size = new System.Drawing.Size(389, 128);
            this.txtBoxSoruEkle.TabIndex = 19;
            // 
            // ÖgretmenSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(834, 512);
            this.Controls.Add(this.txtBoxSoruEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmBoxKategori);
            this.Controls.Add(this.picGorselEkle);
            this.Controls.Add(this.btnGorselEkle);
            this.Controls.Add(this.rdbtnD);
            this.Controls.Add(this.rdbtnB);
            this.Controls.Add(this.rdbtnC);
            this.Controls.Add(this.rdbtnA);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnSoruDuzenle);
            this.Controls.Add(this.btnSoruEkle);
            this.Name = "ÖgretmenSayfasi";
            this.Text = "OgretmenSayfasi";
            this.Load += new System.EventHandler(this.ÖgretmenSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGorselEkle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSoruEkle;
        private DevExpress.XtraEditors.SimpleButton btnSoruDuzenle;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.RadioButton rdbtnA;
        private System.Windows.Forms.RadioButton rdbtnC;
        private System.Windows.Forms.RadioButton rdbtnB;
        private System.Windows.Forms.RadioButton rdbtnD;
        private DevExpress.XtraEditors.SimpleButton btnGorselEkle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox picGorselEkle;
        private System.Windows.Forms.ComboBox cmBoxKategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxSoruEkle;
    }
}
namespace YazılımSınama
{
    partial class SoruDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoruDuzenle));
            this.DatagridSorular = new System.Windows.Forms.DataGridView();
            this.txtSoruDuzenle = new System.Windows.Forms.TextBox();
            this.picDuzenle = new System.Windows.Forms.PictureBox();
            this.txtSecenek1 = new System.Windows.Forms.TextBox();
            this.txtSecenek2 = new System.Windows.Forms.TextBox();
            this.txtSecenek3 = new System.Windows.Forms.TextBox();
            this.txtDogruSecenek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.SilGuncelleLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridSorular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDuzenle)).BeginInit();
            this.SuspendLayout();
            // 
            // DatagridSorular
            // 
            this.DatagridSorular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridSorular.Location = new System.Drawing.Point(12, 12);
            this.DatagridSorular.Name = "DatagridSorular";
            this.DatagridSorular.RowTemplate.Height = 24;
            this.DatagridSorular.Size = new System.Drawing.Size(459, 462);
            this.DatagridSorular.TabIndex = 0;
            this.DatagridSorular.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridSorular_CellContentClick);
            // 
            // txtSoruDuzenle
            // 
            this.txtSoruDuzenle.Location = new System.Drawing.Point(480, 12);
            this.txtSoruDuzenle.Multiline = true;
            this.txtSoruDuzenle.Name = "txtSoruDuzenle";
            this.txtSoruDuzenle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSoruDuzenle.Size = new System.Drawing.Size(318, 108);
            this.txtSoruDuzenle.TabIndex = 1;
            // 
            // picDuzenle
            // 
            this.picDuzenle.Location = new System.Drawing.Point(688, 201);
            this.picDuzenle.Name = "picDuzenle";
            this.picDuzenle.Size = new System.Drawing.Size(112, 108);
            this.picDuzenle.TabIndex = 2;
            this.picDuzenle.TabStop = false;
            // 
            // txtSecenek1
            // 
            this.txtSecenek1.Location = new System.Drawing.Point(480, 155);
            this.txtSecenek1.Multiline = true;
            this.txtSecenek1.Name = "txtSecenek1";
            this.txtSecenek1.Size = new System.Drawing.Size(165, 35);
            this.txtSecenek1.TabIndex = 3;
            // 
            // txtSecenek2
            // 
            this.txtSecenek2.Location = new System.Drawing.Point(480, 222);
            this.txtSecenek2.Multiline = true;
            this.txtSecenek2.Name = "txtSecenek2";
            this.txtSecenek2.Size = new System.Drawing.Size(165, 35);
            this.txtSecenek2.TabIndex = 4;
            // 
            // txtSecenek3
            // 
            this.txtSecenek3.Location = new System.Drawing.Point(480, 291);
            this.txtSecenek3.Multiline = true;
            this.txtSecenek3.Name = "txtSecenek3";
            this.txtSecenek3.Size = new System.Drawing.Size(165, 35);
            this.txtSecenek3.TabIndex = 5;
            // 
            // txtDogruSecenek
            // 
            this.txtDogruSecenek.Location = new System.Drawing.Point(480, 365);
            this.txtDogruSecenek.Multiline = true;
            this.txtDogruSecenek.Name = "txtDogruSecenek";
            this.txtDogruSecenek.Size = new System.Drawing.Size(165, 35);
            this.txtDogruSecenek.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(477, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seçenek 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(477, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seçenek 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(477, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Seçenek 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(477, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Doğru Seçenek";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(517, 421);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(119, 43);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(688, 421);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(112, 43);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // SilGuncelleLbl
            // 
            this.SilGuncelleLbl.AutoSize = true;
            this.SilGuncelleLbl.Location = new System.Drawing.Point(685, 368);
            this.SilGuncelleLbl.Name = "SilGuncelleLbl";
            this.SilGuncelleLbl.Size = new System.Drawing.Size(0, 17);
            this.SilGuncelleLbl.TabIndex = 13;
            this.SilGuncelleLbl.Visible = false;
            // 
            // SoruDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(812, 476);
            this.Controls.Add(this.SilGuncelleLbl);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDogruSecenek);
            this.Controls.Add(this.txtSecenek3);
            this.Controls.Add(this.txtSecenek2);
            this.Controls.Add(this.txtSecenek1);
            this.Controls.Add(this.picDuzenle);
            this.Controls.Add(this.txtSoruDuzenle);
            this.Controls.Add(this.DatagridSorular);
            this.Name = "SoruDuzenle";
            this.Text = "SoruDuzenle";
            this.Load += new System.EventHandler(this.SoruDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridSorular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDuzenle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DatagridSorular;
        private System.Windows.Forms.TextBox txtSoruDuzenle;
        private System.Windows.Forms.PictureBox picDuzenle;
        private System.Windows.Forms.TextBox txtSecenek1;
        private System.Windows.Forms.TextBox txtSecenek2;
        private System.Windows.Forms.TextBox txtSecenek3;
        private System.Windows.Forms.TextBox txtDogruSecenek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private System.Windows.Forms.Label SilGuncelleLbl;
    }
}
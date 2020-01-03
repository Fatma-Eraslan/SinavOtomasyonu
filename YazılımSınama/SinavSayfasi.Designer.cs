namespace YazılımSınama
{
    partial class SinavSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinavSayfasi));
            this.rdbtnA = new System.Windows.Forms.RadioButton();
            this.rdbtnB = new System.Windows.Forms.RadioButton();
            this.rdbtnC = new System.Windows.Forms.RadioButton();
            this.rdbtnD = new System.Windows.Forms.RadioButton();
            this.digitalBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.btnSonraki = new DevExpress.XtraEditors.SimpleButton();
            this.btnOnceki = new DevExpress.XtraEditors.SimpleButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.pBzamanlayici = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TxtSoru = new System.Windows.Forms.TextBox();
            this.soruResmiPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruResmiPic)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbtnA
            // 
            this.rdbtnA.AutoSize = true;
            this.rdbtnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnA.Location = new System.Drawing.Point(243, 175);
            this.rdbtnA.Name = "rdbtnA";
            this.rdbtnA.Size = new System.Drawing.Size(39, 22);
            this.rdbtnA.TabIndex = 0;
            this.rdbtnA.TabStop = true;
            this.rdbtnA.Text = "A";
            this.rdbtnA.UseVisualStyleBackColor = true;
            // 
            // rdbtnB
            // 
            this.rdbtnB.AutoSize = true;
            this.rdbtnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnB.Location = new System.Drawing.Point(423, 175);
            this.rdbtnB.Name = "rdbtnB";
            this.rdbtnB.Size = new System.Drawing.Size(40, 22);
            this.rdbtnB.TabIndex = 1;
            this.rdbtnB.TabStop = true;
            this.rdbtnB.Text = "B";
            this.rdbtnB.UseVisualStyleBackColor = true;
            // 
            // rdbtnC
            // 
            this.rdbtnC.AutoSize = true;
            this.rdbtnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnC.Location = new System.Drawing.Point(243, 252);
            this.rdbtnC.Name = "rdbtnC";
            this.rdbtnC.Size = new System.Drawing.Size(41, 22);
            this.rdbtnC.TabIndex = 2;
            this.rdbtnC.TabStop = true;
            this.rdbtnC.Text = "C";
            this.rdbtnC.UseVisualStyleBackColor = true;
            // 
            // rdbtnD
            // 
            this.rdbtnD.AutoSize = true;
            this.rdbtnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnD.Location = new System.Drawing.Point(423, 252);
            this.rdbtnD.Name = "rdbtnD";
            this.rdbtnD.Size = new System.Drawing.Size(41, 22);
            this.rdbtnD.TabIndex = 3;
            this.rdbtnD.TabStop = true;
            this.rdbtnD.Text = "D";
            this.rdbtnD.UseVisualStyleBackColor = true;
            // 
            // digitalBackgroundLayerComponent1
            // 
            this.digitalBackgroundLayerComponent1.Name = null;
            // 
            // btnSonraki
            // 
            this.btnSonraki.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSonraki.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnSonraki.Appearance.Options.UseFont = true;
            this.btnSonraki.Appearance.Options.UseForeColor = true;
            this.btnSonraki.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSonraki.ImageOptions.Image")));
            this.btnSonraki.Location = new System.Drawing.Point(605, 369);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(125, 35);
            this.btnSonraki.TabIndex = 6;
            this.btnSonraki.Text = "Sonraki";
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // btnOnceki
            // 
            this.btnOnceki.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnceki.Appearance.Options.UseFont = true;
            this.btnOnceki.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOnceki.ImageOptions.Image")));
            this.btnOnceki.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOnceki.Location = new System.Drawing.Point(51, 369);
            this.btnOnceki.Name = "btnOnceki";
            this.btnOnceki.Size = new System.Drawing.Size(124, 35);
            this.btnOnceki.TabIndex = 7;
            this.btnOnceki.Text = "Önceki";
            // 
            // pBzamanlayici
            // 
            this.pBzamanlayici.Location = new System.Drawing.Point(0, 0);
            this.pBzamanlayici.Maximum = 500;
            this.pBzamanlayici.Name = "pBzamanlayici";
            this.pBzamanlayici.Size = new System.Drawing.Size(777, 23);
            this.pBzamanlayici.Step = 1;
            this.pBzamanlayici.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TxtSoru
            // 
            this.TxtSoru.Location = new System.Drawing.Point(218, 49);
            this.TxtSoru.Multiline = true;
            this.TxtSoru.Name = "TxtSoru";
            this.TxtSoru.Size = new System.Drawing.Size(275, 107);
            this.TxtSoru.TabIndex = 10;
            // 
            // soruResmiPic
            // 
            this.soruResmiPic.Location = new System.Drawing.Point(555, 49);
            this.soruResmiPic.Name = "soruResmiPic";
            this.soruResmiPic.Size = new System.Drawing.Size(141, 107);
            this.soruResmiPic.TabIndex = 11;
            this.soruResmiPic.TabStop = false;
            // 
            // SinavSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.soruResmiPic);
            this.Controls.Add(this.TxtSoru);
            this.Controls.Add(this.pBzamanlayici);
            this.Controls.Add(this.btnOnceki);
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.rdbtnD);
            this.Controls.Add(this.rdbtnC);
            this.Controls.Add(this.rdbtnB);
            this.Controls.Add(this.rdbtnA);
            this.Name = "SinavSayfasi";
            this.Text = "SinavSayfasi";
            this.Load += new System.EventHandler(this.SinavSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruResmiPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtnA;
        private System.Windows.Forms.RadioButton rdbtnB;
        private System.Windows.Forms.RadioButton rdbtnC;
        private System.Windows.Forms.RadioButton rdbtnD;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent1;
        private DevExpress.XtraEditors.SimpleButton btnSonraki;
        private DevExpress.XtraEditors.SimpleButton btnOnceki;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ProgressBar pBzamanlayici;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TxtSoru;
        private System.Windows.Forms.PictureBox soruResmiPic;
    }
}
namespace odevtakipuygulaması
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ogrenciler = new ListBox();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNo = new TextBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            label7 = new Label();
            CBhayır = new CheckBox();
            CBevet = new CheckBox();
            label8 = new Label();
            txtKonu = new TextBox();
            label9 = new Label();
            txtPuan = new TextBox();
            label10 = new Label();
            txtDers = new TextBox();
            btnKaydet = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            btnYeni = new Button();
            cbSınıf = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(739, 79);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(227, 0);
            label1.Name = "label1";
            label1.Size = new Size(344, 79);
            label1.TabIndex = 1;
            label1.Text = "ÖĞRENCİ TAKİP UYGULAMASI";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.open_enrollment;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ogrenciler
            // 
            ogrenciler.FormattingEnabled = true;
            ogrenciler.ItemHeight = 15;
            ogrenciler.Location = new Point(0, 52);
            ogrenciler.Name = "ogrenciler";
            ogrenciler.Size = new Size(208, 484);
            ogrenciler.TabIndex = 1;
            ogrenciler.SelectedIndexChanged += ogrenciler_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(ogrenciler);
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 533);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(-7, 13);
            label2.Name = "label2";
            label2.Size = new Size(215, 36);
            label2.TabIndex = 3;
            label2.Text = "ÖĞRENCİ LİSTESİ";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(262, 155);
            label3.Name = "label3";
            label3.Size = new Size(46, 23);
            label3.TabIndex = 3;
            label3.Text = "ADI";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(250, 224);
            label4.Name = "label4";
            label4.Size = new Size(81, 23);
            label4.TabIndex = 3;
            label4.Text = "SINIF";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(262, 118);
            label5.Name = "label5";
            label5.Size = new Size(46, 23);
            label5.TabIndex = 3;
            label5.Text = "NO";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(227, 191);
            label6.Name = "label6";
            label6.Size = new Size(81, 23);
            label6.TabIndex = 3;
            label6.Text = "SOYADI";
            label6.Click += label4_Click;
            // 
            // txtNo
            // 
            txtNo.Location = new Point(323, 118);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(184, 23);
            txtNo.TabIndex = 4;
            txtNo.Text = "d";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(323, 155);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(184, 23);
            txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(323, 191);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(184, 23);
            txtSoyad.TabIndex = 4;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(551, 102);
            label7.Name = "label7";
            label7.Size = new Size(162, 23);
            label7.TabIndex = 3;
            label7.Text = "ÖDEV YAPILDIMI";
            // 
            // CBhayır
            // 
            CBhayır.AutoSize = true;
            CBhayır.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CBhayır.Location = new Point(640, 155);
            CBhayır.Name = "CBhayır";
            CBhayır.Size = new Size(86, 29);
            CBhayır.TabIndex = 5;
            CBhayır.Text = "HAYIR";
            CBhayır.UseVisualStyleBackColor = true;
            // 
            // CBevet
            // 
            CBevet.AutoSize = true;
            CBevet.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CBevet.Location = new Point(533, 155);
            CBevet.Name = "CBevet";
            CBevet.Size = new Size(73, 29);
            CBevet.TabIndex = 5;
            CBevet.Text = "EVET";
            CBevet.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(214, 279);
            label8.Name = "label8";
            label8.Size = new Size(152, 23);
            label8.TabIndex = 3;
            label8.Text = "ÖDEV KONUSU";
            label8.Click += label4_Click;
            // 
            // txtKonu
            // 
            txtKonu.Location = new Point(372, 279);
            txtKonu.Multiline = true;
            txtKonu.Name = "txtKonu";
            txtKonu.Size = new Size(304, 82);
            txtKonu.TabIndex = 4;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(227, 374);
            label9.Name = "label9";
            label9.Size = new Size(152, 23);
            label9.TabIndex = 3;
            label9.Text = "ÖDEV POİNT";
            label9.Click += label4_Click;
            // 
            // txtPuan
            // 
            txtPuan.Location = new Point(361, 374);
            txtPuan.Name = "txtPuan";
            txtPuan.Size = new Size(75, 23);
            txtPuan.TabIndex = 4;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(284, 417);
            label10.Name = "label10";
            label10.Size = new Size(152, 23);
            label10.TabIndex = 3;
            label10.Text = "DERS";
            label10.Click += label4_Click;
            // 
            // txtDers
            // 
            txtDers.Location = new Point(361, 417);
            txtDers.Multiline = true;
            txtDers.Name = "txtDers";
            txtDers.Size = new Size(225, 42);
            txtDers.TabIndex = 4;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Teal;
            btnKaydet.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.Location = new Point(454, 507);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 41);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(192, 0, 0);
            btnSil.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Location = new Point(551, 507);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 41);
            btnSil.TabIndex = 6;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(0, 192, 0);
            btnEkle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Location = new Point(286, 506);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(150, 41);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "EKLE/GÜNCELLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnYeni
            // 
            btnYeni.BackColor = Color.FromArgb(128, 255, 255);
            btnYeni.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnYeni.Location = new Point(640, 507);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(75, 41);
            btnYeni.TabIndex = 6;
            btnYeni.Text = "YENİ";
            btnYeni.UseVisualStyleBackColor = false;
            btnYeni.Click += btnYeni_Click;
            // 
            // cbSınıf
            // 
            cbSınıf.FormattingEnabled = true;
            cbSınıf.Location = new Point(328, 230);
            cbSınıf.Name = "cbSınıf";
            cbSınıf.Size = new Size(124, 23);
            cbSınıf.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(739, 604);
            Controls.Add(cbSınıf);
            Controls.Add(btnYeni);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(btnKaydet);
            Controls.Add(CBevet);
            Controls.Add(CBhayır);
            Controls.Add(txtKonu);
            Controls.Add(txtDers);
            Controls.Add(txtPuan);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(txtNo);
            Controls.Add(label6);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private ListBox ogrenciler;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNo;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Label label7;
        private CheckBox CBhayır;
        private CheckBox CBevet;
        private Label label8;
        private TextBox txtKonu;
        private Label label9;
        private TextBox txtPuan;
        private Label label10;
        private TextBox txtDers;
        private Button btnKaydet;
        private Button btnSil;
        private Button btnEkle;
        private Button btnYeni;
        private ComboBox cbSınıf;
    }
}
namespace teknık_otomasyon
{
    partial class FrmAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnasayfa));
            this.PnlUst = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblKullaniciAdi = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCihaz = new System.Windows.Forms.Panel();
            this.pnlCari = new System.Windows.Forms.Panel();
            this.pnlPersonel = new System.Windows.Forms.Panel();
            this.pnlSistem = new System.Windows.Forms.Panel();
            this.BtnYetkiIslemleri = new System.Windows.Forms.Button();
            this.BtnYedekParcaIslemleri = new System.Windows.Forms.Button();
            this.BtnYedekParcaKategori = new System.Windows.Forms.Button();
            this.StnCihazIslemleri = new System.Windows.Forms.Button();
            this.StnModelIslemleri = new System.Windows.Forms.Button();
            this.StmMarkaIslemleri = new System.Windows.Forms.Button();
            this.PnlMarkaIslemleri = new System.Windows.Forms.Panel();
            this.BtnMarkaSil = new System.Windows.Forms.Button();
            this.BtnYeniMarka = new System.Windows.Forms.Button();
            this.LblMarkaIslemleri = new System.Windows.Forms.Label();
            this.LblMarkaIslemleriMarkaId = new System.Windows.Forms.Label();
            this.BtnMarkaGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMarkaIslemleriMarkaAdi = new System.Windows.Forms.TextBox();
            this.LstMarkaIslemleriMarkalar = new System.Windows.Forms.ListBox();
            this.PnlModelIslemleri = new System.Windows.Forms.Panel();
            this.PnlSistemCihazIslemleri = new System.Windows.Forms.Panel();
            this.PnlYedekParcaKategori = new System.Windows.Forms.Panel();
            this.PnlYedekParcaIslemleri = new System.Windows.Forms.Panel();
            this.PnlYetkiIslemleri = new System.Windows.Forms.Panel();
            this.PnlUst.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSistem.SuspendLayout();
            this.PnlMarkaIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlUst
            // 
            this.PnlUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.PnlUst.Controls.Add(this.button1);
            this.PnlUst.Controls.Add(this.button2);
            this.PnlUst.Controls.Add(this.button3);
            this.PnlUst.Controls.Add(this.button4);
            this.PnlUst.Controls.Add(this.button5);
            this.PnlUst.Controls.Add(this.panel2);
            this.PnlUst.Controls.Add(this.panel1);
            this.PnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlUst.Location = new System.Drawing.Point(0, 0);
            this.PnlUst.Name = "PnlUst";
            this.PnlUst.Size = new System.Drawing.Size(1289, 90);
            this.PnlUst.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button1.ForeColor = System.Drawing.Color.Tomato;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 90);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cıhaz İşlemler";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "device.png");
            this.ımageList1.Images.SetKeyName(1, "exit.png");
            this.ımageList1.Images.SetKeyName(2, "group.png");
            this.ımageList1.Images.SetKeyName(3, "icons8-add-administrator-50.png");
            this.ımageList1.Images.SetKeyName(4, "icons8-bin-50.png");
            this.ımageList1.Images.SetKeyName(5, "icons8-delete-file-50.png");
            this.ımageList1.Images.SetKeyName(6, "icons8-delete-user-50.png");
            this.ımageList1.Images.SetKeyName(7, "icons8-user-50.png");
            this.ımageList1.Images.SetKeyName(8, "insert.png");
            this.ımageList1.Images.SetKeyName(9, "money.png");
            this.ımageList1.Images.SetKeyName(10, "regeneration.png");
            this.ımageList1.Images.SetKeyName(11, "renewal.png");
            this.ımageList1.Images.SetKeyName(12, "setting.png");
            this.ımageList1.Images.SetKeyName(13, "update.png");
            this.ımageList1.Images.SetKeyName(14, "user.png");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button2.ForeColor = System.Drawing.Color.Tomato;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 9;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(219, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 90);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cari İşlemler";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button3.ForeColor = System.Drawing.Color.Tomato;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 2;
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(435, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 90);
            this.button3.TabIndex = 4;
            this.button3.Text = "Personel İşlemleri";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button4.ForeColor = System.Drawing.Color.Tomato;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageIndex = 12;
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(651, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(210, 90);
            this.button4.TabIndex = 5;
            this.button4.Text = "Sistem Ayarları";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button5.ForeColor = System.Drawing.Color.Tomato;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.ImageIndex = 1;
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(867, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(210, 90);
            this.button5.TabIndex = 6;
            this.button5.Text = "Çıkış Yap";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LblKullaniciAdi);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(1083, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 87);
            this.panel2.TabIndex = 2;
            // 
            // LblKullaniciAdi
            // 
            this.LblKullaniciAdi.ActiveLinkColor = System.Drawing.Color.Tomato;
            this.LblKullaniciAdi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKullaniciAdi.LinkColor = System.Drawing.Color.Tomato;
            this.LblKullaniciAdi.Location = new System.Drawing.Point(88, 0);
            this.LblKullaniciAdi.Name = "LblKullaniciAdi";
            this.LblKullaniciAdi.Size = new System.Drawing.Size(106, 82);
            this.LblKullaniciAdi.TabIndex = 2;
            this.LblKullaniciAdi.TabStop = true;
            this.LblKullaniciAdi.Text = "....";
            this.LblKullaniciAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 7;
            // 
            // pnlCihaz
            // 
            this.pnlCihaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlCihaz.Location = new System.Drawing.Point(0, 87);
            this.pnlCihaz.Name = "pnlCihaz";
            this.pnlCihaz.Size = new System.Drawing.Size(1286, 80);
            this.pnlCihaz.TabIndex = 2;
            // 
            // pnlCari
            // 
            this.pnlCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlCari.Location = new System.Drawing.Point(0, 87);
            this.pnlCari.Name = "pnlCari";
            this.pnlCari.Size = new System.Drawing.Size(1286, 80);
            this.pnlCari.TabIndex = 3;
            // 
            // pnlPersonel
            // 
            this.pnlPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlPersonel.Location = new System.Drawing.Point(0, 87);
            this.pnlPersonel.Name = "pnlPersonel";
            this.pnlPersonel.Size = new System.Drawing.Size(1286, 80);
            this.pnlPersonel.TabIndex = 4;
            // 
            // pnlSistem
            // 
            this.pnlSistem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlSistem.Controls.Add(this.BtnYetkiIslemleri);
            this.pnlSistem.Controls.Add(this.BtnYedekParcaIslemleri);
            this.pnlSistem.Controls.Add(this.BtnYedekParcaKategori);
            this.pnlSistem.Controls.Add(this.StnCihazIslemleri);
            this.pnlSistem.Controls.Add(this.StnModelIslemleri);
            this.pnlSistem.Controls.Add(this.StmMarkaIslemleri);
            this.pnlSistem.Location = new System.Drawing.Point(0, 87);
            this.pnlSistem.Name = "pnlSistem";
            this.pnlSistem.Size = new System.Drawing.Size(1286, 80);
            this.pnlSistem.TabIndex = 5;
            // 
            // BtnYetkiIslemleri
            // 
            this.BtnYetkiIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnYetkiIslemleri.FlatAppearance.BorderSize = 0;
            this.BtnYetkiIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnYetkiIslemleri.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnYetkiIslemleri.ForeColor = System.Drawing.Color.Tomato;
            this.BtnYetkiIslemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnYetkiIslemleri.ImageIndex = 12;
            this.BtnYetkiIslemleri.ImageList = this.ımageList1;
            this.BtnYetkiIslemleri.Location = new System.Drawing.Point(1076, 0);
            this.BtnYetkiIslemleri.Name = "BtnYetkiIslemleri";
            this.BtnYetkiIslemleri.Size = new System.Drawing.Size(210, 77);
            this.BtnYetkiIslemleri.TabIndex = 11;
            this.BtnYetkiIslemleri.Text = "yetki islemleri";
            this.BtnYetkiIslemleri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnYetkiIslemleri.UseVisualStyleBackColor = false;
            this.BtnYetkiIslemleri.Click += new System.EventHandler(this.BtnYetkiIslemleri_Click);
            // 
            // BtnYedekParcaIslemleri
            // 
            this.BtnYedekParcaIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnYedekParcaIslemleri.FlatAppearance.BorderSize = 0;
            this.BtnYedekParcaIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnYedekParcaIslemleri.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnYedekParcaIslemleri.ForeColor = System.Drawing.Color.Tomato;
            this.BtnYedekParcaIslemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnYedekParcaIslemleri.ImageIndex = 12;
            this.BtnYedekParcaIslemleri.ImageList = this.ımageList1;
            this.BtnYedekParcaIslemleri.Location = new System.Drawing.Point(867, 0);
            this.BtnYedekParcaIslemleri.Name = "BtnYedekParcaIslemleri";
            this.BtnYedekParcaIslemleri.Size = new System.Drawing.Size(210, 77);
            this.BtnYedekParcaIslemleri.TabIndex = 10;
            this.BtnYedekParcaIslemleri.Text = "yedek parca islemleri";
            this.BtnYedekParcaIslemleri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnYedekParcaIslemleri.UseVisualStyleBackColor = false;
            this.BtnYedekParcaIslemleri.Click += new System.EventHandler(this.BtnYedekParcaIslemleri_Click);
            // 
            // BtnYedekParcaKategori
            // 
            this.BtnYedekParcaKategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnYedekParcaKategori.FlatAppearance.BorderSize = 0;
            this.BtnYedekParcaKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnYedekParcaKategori.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnYedekParcaKategori.ForeColor = System.Drawing.Color.Tomato;
            this.BtnYedekParcaKategori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnYedekParcaKategori.ImageIndex = 12;
            this.BtnYedekParcaKategori.ImageList = this.ımageList1;
            this.BtnYedekParcaKategori.Location = new System.Drawing.Point(651, 0);
            this.BtnYedekParcaKategori.Name = "BtnYedekParcaKategori";
            this.BtnYedekParcaKategori.Size = new System.Drawing.Size(210, 77);
            this.BtnYedekParcaKategori.TabIndex = 9;
            this.BtnYedekParcaKategori.Text = "yedek parca kategori";
            this.BtnYedekParcaKategori.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnYedekParcaKategori.UseVisualStyleBackColor = false;
            this.BtnYedekParcaKategori.Click += new System.EventHandler(this.BtnYedekParcaKategori_Click);
            // 
            // StnCihazIslemleri
            // 
            this.StnCihazIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StnCihazIslemleri.FlatAppearance.BorderSize = 0;
            this.StnCihazIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StnCihazIslemleri.Font = new System.Drawing.Font("Tahoma", 10F);
            this.StnCihazIslemleri.ForeColor = System.Drawing.Color.Tomato;
            this.StnCihazIslemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StnCihazIslemleri.ImageIndex = 12;
            this.StnCihazIslemleri.ImageList = this.ımageList1;
            this.StnCihazIslemleri.Location = new System.Drawing.Point(432, 0);
            this.StnCihazIslemleri.Name = "StnCihazIslemleri";
            this.StnCihazIslemleri.Size = new System.Drawing.Size(210, 77);
            this.StnCihazIslemleri.TabIndex = 8;
            this.StnCihazIslemleri.Text = "cihaz iSlemleri";
            this.StnCihazIslemleri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StnCihazIslemleri.UseVisualStyleBackColor = false;
            this.StnCihazIslemleri.Click += new System.EventHandler(this.StnCihazIslemleri_Click);
            // 
            // StnModelIslemleri
            // 
            this.StnModelIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StnModelIslemleri.FlatAppearance.BorderSize = 0;
            this.StnModelIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StnModelIslemleri.Font = new System.Drawing.Font("Tahoma", 10F);
            this.StnModelIslemleri.ForeColor = System.Drawing.Color.Tomato;
            this.StnModelIslemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StnModelIslemleri.ImageIndex = 12;
            this.StnModelIslemleri.ImageList = this.ımageList1;
            this.StnModelIslemleri.Location = new System.Drawing.Point(216, 0);
            this.StnModelIslemleri.Name = "StnModelIslemleri";
            this.StnModelIslemleri.Size = new System.Drawing.Size(210, 77);
            this.StnModelIslemleri.TabIndex = 7;
            this.StnModelIslemleri.Text = "model iSlemleri";
            this.StnModelIslemleri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StnModelIslemleri.UseVisualStyleBackColor = false;
            this.StnModelIslemleri.Click += new System.EventHandler(this.StnModelIslemleri_Click);
            // 
            // StmMarkaIslemleri
            // 
            this.StmMarkaIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StmMarkaIslemleri.FlatAppearance.BorderSize = 0;
            this.StmMarkaIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StmMarkaIslemleri.Font = new System.Drawing.Font("Tahoma", 10F);
            this.StmMarkaIslemleri.ForeColor = System.Drawing.Color.Tomato;
            this.StmMarkaIslemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StmMarkaIslemleri.ImageIndex = 12;
            this.StmMarkaIslemleri.ImageList = this.ımageList1;
            this.StmMarkaIslemleri.Location = new System.Drawing.Point(0, 0);
            this.StmMarkaIslemleri.Name = "StmMarkaIslemleri";
            this.StmMarkaIslemleri.Size = new System.Drawing.Size(210, 77);
            this.StmMarkaIslemleri.TabIndex = 6;
            this.StmMarkaIslemleri.Text = "Marka iSlemleri";
            this.StmMarkaIslemleri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StmMarkaIslemleri.UseVisualStyleBackColor = false;
            this.StmMarkaIslemleri.Click += new System.EventHandler(this.StmMarkaIslemleri_Click);
            // 
            // PnlMarkaIslemleri
            // 
            this.PnlMarkaIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.PnlMarkaIslemleri.Controls.Add(this.BtnMarkaSil);
            this.PnlMarkaIslemleri.Controls.Add(this.BtnYeniMarka);
            this.PnlMarkaIslemleri.Controls.Add(this.LblMarkaIslemleri);
            this.PnlMarkaIslemleri.Controls.Add(this.LblMarkaIslemleriMarkaId);
            this.PnlMarkaIslemleri.Controls.Add(this.BtnMarkaGuncelle);
            this.PnlMarkaIslemleri.Controls.Add(this.label1);
            this.PnlMarkaIslemleri.Controls.Add(this.TxtMarkaIslemleriMarkaAdi);
            this.PnlMarkaIslemleri.Controls.Add(this.LstMarkaIslemleriMarkalar);
            this.PnlMarkaIslemleri.Location = new System.Drawing.Point(0, 168);
            this.PnlMarkaIslemleri.Name = "PnlMarkaIslemleri";
            this.PnlMarkaIslemleri.Size = new System.Drawing.Size(1289, 419);
            this.PnlMarkaIslemleri.TabIndex = 6;
            // 
            // BtnMarkaSil
            // 
            this.BtnMarkaSil.BackColor = System.Drawing.Color.Red;
            this.BtnMarkaSil.FlatAppearance.BorderSize = 0;
            this.BtnMarkaSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMarkaSil.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnMarkaSil.ForeColor = System.Drawing.Color.White;
            this.BtnMarkaSil.Location = new System.Drawing.Point(619, 338);
            this.BtnMarkaSil.Name = "BtnMarkaSil";
            this.BtnMarkaSil.Size = new System.Drawing.Size(137, 42);
            this.BtnMarkaSil.TabIndex = 7;
            this.BtnMarkaSil.Text = "Marka Sil";
            this.BtnMarkaSil.UseVisualStyleBackColor = false;
            this.BtnMarkaSil.Click += new System.EventHandler(this.BtnMarkaSil_Click);
            // 
            // BtnYeniMarka
            // 
            this.BtnYeniMarka.BackColor = System.Drawing.Color.Teal;
            this.BtnYeniMarka.FlatAppearance.BorderSize = 0;
            this.BtnYeniMarka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnYeniMarka.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnYeniMarka.ForeColor = System.Drawing.Color.White;
            this.BtnYeniMarka.Location = new System.Drawing.Point(464, 338);
            this.BtnYeniMarka.Name = "BtnYeniMarka";
            this.BtnYeniMarka.Size = new System.Drawing.Size(137, 42);
            this.BtnYeniMarka.TabIndex = 6;
            this.BtnYeniMarka.Text = "yeni marka";
            this.BtnYeniMarka.UseVisualStyleBackColor = false;
            // 
            // LblMarkaIslemleri
            // 
            this.LblMarkaIslemleri.AutoSize = true;
            this.LblMarkaIslemleri.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMarkaIslemleri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblMarkaIslemleri.Location = new System.Drawing.Point(456, 40);
            this.LblMarkaIslemleri.Name = "LblMarkaIslemleri";
            this.LblMarkaIslemleri.Size = new System.Drawing.Size(0, 21);
            this.LblMarkaIslemleri.TabIndex = 5;
            // 
            // LblMarkaIslemleriMarkaId
            // 
            this.LblMarkaIslemleriMarkaId.AutoSize = true;
            this.LblMarkaIslemleriMarkaId.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMarkaIslemleriMarkaId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblMarkaIslemleriMarkaId.Location = new System.Drawing.Point(320, 40);
            this.LblMarkaIslemleriMarkaId.Name = "LblMarkaIslemleriMarkaId";
            this.LblMarkaIslemleriMarkaId.Size = new System.Drawing.Size(84, 21);
            this.LblMarkaIslemleriMarkaId.TabIndex = 4;
            this.LblMarkaIslemleriMarkaId.Text = "Marka ID:";
            // 
            // BtnMarkaGuncelle
            // 
            this.BtnMarkaGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnMarkaGuncelle.FlatAppearance.BorderSize = 0;
            this.BtnMarkaGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMarkaGuncelle.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnMarkaGuncelle.Location = new System.Drawing.Point(308, 338);
            this.BtnMarkaGuncelle.Name = "BtnMarkaGuncelle";
            this.BtnMarkaGuncelle.Size = new System.Drawing.Size(137, 42);
            this.BtnMarkaGuncelle.TabIndex = 3;
            this.BtnMarkaGuncelle.Text = "Marka Guncelle";
            this.BtnMarkaGuncelle.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(320, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marka Adi:";
            // 
            // TxtMarkaIslemleriMarkaAdi
            // 
            this.TxtMarkaIslemleriMarkaAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtMarkaIslemleriMarkaAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMarkaIslemleriMarkaAdi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMarkaIslemleriMarkaAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtMarkaIslemleriMarkaAdi.Location = new System.Drawing.Point(453, 89);
            this.TxtMarkaIslemleriMarkaAdi.Multiline = true;
            this.TxtMarkaIslemleriMarkaAdi.Name = "TxtMarkaIslemleriMarkaAdi";
            this.TxtMarkaIslemleriMarkaAdi.Size = new System.Drawing.Size(220, 35);
            this.TxtMarkaIslemleriMarkaAdi.TabIndex = 1;
            this.TxtMarkaIslemleriMarkaAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LstMarkaIslemleriMarkalar
            // 
            this.LstMarkaIslemleriMarkalar.FormattingEnabled = true;
            this.LstMarkaIslemleriMarkalar.ItemHeight = 16;
            this.LstMarkaIslemleriMarkalar.Location = new System.Drawing.Point(12, 40);
            this.LstMarkaIslemleriMarkalar.Name = "LstMarkaIslemleriMarkalar";
            this.LstMarkaIslemleriMarkalar.Size = new System.Drawing.Size(270, 340);
            this.LstMarkaIslemleriMarkalar.TabIndex = 0;
            this.LstMarkaIslemleriMarkalar.SelectedIndexChanged += new System.EventHandler(this.LstMarkaIslemleriMarkalar_SelectedIndexChanged);
            this.LstMarkaIslemleriMarkalar.DoubleClick += new System.EventHandler(this.LstMarkaIslemleriMarkalar_DoubleClick);
            // 
            // PnlModelIslemleri
            // 
            this.PnlModelIslemleri.BackColor = System.Drawing.Color.Maroon;
            this.PnlModelIslemleri.Location = new System.Drawing.Point(0, 168);
            this.PnlModelIslemleri.Name = "PnlModelIslemleri";
            this.PnlModelIslemleri.Size = new System.Drawing.Size(1289, 419);
            this.PnlModelIslemleri.TabIndex = 7;
            // 
            // PnlSistemCihazIslemleri
            // 
            this.PnlSistemCihazIslemleri.BackColor = System.Drawing.Color.Olive;
            this.PnlSistemCihazIslemleri.Location = new System.Drawing.Point(0, 168);
            this.PnlSistemCihazIslemleri.Name = "PnlSistemCihazIslemleri";
            this.PnlSistemCihazIslemleri.Size = new System.Drawing.Size(1289, 416);
            this.PnlSistemCihazIslemleri.TabIndex = 8;
            // 
            // PnlYedekParcaKategori
            // 
            this.PnlYedekParcaKategori.BackColor = System.Drawing.Color.Gold;
            this.PnlYedekParcaKategori.Location = new System.Drawing.Point(0, 168);
            this.PnlYedekParcaKategori.Name = "PnlYedekParcaKategori";
            this.PnlYedekParcaKategori.Size = new System.Drawing.Size(1289, 416);
            this.PnlYedekParcaKategori.TabIndex = 9;
            // 
            // PnlYedekParcaIslemleri
            // 
            this.PnlYedekParcaIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PnlYedekParcaIslemleri.Location = new System.Drawing.Point(0, 168);
            this.PnlYedekParcaIslemleri.Name = "PnlYedekParcaIslemleri";
            this.PnlYedekParcaIslemleri.Size = new System.Drawing.Size(1289, 416);
            this.PnlYedekParcaIslemleri.TabIndex = 10;
            // 
            // PnlYetkiIslemleri
            // 
            this.PnlYetkiIslemleri.BackColor = System.Drawing.Color.Khaki;
            this.PnlYetkiIslemleri.Location = new System.Drawing.Point(0, 168);
            this.PnlYetkiIslemleri.Name = "PnlYetkiIslemleri";
            this.PnlYetkiIslemleri.Size = new System.Drawing.Size(1289, 416);
            this.PnlYetkiIslemleri.TabIndex = 11;
            // 
            // FrmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1289, 614);
            this.Controls.Add(this.PnlMarkaIslemleri);
            this.Controls.Add(this.PnlModelIslemleri);
            this.Controls.Add(this.PnlYetkiIslemleri);
            this.Controls.Add(this.PnlYedekParcaIslemleri);
            this.Controls.Add(this.PnlYedekParcaKategori);
            this.Controls.Add(this.PnlSistemCihazIslemleri);
            this.Controls.Add(this.pnlSistem);
            this.Controls.Add(this.pnlPersonel);
            this.Controls.Add(this.pnlCari);
            this.Controls.Add(this.pnlCihaz);
            this.Controls.Add(this.PnlUst);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TEKNIK SERVIS ANASAYFA";
            this.Load += new System.EventHandler(this.FrmAnasayfa_Load);
            this.PnlUst.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSistem.ResumeLayout(false);
            this.PnlMarkaIslemleri.ResumeLayout(false);
            this.PnlMarkaIslemleri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PnlUst;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlCihaz;
        private System.Windows.Forms.Panel pnlCari;
        private System.Windows.Forms.Panel pnlPersonel;
        private System.Windows.Forms.Panel pnlSistem;
        public System.Windows.Forms.LinkLabel LblKullaniciAdi;
        private System.Windows.Forms.Button StmMarkaIslemleri;
        private System.Windows.Forms.Button BtnYedekParcaKategori;
        private System.Windows.Forms.Button StnCihazIslemleri;
        private System.Windows.Forms.Button StnModelIslemleri;
        private System.Windows.Forms.Button BtnYetkiIslemleri;
        private System.Windows.Forms.Button BtnYedekParcaIslemleri;
        private System.Windows.Forms.Panel PnlModelIslemleri;
        private System.Windows.Forms.Panel PnlMarkaIslemleri;
        private System.Windows.Forms.Panel PnlSistemCihazIslemleri;
        private System.Windows.Forms.Panel PnlYedekParcaKategori;
        private System.Windows.Forms.Panel PnlYedekParcaIslemleri;
        private System.Windows.Forms.Panel PnlYetkiIslemleri;
        private System.Windows.Forms.Button BtnMarkaGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMarkaIslemleriMarkaAdi;
        private System.Windows.Forms.ListBox LstMarkaIslemleriMarkalar;
        private System.Windows.Forms.Label LblMarkaIslemleri;
        private System.Windows.Forms.Label LblMarkaIslemleriMarkaId;
        private System.Windows.Forms.Button BtnMarkaSil;
        private System.Windows.Forms.Button BtnYeniMarka;
    }
}
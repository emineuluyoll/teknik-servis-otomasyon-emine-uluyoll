using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace teknık_otomasyon
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }
        void markadoldur()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From Marka Where Silindi = 0", Ayar.con);
            Ayar.con.Open();
            DataTable table = new DataTable();
            adtr.Fill(table);
            LstMarkaIslemleriMarkalar.DataSource = null;
            LstMarkaIslemleriMarkalar.DisplayMember = "MarkaAdi";
            LstMarkaIslemleriMarkalar.ValueMember = "MarkaId";
            LstMarkaIslemleriMarkalar.DataSource = table;

            CmbYedekParcaIslemleriMarka.DataSource = null;
            CmbYedekParcaIslemleriMarka.DisplayMember = "MarkaAdi";
            CmbYedekParcaIslemleriMarka.ValueMember = "MarkaId";
            CmbYedekParcaIslemleriMarka.DataSource = table;


            CmbYedekParcaIslemleriMarka.SelectedValue = 1;
            Ayar.con.Close();
        }

        void yetkidoldur()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From Yetkilendirme", Ayar.con);
            Ayar.con.Open();
            DataTable table = new DataTable();
            adtr.Fill(table);
            CmbYetkiler.DataSource = null;
            CmbYetkiler.DisplayMember = "yetkiAdi";
            CmbYetkiler.ValueMember = "yetkiId";
            CmbYetkiler.DataSource = table;
            CmbYetkiler.SelectedValue = 0;
            ChcCariIslemler.Checked = false;
            ChcKayitAcma.Checked = false;
            ChcKayitTamamlama.Checked = false;
            ChcPersonelEkleme.Checked = false;
            ChcPersonelSilme.Checked = false;
            ChcSistemAyarlari.Checked = false;
            ChcYedekParca.Checked = false;
            CmbYetkiler.Visible = true;
            TxtYetkiAdi.Visible = false;
            button6.Visible = true;
            TxtYetkiAdi.Text = "";
            Ayar.con.Close();


        }
        void cihazdoldur()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From Cihazlar Where Silindi = 0", Ayar.con);
            Ayar.con.Open();
            DataTable table = new DataTable();
            adtr.Fill(table);
            LstCihazIslemleriCihazAdi.DataSource = null;
            LstCihazIslemleriCihazAdi.DisplayMember = "CihazAdi";
            LstCihazIslemleriCihazAdi.ValueMember = "CihazId";
            LstCihazIslemleriCihazAdi.DataSource = table;
            Ayar.con.Close();
        }
        void kategoridoldur()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From YedekParcaKategori Where Silindi = 0", Ayar.con);
            Ayar.con.Open();
            DataTable table = new DataTable();
            adtr.Fill(table);
            LstYedekParcaKategoriIslemleri.DisplayMember = "KategoriAdi";
            LstYedekParcaKategoriIslemleri.ValueMember = "KategoriId";
            LstYedekParcaKategoriIslemleri.DataSource = table;

            LstYedekParcaIslemleri.DataSource = null;
            LstYedekParcaIslemleri.DisplayMember = "KategoriAdi";
            LstYedekParcaIslemleri.ValueMember = "KategoriId";
            LstYedekParcaIslemleri.DataSource = table;

            CmbYedekParcaIslemleriKategori.DataSource = null;
            CmbYedekParcaIslemleriKategori.DisplayMember = "KategoriAdi";
            CmbYedekParcaIslemleriKategori.ValueMember = "KategoriId";
            CmbYedekParcaIslemleriKategori.DataSource = table;

            CmbYedekParcaIslemleriKategori.SelectedValue= -1;
            Ayar.con.Close();
        }
        
        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            pnlCari.Visible = false;
            pnlCihaz.Visible = false;
            pnlPersonel.Visible = false;
            pnlSistem.Visible = false;

            // Eğer alt menü panellerin de varsa (örneğin Yetki veya Marka panelleri) onları da kapatabilirsin:
            PnlMarkaIslemleri.Visible = false;
            PnlSistemCihazIslemleri.Visible = false;
            PnlYedekParcaIslemleri.Visible = false;
            PnlYedekParcaKategori.Visible = false;
            PnlYetkiIslemleri.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pnlCari.Visible == true)
            {
                pnlCari.Visible = false;
                button2.BackColor = Color.FromArgb(30, 30, 40);
            }
            else
            {
                button2.BackColor = Color.Linen;
                button1.BackColor = Color.FromArgb(30, 30, 40);
                button3.BackColor = Color.FromArgb(30, 30, 40);
                button4.BackColor = Color.FromArgb(30, 30, 40);
                button5.BackColor = Color.FromArgb(30, 30, 40);
                pnlCihaz.Visible = false;
                pnlPersonel.Visible = false;
                pnlSistem.Visible = false;
                pnlCari.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pnlCihaz.Visible == true)
            {
                pnlCihaz.Visible = false;
                button1.BackColor = Color.FromArgb(30, 30, 40);
            }
            else
            {
                button1.BackColor = Color.Linen;
                button2.BackColor = Color.FromArgb(30, 30, 40);
                button3.BackColor = Color.FromArgb(30, 30, 40);
                button4.BackColor = Color.FromArgb(30, 30, 40);
                button5.BackColor = Color.FromArgb(30, 30, 40);
                pnlCihaz.Visible = true;
                pnlPersonel.Visible = false;
                pnlSistem.Visible = false;
                pnlCari.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pnlPersonel.Visible == true)
            {
                pnlPersonel.Visible = false;
                button3.BackColor = Color.FromArgb(30, 30, 40);
            }
            else
            {
                button3.BackColor = Color.Linen;
                button1.BackColor = Color.FromArgb(30, 30, 40);
                button2.BackColor = Color.FromArgb(30, 30, 40);
                button4.BackColor = Color.FromArgb(30, 30, 40);
                button5.BackColor = Color.FromArgb(30, 30, 40);
                pnlCihaz.Visible = false;
                pnlPersonel.Visible = true;
                pnlSistem.Visible = false;
                pnlCari.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pnlSistem.Visible == true)
            {
                pnlSistem.Visible = false;
                button4.BackColor = Color.FromArgb(30, 30, 40);
            }
            else
            {
                button4.BackColor = Color.Linen;
                button1.BackColor = Color.FromArgb(30, 30, 40);
                button2.BackColor = Color.FromArgb(30, 30, 40);
                button3.BackColor = Color.FromArgb(30, 30, 40);
                button5.BackColor = Color.FromArgb(30, 30, 40);
                pnlCihaz.Visible = false;
                pnlPersonel.Visible = false;
                pnlSistem.Visible = true;
                pnlCari.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void StmMarkaIslemleri_Click(object sender, EventArgs e)
        {
            markadoldur();
            TxtMarkaIslemleriMarkaAdi.Text = "";
            LblMarkaIslemleri.Text = "";
            PnlMarkaIslemleri.Visible = true;

            PnlSistemCihazIslemleri.Visible = false;
            PnlYedekParcaIslemleri.Visible = false;
            PnlYedekParcaKategori.Visible = false;
            PnlYetkiIslemleri.Visible = false;

            BtnMarkaGuncelle.Enabled = false;
            BtnMarkaSil.Enabled = false;
            BtnYeniMarka.Enabled = true;
        }

        private void StnModelIslemleri_Click(object sender, EventArgs e)
        {
            PnlMarkaIslemleri.Visible = false;
            PnlSistemCihazIslemleri.Visible = false;
            PnlYedekParcaIslemleri.Visible = false;
            PnlYedekParcaKategori.Visible = false;
            PnlYetkiIslemleri.Visible = false;
        }

        private void StnCihazIslemleri_Click(object sender, EventArgs e)
        {
            cihazdoldur();
            TxtCihazIslemleriCihazAdi.Text = "";
            LblCihazIslemleriCihazId.Text = "";

            PnlMarkaIslemleri.Visible = false;
            PnlSistemCihazIslemleri.Visible = true;
            PnlYedekParcaIslemleri.Visible = false;
            PnlYedekParcaKategori.Visible = false;
            PnlYetkiIslemleri.Visible = false;


            BtnCihazIslemleriGuncelle.Enabled = false;
            BtnCihazIslmeleriCihazSil.Enabled = false;
            BtnCihazIslemleriYeniCihaz.Enabled = true;
        }

        private void BtnYedekParcaKategori_Click(object sender, EventArgs e)
        {
            kategoridoldur();
            TxtYedekParcaKategoriIslemleriKtAdi.Text = "";
            LblYedekParcaKategoriIslemleriKtId.Text = "";

            PnlMarkaIslemleri.Visible = false;
            PnlSistemCihazIslemleri.Visible = false;
            PnlYedekParcaIslemleri.Visible = false;
            PnlYedekParcaKategori.Visible = true;
            PnlYetkiIslemleri.Visible = false;

            BtnYerdekParcaKategorileriIslemleriGuncelle.Enabled = false;
            BtnYedekParcaKategoriIslemleriSil.Enabled = false;
            BtnYedekParcaKategoriIslemleriYeniKategori.Enabled = true;
        }

        private void BtnYedekParcaIslemleri_Click(object sender, EventArgs e)
        {
            kategoridoldur();
            markadoldur();
            LblYedekParcaIslemleriIslemler.Text = "KATEGORILER";
            LblYedekParcaIslemleriIslemler.BackColor = Color.Tomato;
            LblYedekParcaIslemleriYedekParcaId.Text = "";
            TxtYedekParcaIslemleriModel.Text = "";
            TxtYedekParcaIslemleriStok.Text = "";
            TxtYedekParcaIslemleriEkOzellikler.Text = "";
            BtnYedekParcaGuncelle.Enabled = false;
            BtnYedekParcaIslemleriSil.Enabled = false;
            BtnYedekParcaIslemleriYeniYedekParca.Enabled = true;

            PnlMarkaIslemleri.Visible = false;
            PnlSistemCihazIslemleri.Visible = false;
            PnlYedekParcaIslemleri.Visible = true;
            PnlYedekParcaKategori.Visible = false;
            PnlYetkiIslemleri.Visible = false;
        }

        private void BtnYetkiIslemleri_Click(object sender, EventArgs e)
        {
            yetkidoldur();
            PnlMarkaIslemleri.Visible = false;
            PnlSistemCihazIslemleri.Visible = false;
            PnlYedekParcaIslemleri.Visible = false;
            PnlYedekParcaKategori.Visible = false;
            PnlYetkiIslemleri.Visible = true;
        }

        private void LstMarkaIslemleriMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bunu yanlis actin kullanma ve silme
        }

        private void LstMarkaIslemleriMarkalar_DoubleClick(object sender, EventArgs e)
        {
            BtnMarkaGuncelle.Enabled = true;
            BtnMarkaSil.Enabled = true;
            BtnYeniMarka.Enabled = false;
            TxtMarkaIslemleriMarkaAdi.Text = LstMarkaIslemleriMarkalar.Text;
            LblMarkaIslemleri.Text = LstMarkaIslemleriMarkalar.SelectedValue.ToString();
        }

        private void BtnMarkaSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Marka set Silindi = 1 Where MarkaId=@p1", Ayar.con);
            cmd.Parameters.AddWithValue("@p1", LblMarkaIslemleri.Text);
            Ayar.con.Open();
            cmd.ExecuteNonQuery();
            Ayar.con.Close();
            TxtMarkaIslemleriMarkaAdi.Text = "";
            LblMarkaIslemleri.Text = "";
            BtnMarkaGuncelle.Enabled = false;
            BtnMarkaSil.Enabled = false;
            BtnYeniMarka.Enabled = true;
            markadoldur();
        }

        private void BtnYeniMarka_Click(object sender, EventArgs e)
        {
            if (TxtMarkaIslemleriMarkaAdi.Text == "")
            {
                MessageBox.Show("lutfen marka adi alanini doldurunuz .", "Bos Alan Hatasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Insert into Marka (MarkaAdi) values (@p1)", Ayar.con);
                    cmd.Parameters.AddWithValue("@p1", TxtMarkaIslemleriMarkaAdi.Text.ToUpper());
                    Ayar.con.Open();
                    cmd.ExecuteNonQuery();
                    Ayar.con.Close();
                    markadoldur();
                    TxtMarkaIslemleriMarkaAdi.Text = "";
                    LblMarkaIslemleri.Text = "";
                }
                catch (Exception)
                {

                    MessageBox.Show("Sistemsel bir hata olustu,Daha sonra tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void BtnMarkaGuncelle_Click(object sender, EventArgs e)
        {
            if (TxtMarkaIslemleriMarkaAdi.Text == "" || LblMarkaIslemleri.Text == "")
            {
                MessageBox.Show("lutfen tum alanlari doldurunuz yada marka seciniz.", "Bos Alan Hatasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Update Marka set MarkaAdi = @p1 where MarkaId=@p2", Ayar.con);
                    cmd.Parameters.AddWithValue("@p1", TxtMarkaIslemleriMarkaAdi.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@p2", LblMarkaIslemleri.Text);

                    Ayar.con.Open();
                    cmd.ExecuteNonQuery();
                    Ayar.con.Close();
                    markadoldur();
                    TxtMarkaIslemleriMarkaAdi.Text = "";
                    LblMarkaIslemleri.Text = "";
                    markadoldur();
                }
                catch (Exception)
                {

                    MessageBox.Show("Sistemsel bir hata olustu,Daha sonra tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void LstCihazIslemleriCihazAdi_DoubleClick(object sender, EventArgs e)
        {
            BtnCihazIslemleriGuncelle.Enabled = true;
            BtnCihazIslmeleriCihazSil.Enabled = true;
            BtnCihazIslemleriYeniCihaz.Enabled = false;
            TxtCihazIslemleriCihazAdi.Text = LstCihazIslemleriCihazAdi.Text;
            LblCihazIslemleriCihazId.Text = LstCihazIslemleriCihazAdi.SelectedValue.ToString();
        }

        private void BtnCihazIslemleriYeniCihaz_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("Insert into Cihazlar (CihazAdi) values (@p1)", Ayar.con);
                cmd.Parameters.AddWithValue("@p1", TxtCihazIslemleriCihazAdi.Text.ToUpper());
                Ayar.con.Open();
                cmd.ExecuteNonQuery();
                Ayar.con.Close();
                TxtCihazIslemleriCihazAdi.Text = "";
                LblCihazIslemleriCihazId.Text = "";
                cihazdoldur();
            }
            catch (Exception)
            {
                Ayar.con.Close();
                MessageBox.Show("Sistemsel hata olustu,lutfen daha sonra tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void BtnCihazIslemleriGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                if (LblCihazIslemleriCihazId.Text == "" || TxtCihazIslemleriCihazAdi.Text == "")
                {
                    MessageBox.Show("Bos Alan Birakmayiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Update Cihazlar set CihazAdi = @p1 Where CihazId = @p2", Ayar.con);
                    cmd.Parameters.AddWithValue("@p1", TxtCihazIslemleriCihazAdi.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@p2", LblCihazIslemleriCihazId.Text);

                    Ayar.con.Open();
                    cmd.ExecuteNonQuery();
                    Ayar.con.Close();
                    TxtCihazIslemleriCihazAdi.Text = "";
                    LblCihazIslemleriCihazId.Text = "";
                    cihazdoldur();
                }
            }
            catch (Exception)
            {
                Ayar.con.Close();
                MessageBox.Show("Sistemsel hata olustu,lutfen daha sonra tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnCihazIslmeleriCihazSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (LblCihazIslemleriCihazId.Text == "" || TxtCihazIslemleriCihazAdi.Text == "")
                {
                    MessageBox.Show("Bos Alan Birakmayiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Update Cihazlar set Silindi = @p1 Where CihazId = @p2", Ayar.con);
                    cmd.Parameters.AddWithValue("@p1", "1");
                    cmd.Parameters.AddWithValue("@p2", LblCihazIslemleriCihazId.Text);

                    Ayar.con.Open();
                    cmd.ExecuteNonQuery();
                    Ayar.con.Close();
                    TxtCihazIslemleriCihazAdi.Text = "";
                    LblCihazIslemleriCihazId.Text = "";
                    cihazdoldur();
                }
            }
            catch (Exception)
            {
                Ayar.con.Close();
                MessageBox.Show("Sistemsel hata olustu,lutfen daha sonra tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void LstYedekParcaKategoriIslemleri_DoubleClick(object sender, EventArgs e)
        {
            BtnYerdekParcaKategorileriIslemleriGuncelle.Enabled = true;
            BtnYedekParcaKategoriIslemleriSil.Enabled = true;
            BtnYedekParcaKategoriIslemleriYeniKategori.Enabled = false;
            TxtYedekParcaKategoriIslemleriKtAdi.Text = LstYedekParcaKategoriIslemleri.Text;
            LblYedekParcaKategoriIslemleriKtId.Text = LstYedekParcaKategoriIslemleri.SelectedValue.ToString();
        }

        private void BtnYedekParcaKategoriIslemleriYeniKategori_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtYedekParcaKategoriIslemleriKtAdi.Text == "")
                {
                    MessageBox.Show("Bos Alan Birakmayiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Insert into YedekParcaKategori (KategoriAdi) values (@p1)", Ayar.con);
                    cmd.Parameters.AddWithValue("@p1", TxtYedekParcaKategoriIslemleriKtAdi.Text.ToUpper());
                    Ayar.con.Open();
                    cmd.ExecuteNonQuery();
                    Ayar.con.Close();
                    TxtYedekParcaKategoriIslemleriKtAdi.Text = "";
                    LblYedekParcaKategoriIslemleriKtId.Text = "";
                    kategoridoldur();
                }
            }
            catch (Exception)
            {
                Ayar.con.Close();
                MessageBox.Show("Sistemsel hata olustu,lutfen daha sonra tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnYerdekParcaKategorileriIslemleriGuncelle_Click(object sender, EventArgs e)
        {
            if (TxtYedekParcaKategoriIslemleriKtAdi.Text == "" || LblYedekParcaKategoriIslemleriKtId.Text == "")
            {
                MessageBox.Show("lutfen tum alanlari doldurunuz yada marka seciniz.", "Bos Alan Hatasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Update YedekParcaKategori set KategoriAdi = @p1 where KategoriId=@p2", Ayar.con);
                    cmd.Parameters.AddWithValue("@p1", TxtYedekParcaKategoriIslemleriKtAdi.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@p2", LblYedekParcaKategoriIslemleriKtId.Text);

                    Ayar.con.Open();
                    cmd.ExecuteNonQuery();
                    Ayar.con.Close();
                    markadoldur();
                    TxtYedekParcaKategoriIslemleriKtAdi.Text = "";
                    LblYedekParcaKategoriIslemleriKtId.Text = "";
                    kategoridoldur();
                }
                catch (Exception)
                {

                    MessageBox.Show("Sistemsel bir hata olustu,Daha sonra tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void BtnYedekParcaKategoriIslemleriSil_Click(object sender, EventArgs e)
        {
            if (TxtYedekParcaKategoriIslemleriKtAdi.Text == "" || LblYedekParcaKategoriIslemleriKtId.Text == "")
            {
                MessageBox.Show("lutfen tum alanlari doldurunuz yada marka seciniz.", "Bos Alan Hatasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Update YedekParcaKategori set Silindi = @p1 where KategoriId=@p2", Ayar.con);
                    cmd.Parameters.AddWithValue("@p1", "");
                    cmd.Parameters.AddWithValue("@p2", LblYedekParcaKategoriIslemleriKtId.Text);

                    Ayar.con.Open();
                    cmd.ExecuteNonQuery();
                    Ayar.con.Close();
                    markadoldur();
                    TxtYedekParcaKategoriIslemleriKtAdi.Text = "";
                    LblYedekParcaKategoriIslemleriKtId.Text = "";
                    kategoridoldur();
                }
                catch (Exception)
                {

                    MessageBox.Show("Sistemsel bir hata olustu,Daha sonra tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
            private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
            //yanlisikla
            }

        private void PnlYedekParcaIslemleri_Paint(object sender, PaintEventArgs e)
        {
            //yanlisikla
        }

        private void LstYedekParcaIslemleri_DoubleClick(object sender, EventArgs e)
        {
            if (LblYedekParcaIslemleriIslemler.Text == "KATEGORILER")
            {
               
                int id = int.Parse(LstYedekParcaIslemleri.SelectedValue.ToString());
                LstYedekParcaIslemleri.DataSource = null;
                LblYedekParcaIslemleriIslemler.Text = "MODELLER";
                LblYedekParcaIslemleriIslemler.BackColor = Color.DarkGreen;
                SqlDataAdapter adtr = new SqlDataAdapter("Select * From YedekParca where Kategori =" + id + "", Ayar.con);
                DataTable table = new DataTable();
                Ayar.con.Open();
                adtr.Fill(table);
                LstYedekParcaIslemleri.DisplayMember = "Model";
                LstYedekParcaIslemleri.ValueMember = "YedekParcaId";
                LstYedekParcaIslemleri.DataSource = table;
                Ayar.con.Close();
            }
            else if (LblYedekParcaIslemleriIslemler.Text == "MODELLER")
            {
                LblYedekParcaIslemleriYedekParcaId.Text = LstYedekParcaIslemleri.SelectedValue.ToString();
                SqlCommand cmd = new SqlCommand("Select * From YedekParca Where YedekParcaId = @p1", Ayar.con);
                Ayar.con.Open();
                cmd.Parameters.AddWithValue("@p1", LblYedekParcaIslemleriYedekParcaId.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TxtYedekParcaIslemleriModel.Text = dr["Model"].ToString();
                    TxtYedekParcaIslemleriStok.Text = dr["Stok"].ToString();
                    TxtYedekParcaIslemleriEkOzellikler.Text = dr["EkOzellikler"].ToString();
                    CmbYedekParcaIslemleriKategori.SelectedValue = dr["Kategori"].ToString() ;
                    CmbYedekParcaIslemleriMarka.SelectedValue = dr["Marka"].ToString();
                    BtnYedekParcaGuncelle.Enabled = true;
                    BtnYedekParcaIslemleriSil.Enabled = true;
                    BtnYedekParcaIslemleriYeniYedekParca.Enabled = false;

                }
                Ayar.con.Close();
                
            }
        }

        private void BtnYedekParcaIslemleriYeniYedekParca_Click(object sender, EventArgs e)
        {
            if( TxtYedekParcaIslemleriModel.Text != "" && TxtYedekParcaIslemleriStok.Text!="" && TxtYedekParcaIslemleriEkOzellikler.Text!="" && CmbYedekParcaIslemleriKategori.Text!=""&& CmbYedekParcaIslemleriMarka.Text !="")
            {
                SqlCommand cmd = new SqlCommand("Insert into YedekParca (Kategori,Marka,Model,Stok,EkOzellikler) values (@p1,@p2,@p3,@p4,@p5)", Ayar.con);
                cmd.Parameters.AddWithValue("@p1", CmbYedekParcaIslemleriKategori.SelectedValue);
                cmd.Parameters.AddWithValue("@p2", CmbYedekParcaIslemleriMarka.SelectedValue);
                cmd.Parameters.AddWithValue("@p3", TxtYedekParcaIslemleriModel.Text.ToUpper());
                cmd.Parameters.AddWithValue("@p4", TxtYedekParcaIslemleriStok.Text);
                cmd.Parameters.AddWithValue("@p5", TxtYedekParcaIslemleriEkOzellikler.Text);
                Ayar.con.Open();
                cmd.ExecuteNonQuery();
                Ayar.con.Close();
                kategoridoldur();
                markadoldur();
                LblYedekParcaIslemleriIslemler.Text = "KATEGORILER";
                LblYedekParcaIslemleriIslemler.BackColor = Color.Tomato;
                LblYedekParcaIslemleriYedekParcaId.Text = "";
                TxtYedekParcaIslemleriModel.Text = "";
                TxtYedekParcaIslemleriStok.Text = "";
                TxtYedekParcaIslemleriEkOzellikler.Text = "";
                BtnYedekParcaGuncelle.Enabled = false;
                BtnYedekParcaIslemleriSil.Enabled = false;
                BtnYedekParcaIslemleriYeniYedekParca.Enabled = true;

            }
            else
            {
                MessageBox.Show("Bos Alan Birakmayiniz.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void BtnYedekParcaGuncelle_Click(object sender, EventArgs e)
        {
            if (LblYedekParcaIslemleriYedekParcaId.Text != "" && TxtYedekParcaIslemleriModel.Text != "" && TxtYedekParcaIslemleriStok.Text != "" && TxtYedekParcaIslemleriEkOzellikler.Text != "" && CmbYedekParcaIslemleriKategori.Text != "" && CmbYedekParcaIslemleriMarka.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Update YedekParca Set Kategori = @p1, Marka=@p2, Model=@p3, Stok=@p4, EkOzellikler = @p5 where YedekParcaId = @p6", Ayar.con);
                cmd.Parameters.AddWithValue("@p1", CmbYedekParcaIslemleriKategori.SelectedValue);
                cmd.Parameters.AddWithValue("@p2", CmbYedekParcaIslemleriMarka.SelectedValue);
                cmd.Parameters.AddWithValue("@p3", TxtYedekParcaIslemleriModel.Text.ToUpper());
                cmd.Parameters.AddWithValue("@p4", TxtYedekParcaIslemleriStok.Text);
                cmd.Parameters.AddWithValue("@p5", TxtYedekParcaIslemleriEkOzellikler.Text);
                cmd.Parameters.AddWithValue("@p6", LblYedekParcaIslemleriYedekParcaId.Text);
                Ayar.con.Open();
                cmd.ExecuteNonQuery();
                Ayar.con.Close();
                kategoridoldur();
                markadoldur();
                LblYedekParcaIslemleriIslemler.Text = "KATEGORİLER";
                LblYedekParcaIslemleriIslemler.BackColor = Color.Tomato;
                LblYedekParcaIslemleriYedekParcaId.Text = "";
                TxtYedekParcaIslemleriModel.Text = "";
                TxtYedekParcaIslemleriStok.Text = "";
                TxtYedekParcaIslemleriEkOzellikler.Text = "";
                BtnYedekParcaGuncelle.Enabled = false;
                BtnYedekParcaIslemleriSil.Enabled = false;
                BtnYedekParcaIslemleriYeniYedekParca.Enabled = true;
            }
            else
            {
                MessageBox.Show("Bos Alan Birakmayiniz.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void BtnYedekParcaIslemleriSil_Click(object sender, EventArgs e)
        {
            if (LblYedekParcaIslemleriYedekParcaId.Text != "" && TxtYedekParcaIslemleriModel.Text != "" && TxtYedekParcaIslemleriStok.Text != "" && TxtYedekParcaIslemleriEkOzellikler.Text != "" && CmbYedekParcaIslemleriKategori.Text != "" && CmbYedekParcaIslemleriMarka.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Delete From YedekParca where YedekParcaId = @p1", Ayar.con);
                cmd.Parameters.AddWithValue("@p1", LblYedekParcaIslemleriYedekParcaId.Text);
                Ayar.con.Open();
                cmd.ExecuteNonQuery();
                Ayar.con.Close();
                kategoridoldur();
                markadoldur();
                LblYedekParcaIslemleriIslemler.Text = "KATEGORİLER";
                LblYedekParcaIslemleriIslemler.BackColor = Color.Tomato;
                LblYedekParcaIslemleriYedekParcaId.Text = "";
                TxtYedekParcaIslemleriModel.Text = "";
                TxtYedekParcaIslemleriStok.Text = "";
                TxtYedekParcaIslemleriEkOzellikler.Text = "";
                BtnYedekParcaGuncelle.Enabled = false;
                BtnYedekParcaIslemleriSil.Enabled = false;
                BtnYedekParcaIslemleriYeniYedekParca.Enabled = true;
            }
            else
            {
                MessageBox.Show("Bos Alan Birakmayiniz.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void CmbYetkiler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbYetkiler_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Yetkilendirme where YetkiId = @p1", Ayar.con);
            cmd.Parameters.AddWithValue("@p1", CmbYetkiler.SelectedValue);
           
            Ayar.con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr[2].ToString() == "True")
                {
                    ChcPersonelEkleme.Checked = true;
                }
                else
                {
                    ChcPersonelEkleme.Checked = false;
                }
                //
                if (dr[3].ToString() == "True")
                {
                    ChcPersonelSilme.Checked = true;
                }
                else
                {
                    ChcPersonelSilme.Checked = false;
                }
                //
                if (dr[4].ToString() == "True")
                {
                    ChcKayitAcma.Checked = true;
                }
                else
                {
                    ChcKayitAcma.Checked = false;
                }
                //
                if (dr[5].ToString() == "True")
                {
                    ChcKayitTamamlama.Checked = true;
                }
                else
                {
                    ChcKayitTamamlama.Checked = false;
                }
                //
                if (dr[6].ToString() == "True")
                {
                    ChcYedekParca.Checked = true;
                }
                else
                {
                    ChcYedekParca.Checked = false;
                }
                //
                if (dr[7].ToString() == "True")
                {
                    ChcCariIslemler.Checked = true;
                }
                else
                {
                    ChcCariIslemler.Checked = false;
                }
                //
                if (dr[6].ToString() == "True")
                {
                    ChcSistemAyarlari.Checked = true;
                }
                else
                {
                   ChcSistemAyarlari.Checked = false;
                }

            }
            Ayar.con.Close();

        }

        private void CmbYetkiler_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnYetkiyiKaydet_Click(object sender, EventArgs e)
        {
            if(CmbYetkiler.SelectedValue==null && TxtYetkiAdi.Text=="")
            {
                MessageBox.Show("BOS ALANLARI DOLDURUN YADA BIR SECIM YAPIN.","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                String personelekle, personelsil, kayitac, kayittamamla, yedekparca, carislem, sistemayarlari;
                if (ChcCariIslemler.Checked == true)
                {
                    carislem = "1";
                }
                else
                {
                    carislem = "0";
                }
                //
                if (ChcKayitAcma.Checked == true)
                {
                    kayitac = "1";
                }
                else
                {
                    kayitac = "0";
                }
                //
                if (ChcKayitTamamlama.Checked == true)
                {
                    kayittamamla = "1";
                }
                else
                {
                    kayittamamla = "0";
                }
                //
                if (ChcPersonelEkleme.Checked == true)
                {
                    personelekle = "1";
                }
                else
                {
                    personelekle = "0";
                }
                //
                if (ChcPersonelSilme.Checked == true)
                {
                    personelsil = "1";
                }
                else
                {
                    personelsil = "0";
                }
                //
                if (ChcSistemAyarlari.Checked == true)
                {
                    sistemayarlari = "1";
                }
                else
                {
                    sistemayarlari = "0";
                }
                //
                if (ChcYedekParca.Checked == true)
                {
                    yedekparca = "1";
                }
                else
                {
                    yedekparca = "0";
                }
                //
                int id;
                if (CmbYetkiler.SelectedValue == null)
                {
                    id = 0;
                }
                else
                {
                    id = int.Parse(CmbYetkiler.SelectedValue.ToString());
                }
                SqlCommand cmd = new SqlCommand("Select * from Yetkilendirme Where yetkiId = @p1", Ayar.con);
                cmd.Parameters.AddWithValue("@p1", id);
                Ayar.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                string islem;
                if (dr.Read())
                {
                    islem = "Update Yetkilendirme set PersonelEkleme = @pekle, PersonelSilme=@psil, KayitAcma=@kac, KayitTamamlama = @ktamamla, YedekParca = @yparca, CariIslemleri = @cislem, SistemAyarlari = @sAyarlar Where yetkiId = " + CmbYetkiler.SelectedValue;
                }
                else
                {
                    islem = "Insert into Yetkilendirme (yetkiAdi,PersonelEkleme,PersonelSilme,KayitAcma,KayitTamamlama,YedekParca,CariIslemleri,SistemAyarlari) values ('" + TxtYetkiAdi.Text + "',@pekle,@psil,@kac,@ktamamla,@yparca,@cislem,@sAyarlar)";
                }
                Ayar.con.Close();
                SqlCommand komut = new SqlCommand(islem, Ayar.con);
                komut.Parameters.AddWithValue("@pekle", personelekle);
                komut.Parameters.AddWithValue("@psil", personelsil);
                komut.Parameters.AddWithValue("@kac", kayitac);
                komut.Parameters.AddWithValue("@ktamamla", kayittamamla);
                komut.Parameters.AddWithValue("@yparca", yedekparca);
                komut.Parameters.AddWithValue("@cislem", carislem);
                komut.Parameters.AddWithValue("@sAyarlar", sistemayarlari);
                Ayar.con.Open();
                komut.ExecuteNonQuery();
                Ayar.con.Close();
                yetkidoldur(); 
            }
           


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            yetkidoldur();
            TxtYetkiAdi.Visible = true;
            CmbYetkiler.Visible = false;
            button6.Visible = false;

        }

        private void LblKullaniciAdi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KullaniciProfili kp = new KullaniciProfili();
            kp.Show();
        }
    }


}   

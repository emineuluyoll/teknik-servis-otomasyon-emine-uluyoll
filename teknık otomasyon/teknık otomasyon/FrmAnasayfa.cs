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
            LstMarkaIslemleriMarkalar.DisplayMember = "MarkaAdi";
            LstMarkaIslemleriMarkalar.ValueMember = "MarkaId";
            LstMarkaIslemleriMarkalar.DataSource = table;
            Ayar.con.Close();
        }
        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {

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
            PnlMarkaIslemleri.Visible = true;
            PnlModelIslemleri.Visible=false;
            PnlSistemCihazIslemleri.Visible = false;
            PnlYedekParcaIslemleri.Visible = false;
            PnlYedekParcaKategori.Visible = false;
            PnlYetkiIslemleri.Visible = false;

            BtnMarkaGuncelle.Enabled=false;
            BtnMarkaSil.Enabled=false;
            BtnYeniMarka.Enabled=true;
        }

        private void StnModelIslemleri_Click(object sender, EventArgs e)
        {
            PnlMarkaIslemleri.Visible = false;
            PnlModelIslemleri.Visible = true;
            PnlSistemCihazIslemleri.Visible = false;
            PnlYedekParcaIslemleri.Visible = false;
            PnlYedekParcaKategori.Visible = false;
            PnlYetkiIslemleri.Visible = false;
        }

        private void StnCihazIslemleri_Click(object sender, EventArgs e)
        {
            PnlMarkaIslemleri.Visible = false;
            PnlModelIslemleri.Visible = false;
            PnlSistemCihazIslemleri.Visible = true;
            PnlYedekParcaIslemleri.Visible = false;
            PnlYedekParcaKategori.Visible = false;
            PnlYetkiIslemleri.Visible = false;
        }

        private void BtnYedekParcaKategori_Click(object sender, EventArgs e)
        {
            PnlMarkaIslemleri.Visible = false;
            PnlModelIslemleri.Visible = false;
            PnlSistemCihazIslemleri.Visible = false;
            PnlYedekParcaIslemleri.Visible = false;
            PnlYedekParcaKategori.Visible = true;
            PnlYetkiIslemleri.Visible = false;
        }

        private void BtnYedekParcaIslemleri_Click(object sender, EventArgs e)
        {
            PnlMarkaIslemleri.Visible = false;
            PnlModelIslemleri.Visible = false;
            PnlSistemCihazIslemleri.Visible = false;
            PnlYedekParcaIslemleri.Visible = true;
            PnlYedekParcaKategori.Visible = false;
            PnlYetkiIslemleri.Visible = false;
        }

        private void BtnYetkiIslemleri_Click(object sender, EventArgs e)
        {
            PnlMarkaIslemleri.Visible = false;
            PnlModelIslemleri.Visible = false;
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
            BtnYeniMarka.Enabled = true;
            TxtMarkaIslemleriMarkaAdi.Text=LstMarkaIslemleriMarkalar.Text;
            LblMarkaIslemleriMarkaId.Text = LstMarkaIslemleriMarkalar.SelectedValue.ToString();
        }

        private void BtnMarkaSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Marka set Silindi = 1 Where MarkaId=@p1",Ayar.con);
            cmd.Parameters.AddWithValue("@p1", LblMarkaIslemleriMarkaId.Text);
            Ayar.con.Open();
            cmd.ExecuteNonQuery();
            Ayar.con.Close();
            TxtMarkaIslemleriMarkaAdi.Text = "";
            LblMarkaIslemleriMarkaId.Text = "";
            BtnMarkaGuncelle.Enabled = false;
            BtnMarkaSil.Enabled = false;
            BtnYeniMarka.Enabled= true;
            markadoldur();
        }
    }
    
    
    
}

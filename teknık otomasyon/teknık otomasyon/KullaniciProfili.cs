using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teknık_otomasyon
{
    public partial class KullaniciProfili : Form
    {
        public KullaniciProfili()
        {
            InitializeComponent();
        }
        void listele()
        {
            DataTable dt = new DataTable();

            using (SqlDataAdapter da =
                new SqlDataAdapter("SELECT * FROM Personel", Ayar.con))
            {
                da.Fill(dt);
            }

            
        }

        private void KullaniciProfili_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From Personel Where KullaniciAdi = @p1", Ayar.con);
            cmd.Parameters.AddWithValue("@p1","Admin");
            Ayar.con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                LblAdSoyad.Text=dr["AdiSoyadi"].ToString();
                lblMeslek.Text= dr["Meslek"].ToString();
                lblId.Text = dr["PersonelNo"].ToString();
                lblAd.Text = dr["AdiSoyadi"].ToString();
                lblGorev.Text = dr["Gorevi"].ToString();
                TxtTel.Text = dr["Telefon"].ToString();
                TxtMail.Text = dr["Mail"].ToString();
                TxtAdres.Text = dr["Adres"].ToString();
            }
            Ayar.con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Personel Set Telefon=@p1, Mail=@p2, Adres=@p3 Where PersonelNo=@p4", Ayar.con);
            cmd.Parameters.AddWithValue("@p1", TxtTel.Text);
            cmd.Parameters.AddWithValue("@p2", TxtMail.Text);
            cmd.Parameters.AddWithValue("@p3", TxtAdres.Text);
            cmd.Parameters.AddWithValue("@p4", lblId.Text);
            Ayar.con.Open();
            cmd.ExecuteNonQuery();
            Ayar.con.Close();
            MessageBox.Show("Güncellendi.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personelekle form = new personelekle();
            form.ShowDialog();
            SqlCommand cmdNo = new SqlCommand("Select ISNULL(Max(PersonelNo), 26000000) + 1 From Personel", Ayar.con);
            Ayar.con.Open();
            
            Ayar.con.Close();
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Personel (AdiSoyadi, Gorevi, Telefon, Mail, Adres) " +
                "VALUES (@p1, @p2, @p3, @p4, @p5)", Ayar.con);


            cmd.Parameters.AddWithValue("@p1", lblAd.Text);
            cmd.Parameters.AddWithValue("@p2", lblGorev.Text);
            cmd.Parameters.AddWithValue("@p3", TxtTel.Text);
            cmd.Parameters.AddWithValue("@p4", TxtMail.Text);
            cmd.Parameters.AddWithValue("@p5", TxtAdres.Text);

            Ayar.con.Open();
            cmd.ExecuteNonQuery();
            Ayar.con.Close();

            MessageBox.Show("Eklendi.");
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            personelekle form = new personelekle();
            form.ShowDialog();

        }
    }
    
}

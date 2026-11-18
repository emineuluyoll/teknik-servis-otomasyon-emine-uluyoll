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
    public partial class personelekle : Form
    {
        public personelekle()
        {
            InitializeComponent();
        }

        private void personelekle_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM Personel", Ayar.con);

            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Ayar.con.Open();

            SqlCommand noKomut = new SqlCommand(
                "SELECT ISNULL(MAX(PersonelNo), 26000000) + 1 FROM Personel",
                Ayar.con);

            int no = Convert.ToInt32(noKomut.ExecuteScalar());

            SqlCommand komut = new SqlCommand(
                "INSERT INTO Personel (PersonelNo,KullaniciAdi, AdiSoyadi, Gorevi, Telefon, Mail, Adres,Meslek) " +
                "VALUES (@no, @ad,@kadi, @gorev, @telefon, @mail, @adres,@meslek)",
                Ayar.con);

            komut.Parameters.AddWithValue("@no", no);
            komut.Parameters.AddWithValue("@ad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@kadi", TxtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@gorev", txtGorev.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@mail", txtMail.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@meslek", txtMeslek.Text);

            komut.ExecuteNonQuery();
            Ayar.con.Close();

            Listele();
            MessageBox.Show("Personel eklendi. No: " + no);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {

            int no = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["PersonelNo"].Value);

            SqlCommand komut = new SqlCommand(
                "DELETE FROM Personel WHERE PersonelNo = @no", Ayar.con);

            komut.Parameters.AddWithValue("@no", no);

            Ayar.con.Open();
            komut.ExecuteNonQuery();
            Ayar.con.Close();

            Listele();
            MessageBox.Show("Personel silindi.");
        }
    }
}

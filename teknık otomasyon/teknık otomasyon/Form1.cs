using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.IO;

namespace teknık_otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 
        void database()
        {
            string sunucuadi = "";
            string veritabaniAdi = "";
            string vtKullaniciAdi = "";
            string  vtSifre = "";
            XDocument XDoc = XDocument.Load(Application.StartupPath+"\\settings.xml");
            XElement rootElement= XDoc.Root;
            foreach( XElement rehberimiz in rootElement.Elements() )
            {
                sunucuadi = rehberimiz.Element("ServerName").Value;
                veritabaniAdi = rehberimiz.Element("DatabaseName").Value;
                vtKullaniciAdi = rehberimiz.Element("UserId").Value;
                vtSifre= Ayar.sifreCoz (rehberimiz.Element("Password").Value, rehberimiz.Element("Keys").Value);
            }
            Ayar.con = new SqlConnection("Data Source=" + sunucuadi + ";Initial Catalog=" + veritabaniAdi + ";Persist Security Info=True;User Id=" + vtKullaniciAdi + ";Password=" + vtSifre + "");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string dosya_dizi = Application.StartupPath + "\\settings.xml";
            if(File.Exists(dosya_dizi)== true)
            {
                //varsa yapilacak islemler
                //veritabani baglantisi yapilacak login islemleri yapilacak
                database();
                
                

            }
            else 
            {              //yoksa yapilacak islemler
                        //database bilgileriformu acilacak
               DatabaseBilgileri dt=new DatabaseBilgileri();
                dt.Show();
                this.Hide();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtKullaniciAdi.Text != "" && TxtSifre.Text != "")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Select * from Personel Where KullaniciAdi = @p1 And Sifre = @p2", Ayar.con);
                    cmd.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
                    cmd.Parameters.AddWithValue("@p2", TxtSifre.Text);
                    Ayar.con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                       FrmAnasayfa ans = new FrmAnasayfa();
                        ans.LblKullaniciAdi.Text = dr["kullaniciAdi"].ToString();
                       
                        this.Hide();
                        ans.Show();
                    }
                    else
                    {
                        LblUyari.Text = "Kullanıcı adı veya şifre hatalı, kontrol edip tekrar deneyin";
                    }
                    Ayar.con.Close();
                }
                catch (Exception ex)
                {

                    LblUyari.Text = "islem gerceklestitirilirken hata oldu,lutfen tekrar deneyin";
                }
            }
            else
            {
                LblUyari.Text = "Tüm alanları doldurmanız gerekir.";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

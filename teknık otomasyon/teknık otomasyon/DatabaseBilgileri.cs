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
    public partial class DatabaseBilgileri : Form
    {
        public DatabaseBilgileri()
        {
            InitializeComponent();
        }

        private void DatabaseBilgileri_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( txtAnahtar.Text !=""&& txtKullanici.Text != ""&&txtSifre.Text !=""&& txtSunucuAdi.Text!=""&& txtVeritabani.Text !="")
            {
                XmlTextWriter yaz = new XmlTextWriter(Application.StartupPath + "\\settings.xml", System.Text.UTF8Encoding.UTF8);
                yaz.Formatting = Formatting.Indented;
                try
                {
                    yaz.WriteStartDocument();
                    yaz.WriteStartElement("setting");
                    yaz.WriteStartElement("DB");
                    yaz.WriteElementString("Provider","SQLOLEDB.1");
                    yaz.WriteElementString("ServerName", txtSunucuAdi.Text);
                    yaz.WriteElementString("DatabaseName", txtVeritabani.Text);
                    yaz.WriteElementString("UserId", txtKullanici.Text);
                    yaz.WriteElementString("Password", Ayar.sifrele(txtSifre.Text,txtAnahtar.Text));
                    yaz.WriteElementString("Keys", txtAnahtar.Text);
                    yaz.WriteEndElement();
                    yaz.WriteEndElement();
                    yaz.Close();
                    MessageBox.Show("ayarlar dosyaniz olustu,program yeniden basladiktan sonra kullanima hazir olacaktir.", "islem basarili", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Hata Mesaji:" + ex.Message.ToString(), "Hata Alindi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("tum alanlari doldurmaniz gerekir", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void txtSunucuAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace baglantıdatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xdoc = new XmlDocument();
            XmlElement root = xdoc.CreateElement("Tedarikciler");

            SqlConnection baglanti = new SqlConnection("server=DESKTOP-MO5HLC4\\SQLEXPRESS;database=Northwind;Integrated Security=true");
            SqlCommand tedkom = new SqlCommand("select * from Tedarikciler", baglanti);
            baglanti.Open();
            SqlDataReader oku = tedkom.ExecuteReader();
            while (oku.Read())
            {
                XmlElement tedarikci = xdoc.CreateElement("Tedarikci");
                XmlAttribute sehir = xdoc.CreateAttribute("SehirAdi");
                sehir.Value = oku["Sehir"].ToString();

                XmlAttribute telefon = xdoc.CreateAttribute("Telefon");
                telefon.Value = oku["Telefon"].ToString();

                XmlAttribute adres = xdoc.CreateAttribute("Adres");
                adres.Value = oku["Adres"].ToString();

                tedarikci.Attributes.Append(sehir);
                tedarikci.Attributes.Append(telefon);
                tedarikci.Attributes.Append(adres);
                root.AppendChild(tedarikci);
            }
            baglanti.Close();
            xdoc.AppendChild(root); // tedarikçilerin altına ekliyor.
            xdoc.Save("islem.xml");
        }
    }
}

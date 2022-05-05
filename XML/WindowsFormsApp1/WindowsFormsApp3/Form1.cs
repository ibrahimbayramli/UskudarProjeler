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
using System.Data.SqlClient;
using System.Xml.Linq;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XmlDocument xdoc = new XmlDocument();
            XmlElement root = xdoc.CreateElement("Tedarikciler");

            SqlConnection baglanti =
                new SqlConnection("server=DESKTOP-MO5HLC4\\SQLEXPRESS ; database=Northwind ; Integrated Security=true");
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
            xdoc.AppendChild(root);
            xdoc.Save("veri.xml");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XDocument x=XDocument.Load(@"veri.xml");
            x.Element("Personeller").Add(new XElement("personel",new XElement("id",textBox1.Text),
                new XElement("adi",textBox2.Text),
                new XElement("soyadi",textBox3.Text),
                new XElement("telefonu",textBox4.Text)));
            x.Save(@"veri.xml");
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"veri.xml");

            x.Root.Elements().Where(a => a.Element("id").Value == textBox1.Text).Remove();
            x.Save(@"veri.xml");
            
        }
    }
}

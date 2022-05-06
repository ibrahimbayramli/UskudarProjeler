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

namespace _9._12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Yukle()
        {
            XmlDocument i = new XmlDocument();      //varolan bir dosya ile çalışacaksam nesne böyle üretilir.
            //<personel id="10"> attribute deniliyor.

            DataSet ds = new DataSet();
            //xml dosyamızı okumak için bir reader oluşturuyoruz.
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(@"veri.xml", new XmlReaderSettings());
            //içeriği datasete aktarıyoruz.
            ds.ReadXml(xmlFile);
            //datagridviewin kaynağı olarak dataseti gösteriyoruz.
            dataGridView1.DataSource = ds.Tables[0];
            xmlFile.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"veri.xml");
            x.Element("personeller").Add(new XElement("personel", new XElement("id",textBox1.Text),
                new XElement("adi",textBox2.Text),
                new XElement("soyadi",textBox3.Text),
                new XElement("telefonu",textBox4.Text)));
            x.Save(@"veri.xml");            
            Yukle();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"veri.xml");
            //ürünıd=textbox'a girilen numaralı öğreniyi sil
            x.Root.Elements().Where(a => a.Element("id").Value == textBox1.Text).Remove(); //=>lambda işareti? a değişken aslında
            x.Save(@"veri.xml");
            Yukle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"veri.xml");
            XElement node = x.Element("personeller").Elements("personel").FirstOrDefault(a => a.Element("id").Value.Trim() == textBox1.Text);
            //trim boşluk hassasiyetini ortadan kaldırır. ilk bulduğu boşta çalışır.
            if (node != null)
            {
                node.SetElementValue("adi", textBox2.Text);
                node.SetElementValue("soyadi", textBox3.Text);
                node.SetElementValue("telefonu", textBox4.Text);
                x.Save(@"veri.xml");
                Yukle();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Yukle();
        }
    }
}

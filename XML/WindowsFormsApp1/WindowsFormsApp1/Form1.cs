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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument i = new XmlDocument();
            DataSet ds = new DataSet();
            //xml dosyamızı okumak için bir reader oluşturuyoruz.
            XmlReader XmlFile;
            /*
             * reader içine pathini verdiğimiz dosyayı dolduruyoruz. Burada önemli olan bir nokta var ya pathmizin başına @ yazacağız
             * çift tırnak kullanacağız.
             */
            XmlFile= XmlReader.Create(@"pveri.xml",new XmlReaderSettings());

            // İçeriği datasete aktarıyoruz.
            ds.ReadXml(XmlFile);
            // gridview in kaynağı olarak dataseti gösteriyoruz.
            dataGridView1.DataSource = ds.Tables[0];
            XmlFile.Close();
        }
    }
}

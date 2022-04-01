using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama1
{
    public partial class KH : Form
    {
        public KH()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tip;
            string durum;
            string birim = comboBox1.SelectedItem.ToString();
            if (radioButton1.Checked == true)
            {
                tip = radioButton1.Text;

            }
            else
            {
                tip = radioButton2.Text;
            }
            if (checkBox1.Checked == true)
            {
                durum = checkBox1.Text;

            }
            else
            {
                durum = checkBox1.Text;
            }
            listBox1.Items.Add("İşlem birimi: " + birim);
            listBox1.Items.Add("İşlem Tipi: " + tip);
            listBox1.Items.Add("İşlem durumu: " + durum);
            listBox1.Items.Add("İşlem tarihi: " + dateTimePicker1.Value);
        }
    }
}

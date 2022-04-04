using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama6
{
    public partial class Siparis : Form
    {
        public Siparis()
        {
            InitializeComponent();

            
            groupBox5.Visible = false;
            groupBox4.Visible = false;
            groupBox3.Visible = false;

            if (comboBox3.Text == "Evet")
            {
                groupBox2.Show();
            }
            else if (comboBox3.Text == "Hayır")
            {
                groupBox2.Hide();
            }



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float fiyat = 0;
            Form1 f1 = new Form1();
            string acidurumu="";
            string musteriAdi = f1.textBox1.Text;
            string musteriSoyadi = f1.textBox2.Text;
            string odemeSekli = f1.comboBox1.Text;
            string siparisNo = f1.textBox4.Text;
            listBox1.Items.Add($"Müşteri ismi: {musteriAdi}");
            listBox1.Items.Add($"Müşteri soyismi: {musteriSoyadi}");
            listBox1.Items.Add($"Ödeme Şekli: {odemeSekli}");
            listBox1.Items.Add($"Sipariş No: {siparisNo}");
            if (comboBox1.SelectedItem == "Lahmacun 15 TL")
            {
                fiyat += 15;
                if (comboBox3.SelectedItem == "Evet" && comboBox2.SelectedItem == "Su")
                {
                    fiyat += 3;
                }else if(comboBox3.SelectedItem == "Evet" && comboBox2.SelectedItem == "Soda")
                {
                    fiyat += 5;
                }
                else if (comboBox3.SelectedItem == "Evet" && comboBox2.SelectedItem == "Ayran")
                {
                    fiyat += 5;
                }
                else if (comboBox3.SelectedItem == "Evet" && comboBox2.SelectedItem == "Kola")
                {
                    fiyat += 7;
                }
                else if (comboBox3.SelectedItem == "Evet" && comboBox2.SelectedItem == "Fanta")
                {
                    fiyat += 7;
                }
                else if (comboBox3.SelectedItem == "Evet" && comboBox2.SelectedItem == "Ice Tea Şeftali")
                {
                    fiyat += 7;
                }
                else if (comboBox3.SelectedItem == "Evet" && comboBox2.SelectedItem == "Ice Tea Limon")
                {
                    fiyat += 7;
                }
                if (radioButton1.Checked = true)
                {
                    acidurumu = "Acılı";
                }
                else
                {
                    acidurumu = "Acısız";
                }
            }
            else if (comboBox1.SelectedItem == "Kebap 35 TL")
            {
                fiyat += 35;
                if (comboBox3.SelectedItem == "Evet" && comboBox2.SelectedItem == "Su")
                {
                    fiyat += 3;
                }
                else if (comboBox3.SelectedItem == "Evet" && comboBox2.SelectedItem == "Soda")
                {
                    fiyat += 5;
                }
                else if (comboBox3.SelectedItem == "Evet" && comboBox2.SelectedItem == "Ayran")
                {
                    fiyat += 5;
                }
                else if (comboBox3.SelectedItem == "Evet" && comboBox2.SelectedItem == "Kola")
                {
                    fiyat += 7;
                }
                else if (comboBox3.SelectedItem == "Evet" && comboBox2.SelectedItem == "Fanta")
                {
                    fiyat += 7;
                }
                else if (comboBox3.SelectedItem == "Evet" && comboBox2.SelectedItem == "Ice Tea Şeftali")
                {
                    fiyat += 7;
                }
                else if (comboBox3.SelectedItem == "Evet" && comboBox2.SelectedItem == "Ice Tea Limon")
                {
                    fiyat += 7;
                }
                if (radioButton3.Checked = true)
                {
                    acidurumu = "Acılı";
                }
                else
                {
                    acidurumu = "Acısız";
                }
            }
            else if (comboBox1.SelectedItem == "Pide 25 TL")
            {
                fiyat += 25;
                if (comboBox3.SelectedItem == "Evet" && comboBox2.SelectedItem == "Su")
                {
                    fiyat += 3;
                }
                else if (comboBox3.SelectedItem == "Evet" && comboBox2.SelectedItem == "Soda")
                {
                    fiyat += 5;
                }
                else if (comboBox3.SelectedItem == "Evet" && comboBox2.SelectedItem == "Ayran")
                {
                    fiyat += 5;
                }
                else if (comboBox3.SelectedItem == "Evet" && comboBox2.SelectedItem == "Kola")
                {
                    fiyat += 7;
                }
                else if (comboBox3.SelectedItem == "Evet" && comboBox2.SelectedItem == "Fanta")
                {
                    fiyat += 7;
                }
                else if (comboBox3.SelectedItem == "Evet" && comboBox2.SelectedItem == "Ice Tea Şeftali")
                {
                    fiyat += 7;
                }
                else if (comboBox3.SelectedItem == "Evet" && comboBox2.SelectedItem == "Ice Tea Limon")
                {
                    fiyat += 7;
                }
                if (radioButton5.Checked = true)
                {
                    acidurumu = "Acılı";
                }
                else
                {
                    acidurumu = "Acısız";
                }
            }
            listBox1.Items.Add($"Acı durumu: {acidurumu}");
            listBox1.Items.Add($"Ödenecek tutar: {fiyat}");
            



        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Siparis_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox5.Visible = false;
            groupBox4.Visible = false;
            groupBox3.Visible = false;
        }
        

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem=="Evet")
            {
                groupBox2.Visible = true;
            }
            else if (comboBox3.SelectedItem=="Hayır")
            {
                groupBox2.Visible = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem== "Lahmacun 15 TL")
            {
                groupBox5.Visible = true;
                groupBox4.Visible = false;
                groupBox3.Visible = false;
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                numericUpDown3.Value = 0;
            }
            else if(comboBox1.SelectedItem== "Kebap 35 TL")
            {
                groupBox3.Visible = false;
                groupBox4.Visible = true;
                groupBox5.Visible = false;
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                numericUpDown3.Value = 0;
            }
            else if(comboBox1.SelectedItem== "Pide 25 TL")
            {
                groupBox5.Visible = false;
                groupBox4.Visible = false;
                groupBox3.Visible = true;
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                numericUpDown3.Value = 0;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitiyFrameworkDemos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Personel> liste = new List<Personel>()
            {
                new Personel() { Ad="Fikret",Yasi=23},
                new Personel() { Ad = "Fatih", Yasi = 22 },
                new Personel() { Ad = "Merve", Yasi = 20 },
                new Personel() { Ad="Ayşe",Yasi=21},
                new Personel() { Ad="Velican",Yasi=43},
            };
            //dataGridView1.DataSource = liste.Where(x => x.Ad == "Fikret").ToList();
            // Adı "Fikret" olanların listesini getirir.
            //--------------------------------------------------------------------------------------------------------------------------------------------------

            //dataGridView1.DataSource = liste.OrderBy(x => x.Yasi ).ToList();
            //Yaşa göre sıralama yapar, sırasıyla 20,21,22,23,43 olanları getirir. (Artan sıralama)
            //--------------------------------------------------------------------------------------------------------------------------------------------------

            //dataGridView2.DataSource = liste.OrderBy(x => x.Yasi).Skip(2).ToList();
            //dataGridView1.DataSource = liste.OrderBy(x => x.Yasi).ToList();
            // Skip kullanımı
            // Liste üzerinde istediğimiz satır sayısı kadar atlama yapar.
            // Örneğin; Skip(3) dediğimizde 0., 1., 2. elemanları atlar ve direkt 3. elemandan başlar. 
            //--------------------------------------------------------------------------------------------------------------------------------------------------

            //dataGridView1.DataSource = liste.Where(x => x.Ad.Contains("a")).Take(3).ToList();
            // Burada adında "a" içeren elemanları getirir.
            // Normalde "Fatih" ve "Ayşe" gelecekti, ama Take(2) dediğimiz için fatih geldi.
            //--------------------------------------------------------------------------------------------------------------------------------------------------

            //textBox1.Text = liste.Any(x => x.Ad == "Ayşe").ToString();
            // Kayıt var olduğu için true döner.
            //--------------------------------------------------------------------------------------------------------------------------------------------------

            //textBox1.Text = liste.FirstOrDefault(p => p.Yasi == 23).Ad;
            // Yaşı 23 olan kayıtın adını verir.
            //textBox1.Text = liste.FirstOrDefault(p => p.Ad == "Fikret").Yasi.ToString();
            //Adı "Fikret" olanın yaşını verir.
            //--------------------------------------------------------------------------------------------------------------------------------------------------

            //dataGridView1.DataSource = liste.Where(p => p.Ad.StartsWith("M")).ToList();
            //Adı "M" ile balayanları getirir. Sonuç size "Merva" olarak döner.
            //--------------------------------------------------------------------------------------------------------------------------------------------------

            //textBox1.Text = liste.Sum(p => p.Yasi).ToString();
            // Yaşları toplar, geriye "127" sonucu döner.
            //--------------------------------------------------------------------------------------------------------------------------------------------------

            //textBox1.Text = liste.Where(x => x.Yasi == liste.Max(y => y.Yasi)).Select(p => p.Ad).FirstOrDefault();
            //Yaşı max olan personelin ismini getirir. Sonuç "Velican" olarak geri döner.
            //--------------------------------------------------------------------------------------------------------------------------------------------------

            //textBox1.Text = liste.Find(p => p.Yasi == 21).Ad.ToString();
            //Yaşı 21 olan kişinin dını getirir. Sonuç "Ayşe" olarak geri döner.
        }
    }
}

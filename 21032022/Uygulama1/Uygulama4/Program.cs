using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir seçim yapınız: ");
            Console.WriteLine(" 1- Ürün ekle");
            Console.WriteLine(" 2- Zam yap");
            char secim = Convert.ToChar(Console.ReadLine());
            float fiyat = 0;
            float vergiliFiyat = 0;
            switch (secim){
                case '1':
                    Console.Write("Eklemek istediğiniz ürün adedini giriniz: ");
                    int adet = Convert.ToInt32(Console.ReadLine());
                    for(int i = 1; i <= adet; i++)
                    {
                        Console.Write("Ürün fiyatını giriniz: ");
                        float ucret = Convert.ToSingle(Console.ReadLine());
                        if (ucret >= 0 && ucret < 100)
                        {
                            fiyat += ucret;
                            vergiliFiyat += ucret * 1.01f;
                        } else if (ucret >= 100 && ucret < 300)
                        {
                            fiyat += ucret;
                            vergiliFiyat += ucret * 1.08f;
                        }else if (ucret >= 300)
                        {
                            fiyat += ucret;
                            vergiliFiyat += ucret * 1.18f;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz fiyat!");
                            i -= 1;
                        }

                    }
                    Console.WriteLine($"Vergiler hariç fiyat: {fiyat}");
                    Console.WriteLine($"Vergiler dahil fiyat: {vergiliFiyat}");
                    break;
                case '2':
                    Console.WriteLine("Henüz yapım aşamasındadır.");
                    break;

            }
            
            Console.ReadLine();
        }
    }
}

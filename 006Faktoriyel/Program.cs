using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006Faktoriyel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faktoriyel:
            //    Bir sayının sürekli 1 azaltılarak arka arkaya yapılan çarpım faktoriyeldir.
            //    Örneğin 5 faktoriyel 5! şeklinde gösterilir ve 5! = 5 * 4 * 3 * 2 * 1 olarak hesaplanır.
            //    Basit bir faktoriyel hesaplama konsol uygulaması yazınız:
            //    1) Kullanıcıdan tek seferlik pozitif bir tam sayı alınır.
            //    2) Kullanıcının girdiği sayının faktoriyeli hesaplanarak ekrana yazdırılır.

//            1.Algoritma:

//1 - basla
//2 - bir sayi girin
//3 - s(sayaç) = 0
//4 - toplam = 1
//5 - toplam = sayi * sayi - 1
//6 - sayi = sayi - 1
//7 - sayaç = sayaç + 1
//8 - eger sayaç <= sayi 5.adima git
//9 - toplami yaz
//10 - bitir

//2.Algoritma: Daha uygun

//1 - başla
//2 - bir sayı girin
//3 - index = sayi - 1
//4 - sayi = sayi * index
//5 - index = index - 1
//6 - index > 1 ise 4.adıma git
//7 - sayıyı yaz
//8 - bitir

            Console.Write("Pozitif tam sayı giriniz (çıkmak için: 'q' ) : ");
            string giris = Console.ReadLine();
            int sayi = Convert.ToInt32(giris);
            int sonuc;
            int i= Convert.ToInt32(giris);
            sonuc = sayi;
            if (giris=="q" && i > 0)
            {
                Console.WriteLine("Yanlış seçim yaptınız, lütfen tekrar deneyin.");
            }
            else
            {
                for (i = 0; i < sayi && giris != "q"; i++)
                {
                    sonuc = sonuc * (sayi - 1);
                    sayi--;
                }
                Console.WriteLine(sonuc);
            }
            Console.ReadLine();
        }
    }
}

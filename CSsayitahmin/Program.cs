using System;

namespace CSsayitahmin
{
    class Program
    {
        static void Main(string[] args)
        {
            int tahmin = 0;
            int sayi;
            int sayac=0;

            Random rastgele = new Random();

            sayi = rastgele.Next(1, 100);

            while(tahmin != sayi)
            {
                sayac++;
                Console.Write("Sayı Giriniz: ");
                tahmin = Convert.ToInt32(Console.ReadLine());

                if(tahmin<sayi)
                {
                    Console.WriteLine("Daha Büyük Bir Sayı Giriniz.");
                }
                else if(tahmin>sayi)
                {
                    Console.WriteLine("Daha Küçük Bir Sayı Giriniz.");
                }
            }

            Console.WriteLine("Tebrikler Bildiniz...");
            Console.WriteLine("{0}.Denemede Buldunuz", sayac);

        }
    }
}

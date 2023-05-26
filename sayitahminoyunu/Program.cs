using System;

namespace sayitahminoyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Sayı Tahmin Oyunu";
            Console.Clear();

            Random rastgele = new Random();

            Console.Write("***** SAYI TAHMİN OYUNU *****");
            Console.WriteLine();
            Console.Write("0 ve 10 arasında bir sayı giriniz...");
            Console.WriteLine();

            int a, b;
            Console.Write("Sayı Giriniz: ");
            a = Convert.ToInt32(Console.ReadLine());

            b = rastgele.Next(0, 11);

            if (a == b)
            {
                Console.WriteLine("Girdiğiniz Sayı: " + a);
                Console.WriteLine("Şans Sayısı: " + b);
                Console.WriteLine("Tebrikler Tahmininiz Doğru...");
            }
            else if(a!=b && a<=10)
            {
                Console.WriteLine("Girdiğiniz Sayı: " + a);
                Console.WriteLine("Şans Sayısı: " + b);
                Console.WriteLine("Maalesef Tahmininiz yanlış...");
            }
            else
            {
                Console.WriteLine("Geçersiz Değer Girdiniz...");
                Console.WriteLine("0 ve 10 arasında Değer Giriniz");
            }
        }
    }
}

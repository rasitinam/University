using System;

namespace ödev1
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            while (true)
            {
                Console.Write("Bir sayı girin: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
                Console.WriteLine(toplam);
                if (sayi == 83)
                {
                    break;
                }
            }
            Console.WriteLine("Girdiğiniz sayıların toplamı: " + toplam);
        }
    }
}
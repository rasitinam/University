namespace odev2
{
    class tekcift
    {
        public static void Main(string[] args)
        {
                Console.WriteLine("Bir sayı girin");
                int sayi = int.Parse(Console.ReadLine());
                Console.WriteLine("Tekleri mi Çiftleri mi toplamak istersiniz? (T/Ç)");
                string tercih = Console.ReadLine().ToUpper();
                int toplam = 0;
                if (tercih == "T")
                {
                    for (int i = 1; i <= sayi; i++)
                        if (i % 2 != 0)
                            toplam += i;
                }
                else if (tercih == "Ç")
                {
                    for (int i = 1; i <= sayi; i++)
                        if (i % 2 == 0)
                            toplam += i;
                }
                else
                {
                    Console.WriteLine("Geçersiz bir tercih yaptınız. Lütfen 'T' veya 'Ç' girin.");
                }
                Console.WriteLine("Sayıların Toplamı ="+toplam);
        }
    }
}
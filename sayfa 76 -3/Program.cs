namespace odev3
{
    class tekcift
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Birinci sayıyı girin");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı girin");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tekleri mi Çiftleri mi toplamak istersiniz? (T/Ç)");
            string tercih = Console.ReadLine().ToUpper();
            int toplam = 0;
            if (tercih == "T")
            {
                for (int i = sayi; i <= sayi2; i++)
                    if (i % 2 != 0)
                        toplam += i;
            }
            else if (tercih == "Ç")
            {
                for (int i = sayi; i <= sayi2; i++)
                    if (i % 2 == 0)
                        toplam += i;
            }
            else
            {
                Console.WriteLine("Geçersiz bir tercih yaptınız. Lütfen 'T' veya 'Ç' girin.");
            }
            Console.WriteLine("Sayıların Toplamı =" + toplam);
        }
    }
}
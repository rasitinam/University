namespace ödev5
{
    class Program 
    {
        static void Main(string[] args)
        {
            int sayi, ikiliDeger, onluDeger = 0, tabanDeger = 1, basamakDeger;
            Console.WriteLine("Dönüştürülecek sayıyı girin.");
            sayi =Convert.ToInt32(Console.ReadLine());
            ikiliDeger = sayi;
            while (sayi > 0)
            {
                basamakDeger = sayi % 10;
                onluDeger = onluDeger + basamakDeger * tabanDeger;
                sayi = sayi / 10;
                tabanDeger = tabanDeger * 2;
            }
            Console.Write("İkili (Binary) Sayı: " + ikiliDeger);
            Console.Write("\nOnlu (Decimal) Sayı: " + onluDeger);
            Console.ReadLine();
        }
    }
}
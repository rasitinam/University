namespace odev8
{
    class Program
    {
        public static void Main(string[] args)
        {
            int toplam = 0;
            int say = 0;
            int[] B = new int[5];

            for (int a = 0; a < B.Length; a++)
            {
                Console.Write((a + 1) + ". Elemanı Gir: ");
                B[a] = Int32.Parse(Console.ReadLine());

                if (B[a] % 10 == 0)
                {
                    say++;
                    toplam += B[a];
                }
            }

            double ortalama = (say == 0) ? 0 : (double)toplam / say;

            Console.WriteLine("Son Rakamı Sıfır Olan Sayı Adedi: " + say);
            Console.WriteLine("Toplam = " + toplam + "  Ortalama = " + ortalama);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
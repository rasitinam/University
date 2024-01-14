namespace odev8
{
    class Program
    {
        public static void Main(string[] args)
        {
            int c;
            int EnBuyuk = 0;
            List<int> yerListesi = new List<int>();
            string[] A = { "Emin", "Emir", "İclal", "Bekir", "Cem", "Arda", "Kaan", "Metin", "Can", "Ramiz" };
            int[] B = { 56, 78, 95, 23, 95, 87, 61, 77, 45, 33 };
            for (c = 0; c < B.Length; c++)
            {
                if (B[c] > EnBuyuk)
                {
                    EnBuyuk = B[c];
                    yerListesi.Clear();
                    yerListesi.Add(c);
                }
                else if (B[c] == EnBuyuk)
                {
                    yerListesi.Add(c);
                }
            }
            Console.WriteLine("En Yüksek Notu Alan Kişiler:");
            foreach (int yer in yerListesi)
            {
                Console.WriteLine(A[yer]);
            }
            Console.WriteLine("En Düşük Notu Alan Kişiler:");
            for (c = 0; c < B.Length; c++) 
            {
                if (B[c] < EnBuyuk)
                {
                    EnBuyuk = B[c];
                    yerListesi.Clear();
                    yerListesi.Add(c);
                }
                else if (B[c] == EnBuyuk)
                {
                    yerListesi.Add(c);
                }
            }
            foreach (int yer in yerListesi)
            {
                Console.WriteLine(A[yer]);
            }
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}

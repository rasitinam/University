class Program
{
    public static void Main(string[] args)
    {
        int sayi, a, e = 1;
        int[] B = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Lütfen {0}. değeri girin: ", i + 1);
            B[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (a = 2; a < B.Length; a++)
        {
            if (Math.Abs(B[0] - B[a]) < Math.Abs(B[0] - B[e])) e = a;
        }
        Console.WriteLine("İlk Sayıya En Yakın Sayı = " + B[e]);
        Console.Write("Press any key to continue . . . ");
        Console.ReadKey(true);
    }
}
namespace ödev4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç tane sayı gireceğinizi yazın=");
            int adet = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;
            int sonuc = 0;
            for (int i = 0; i < adet; i++)
            {
                b = int.Parse(Console.ReadLine());
                a += b;
            }
            sonuc = a / adet;
            Console.WriteLine("Şu kadar adet sayı girdiniz =" + adet + "\n" + "Bu sayıların ortalaması =" + sonuc);
        }
    }
}
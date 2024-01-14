static void Main(string[] args)
{
    double[] a = { 150, 600, 700, 450, 850, 275, 950, 1500, 210, 368 };
    foreach (double burs in a)
    {
        if (burs >= 500)
        {
            Console.WriteLine(burs);
            continue;
        }
        double yeniBurs = (burs * 0.1) + burs;
        yeniBurs += 50;
        Console.WriteLine(yeniBurs);
    }
    Console.Write("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ. . . ");
    Console.ReadKey(true);
}
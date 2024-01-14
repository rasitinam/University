Console.WriteLine("Sayı gir");
int sayi = Convert.ToInt32(Console.ReadLine());
if (sayi > 0 && sayi < 1000)
{
    Console.WriteLine("Uygun sayı girdiniz.");
}
else { Console.WriteLine("Uygun sayı girmediniz."); }
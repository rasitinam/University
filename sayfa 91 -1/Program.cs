/*: Programda önce girilen sayının en çok iki basamaklı ve 1 – 99 arasında
 * pozitif sayı olduğunu kontrol ettiriniz.
Eğer girilen sayı gerekli şartı sağlamıyor ise programın “Uygun değer girmediniz” mesajı ile sonlanmasını sağlayınız.*/
Console.WriteLine("Sayı gir");
int sayi = Convert.ToInt32(Console.ReadLine());
if(sayi > 0 && sayi < 100) 
{
    Console.WriteLine("Uygun sayı girdiniz.");
}
else { Console.WriteLine("Uygun sayı girmediniz."); }
using System;

class Program
{
    // İlk sürüm: İki tam sayıyı toplar
    static int Toplama(int a, int b)
    {
        // Bu fonksiyon iki tam sayıyı alır ve toplamını döndürür.
        return a + b;
    }

    // İkinci sürüm: Üç tam sayıyı toplar
    static int Toplama(int a, int b, int c)
    {
        // Bu fonksiyon üç tam sayıyı alır ve toplamını döndürür.
        return a + b + c;
    }

    // Üçüncü sürüm: Bir dizi (array) tam sayıyı toplar
    static int Toplama(int[] sayilar)
    {
        // Bu fonksiyon bir dizi içindeki tüm tam sayıları toplar.
        int toplam = 0;
        foreach (int sayi in sayilar)
        {
            toplam += sayi;
        }
        return toplam;
    }

    static void Main(string[] args)
    {
        // İlk sürümü test edelim
        Console.WriteLine("İki sayının toplamı: " + Toplama(5, 7)); // 5 + 7 = 12

        // İkinci sürümü test edelim
        Console.WriteLine("Üç sayının toplamı: " + Toplama(3, 6, 9)); // 3 + 6 + 9 = 18

        // Üçüncü sürümü test edelim
        int[] dizi = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Dizideki sayıların toplamı: " + Toplama(dizi)); // 1+2+3+4+5 = 15
    }
}
 








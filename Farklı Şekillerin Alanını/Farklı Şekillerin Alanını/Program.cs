using System;

class Program
{
    // Bir karenin alanını hesaplayan fonksiyon
    static int AlanKare(int kenar)
    {
        // Bu fonksiyon bir karenin alanını hesaplar (kenar * kenar).
        return kenar * kenar;
    }

    // Bir dikdörtgenin alanını hesaplayan fonksiyon
    static int AlanDikdortgen(int uzunKenar, int kisaKenar)
    {
        // Bu fonksiyon bir dikdörtgenin alanını hesaplar (uzun kenar * kısa kenar).
        return uzunKenar * kisaKenar;
    }

    // Bir dairenin alanını hesaplayan fonksiyon
    static double AlanDaire(double yaricap)
    {
        // Bu fonksiyon bir dairenin alanını hesaplar (π * yarıçap * yarıçap).
        // Math.PI sabiti, π'nin değerini temsil eder.
        return Math.PI * yaricap * yaricap;
    }

    static void Main(string[] args)
    {
        // Karenin alanını hesaplayalım
        Console.WriteLine("Karenin alanı: " + AlanKare(4)); // 4 * 4 = 16

        // Dikdörtgenin alanını hesaplayalım
        Console.WriteLine("Dikdörtgenin alanı: " + AlanDikdortgen(5, 7)); // 5 * 7 = 35

        // Dairenin alanını hesaplayalım
        Console.WriteLine("Dairenin alanı: " + AlanDaire(3.0)); // π * 3 * 3 ≈ 28.27
    }
}

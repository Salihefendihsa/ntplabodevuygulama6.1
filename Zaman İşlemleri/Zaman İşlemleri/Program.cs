using System;

struct Zaman
{
    public int Hour { get; private set; }
    public int Minute { get; private set; }

    // Yapıcı metot: Geçersiz saat/dakika değerlerini kontrol ediyor.
    public Zaman(int hour, int minute)
    {
        Hour = (hour >= 0 && hour < 24) ? hour : 0;
        Minute = (minute >= 0 && minute < 60) ? minute : 0;
    }

    // Zamanın toplam dakika değerini döndüren metot.
    public int ToplamDakika()
    {
        return Hour * 60 + Minute;
    }

    // İki zaman nesnesi arasındaki farkı (dakika cinsinden) hesaplayan metot.
    public int FarkDakika(Zaman other)
    {
        return Math.Abs(this.ToplamDakika() - other.ToplamDakika());
    }

    public override string ToString()
    {
        return $"{Hour:D2}:{Minute:D2}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Zaman zaman1 = new Zaman(15, 30);
        Zaman zaman2 = new Zaman(10, 45);
        Zaman zaman3 = new Zaman(25, 70); // Geçersiz değerler, 0:0 yapılır.

        Console.WriteLine("Zaman 1: " + zaman1); // 15:30
        Console.WriteLine("Zaman 2: " + zaman2); // 10:45
        Console.WriteLine("Zaman 3: " + zaman3); // 00:00
        Console.WriteLine("Zaman 1 toplam dakika: " + zaman1.ToplamDakika()); // 930
        Console.WriteLine("Zaman farkı (dakika): " + zaman1.FarkDakika(zaman2)); // 285
    }
}

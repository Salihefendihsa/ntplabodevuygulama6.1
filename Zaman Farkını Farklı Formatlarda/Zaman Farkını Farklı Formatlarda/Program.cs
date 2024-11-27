using System;

class Program
{
    // İlk sürüm: İki tarih arasındaki farkı gün cinsinden döndürür.
    static int TarihFarkiGun(DateTime tarih1, DateTime tarih2)
    {
        // Bu fonksiyon iki tarih arasındaki gün farkını hesaplar.
        return (int)(tarih2 - tarih1).TotalDays;
    }

    // İkinci sürüm: İki tarih arasındaki farkı saat cinsinden döndürür.
    static int TarihFarkiSaat(DateTime tarih1, DateTime tarih2)
    {
        // Bu fonksiyon iki tarih arasındaki saat farkını hesaplar.
        return (int)(tarih2 - tarih1).TotalHours;
    }

    // Üçüncü sürüm: İki tarih arasındaki farkı yıl, ay ve gün cinsinden döndürür.
    static (int yil, int ay, int gun) TarihFarkiYilAyGun(DateTime tarih1, DateTime tarih2)
    {
        // Bu fonksiyon iki tarih arasındaki yıl, ay ve gün farkını ayrı ayrı döndürür.
        int yilFarki = tarih2.Year - tarih1.Year;
        int ayFarki = tarih2.Month - tarih1.Month;
        int gunFarki = tarih2.Day - tarih1.Day;

        // Gün farkı negatifse, bir önceki aydan gün ekleyerek düzenleme yaparız.
        if (gunFarki < 0)
        {
            ayFarki--;
            gunFarki += DateTime.DaysInMonth(tarih2.Year, tarih2.Month - 1);
        }

        // Ay farkı negatifse, bir önceki yıldan ay ekleyerek düzenleme yaparız.
        if (ayFarki < 0)
        {
            yilFarki--;
            ayFarki += 12;
        }

        return (yilFarki, ayFarki, gunFarki);
    }

    static void Main(string[] args)
    {
        // Örnek tarihler
        DateTime tarih1 = new DateTime(2020, 1, 15);
        DateTime tarih2 = new DateTime(2023, 11, 27);

        // İlk sürümü test edelim (gün cinsinden fark)
        Console.WriteLine("Gün farkı: " + TarihFarkiGun(tarih1, tarih2)); // 1412 gün

        // İkinci sürümü test edelim (saat cinsinden fark)
        Console.WriteLine("Saat farkı: " + TarihFarkiSaat(tarih1, tarih2)); // 1412 * 24 saat

        // Üçüncü sürümü test edelim (yıl, ay, gün cinsinden fark)
        var fark = TarihFarkiYilAyGun(tarih1, tarih2);
        Console.WriteLine($"Yıl: {fark.yil}, Ay: {fark.ay}, Gün: {fark.gun}"); // 3 yıl, 10 ay, 12 gün
    }
}

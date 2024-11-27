using System;

class SatrancTahtasi
{
    private string[,] tahtasi;

    public SatrancTahtasi()
    {
        // 8x8 boyutunda satranç tahtası oluşturuyoruz.
        tahtasi = new string[8, 8];
    }

    public string this[int x, int y]
    {
        get
        {
            if (x < 0 || x >= 8 || y < 0 || y >= 8)
            {
                return "Geçersiz kare!";
            }
            return tahtasi[x, y] ?? "Boş"; // Eğer kare boşsa "Boş" döndür.
        }
        set
        {
            if (x < 0 || x >= 8 || y < 0 || y >= 8)
            {
                Console.WriteLine("Geçersiz kare!");
                return;
            }
            tahtasi[x, y] = value; // Kareye taş ekler.
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        SatrancTahtasi tahta = new SatrancTahtasi();

        // Tahta üzerinde taş yerleştirme
        tahta[0, 0] = "Kale";
        tahta[7, 7] = "Şah";

        // Kareleri kontrol etme
        Console.WriteLine(tahta[0, 0]); // Kale
        Console.WriteLine(tahta[7, 7]); // Şah
        Console.WriteLine(tahta[4, 4]); // Boş
        Console.WriteLine(tahta[8, 8]); // Geçersiz kare!
    }
}

using System;

class Otopark
{
    private string[,] parkYerleri;

    public Otopark(int katSayisi, int parkYeriSayisi)
    {
        // Her kat ve park yerini temsil eden bir dizi oluşturuyoruz.
        parkYerleri = new string[katSayisi, parkYeriSayisi];
    }

    public string this[int kat, int parkYeri]
    {
        get
        {
            if (kat < 0 || kat >= parkYerleri.GetLength(0) || parkYeri < 0 || parkYeri >= parkYerleri.GetLength(1))
            {
                return "Geçersiz konum!";
            }
            return parkYerleri[kat, parkYeri] ?? "Empty"; // Eğer park yeri boşsa "Empty" döndür.
        }
        set
        {
            if (kat < 0 || kat >= parkYerleri.GetLength(0) || parkYeri < 0 || parkYeri >= parkYerleri.GetLength(1))
            {
                Console.WriteLine("Geçersiz konum!");
                return;
            }
            parkYerleri[kat, parkYeri] = value; // Belirtilen konuma araç plakası ekler.
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Otopark otopark = new Otopark(3, 5);

        // Araç park etme
        otopark[0, 0] = "34ABC123";
        otopark[2, 4] = "06XYZ789";

        // Park yerlerini kontrol etme
        Console.WriteLine(otopark[0, 0]); // 34ABC123
        Console.WriteLine(otopark[2, 4]); // 06XYZ789
        Console.WriteLine(otopark[1, 1]); // Empty
        Console.WriteLine(otopark[3, 3]); // Geçersiz konum!
    }
}

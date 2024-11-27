using System;

class Kitaplik
{
    private string[] kitaplar;

    public Kitaplik(int boyut)
    {
        // Belirtilen boyutta bir kitap koleksiyonu oluşturuyoruz.
        kitaplar = new string[boyut];
    }

    public string this[int index]
    {
        get
        {
            // Eğer geçersiz bir indeks girilirse hata mesajı döndür.
            if (index < 0 || index >= kitaplar.Length)
            {
                return "Geçersiz indeks!";
            }
            return kitaplar[index] ?? "Boş"; // Kitap yoksa "Boş" döndür.
        }
        set
        {
            if (index < 0 || index >= kitaplar.Length)
            {
                Console.WriteLine("Geçersiz indeks!");
                return;
            }
            kitaplar[index] = value; // Belirtilen indekse kitabı ekler.
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kitaplik kitaplik = new Kitaplik(3);

        // Kitap ekleme
        kitaplik[0] = "Savaş ve Barış";
        kitaplik[1] = "1984";

        // Kitapları kontrol etme
        Console.WriteLine(kitaplik[0]); // Savaş ve Barış
        Console.WriteLine(kitaplik[1]); // 1984
        Console.WriteLine(kitaplik[2]); // Boş
        Console.WriteLine(kitaplik[5]); // Geçersiz indeks!
    }
}

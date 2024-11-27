using System;
using System.Collections.Generic;

class NotSistemi
{
    private Dictionary<string, int> notlar;

    public NotSistemi()
    {
        // Ders adı ve not değerlerini depolamak için bir sözlük kullanıyoruz.
        notlar = new Dictionary<string, int>();
    }

    public int this[string dersAdi]
    {
        get
        {
            if (notlar.ContainsKey(dersAdi))
            {
                return notlar[dersAdi];
            }
            throw new Exception("Bu ders bulunamadı!"); // Eğer ders yoksa hata fırlatır.
        }
        set
        {
            // Ders adı ile ilgili notu ekler ya da günceller.
            notlar[dersAdi] = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        NotSistemi notSistemi = new NotSistemi();

        // Ders notları ekleme
        notSistemi["Matematik"] = 95;
        notSistemi["Fizik"] = 88;

        // Ders notlarına erişme
        Console.WriteLine("Matematik: " + notSistemi["Matematik"]); // 95
        Console.WriteLine("Fizik: " + notSistemi["Fizik"]); // 88

        try
        {
            Console.WriteLine(notSistemi["Kimya"]); // Bu ders bulunamadı!
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

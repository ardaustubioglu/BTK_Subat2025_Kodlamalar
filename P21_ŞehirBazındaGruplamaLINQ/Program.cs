class Musteri
{
    public string Ad { get; set; }
    public string Sehir { get; set; }
}
class Program
{
    static void Main()
    {
        List<Musteri> musteriler = new List<Musteri>
        {
            new Musteri { Ad = "Ahmet", Sehir = "İstanbul" },
            new Musteri { Ad = "Mehmet", Sehir = "Ankara" },
            new Musteri { Ad = "Zeynep", Sehir = "İstanbul" },
            new Musteri { Ad = "Elif", Sehir = "Ankara" }
        };

        // Sorgu Sözdizimi
        var sehireGoreGruplanmis = from m in musteriler
                                   group m by m.Sehir into grup
                                   select new { Sehir = grup.Key, Musteriler = grup };

        // Metot Sözdizimi
        var sehireGoreGruplanmisMetot = musteriler.GroupBy(m => m.Sehir);

        // Sonuçları Yazdır
        foreach (var grup in sehireGoreGruplanmis)
        {
            Console.WriteLine($"Şehir: {grup.Sehir}");
            foreach (var musteri in grup.Musteriler)
            {
                Console.WriteLine($" - {musteri.Ad}");
            }
        }
        Console.WriteLine();
        foreach (var grup in sehireGoreGruplanmisMetot)
        {
            Console.WriteLine($"Şehir: {grup.Key}");
            foreach (var musteri in grup)
            {
                Console.WriteLine($" - {musteri.Ad}");
            }
        }
    }
}


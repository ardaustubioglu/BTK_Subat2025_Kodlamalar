class Calisan
{
    public string Ad { get; set; }
    public double Maas { get; set; }
}

class Program
{
    static void Main()
    {
        List<Calisan> calisanlar = new List<Calisan>
        {
            new Calisan { Ad = "Ali", Maas = 5000 },
            new Calisan { Ad = "Veli", Maas = 6000 },
            new Calisan { Ad = "Ayşe", Maas = 7000 },
            new Calisan { Ad = "Fatma", Maas = 8000 }
        };

        // Sorgu Sözdizimi
        var toplamMaas = (from c in calisanlar select c.Maas).Sum();
        var ortalamaMaas = (from c in calisanlar select c.Maas).Average();
        var enYuksekMaas = (from c in calisanlar select c.Maas).Max();
        var enDusukMaas = (from c in calisanlar select c.Maas).Min();

        // Metot Sözdizimi
        var toplamMaasMetot = calisanlar.Sum(c => c.Maas);
        var ortalamaMaasMetot = calisanlar.Average(c => c.Maas);
        var enYuksekMaasMetot = calisanlar.Max(c => c.Maas);
        var enDusukMaasMetot = calisanlar.Min(c => c.Maas);

        // Sonuçları Yazdır
        Console.WriteLine($"Toplam Maaş: {toplamMaasMetot}");
        Console.WriteLine($"Ortalama Maaş: {ortalamaMaasMetot}");
        Console.WriteLine($"En Yüksek Maaş: {enYuksekMaasMetot}");
        Console.WriteLine($"En Düşük Maaş: {enDusukMaasMetot}");
    }
}



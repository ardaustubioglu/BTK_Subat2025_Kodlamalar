class Musteri
{
    public int MusteriId { get; set; }
    public string Ad { get; set; }
}

class Siparis
{
    public int SiparisId { get; set; }
    public int MusteriId { get; set; }
    public double Tutar { get; set; }
}

class Program
{
    static void Main()
    {
        List<Musteri> musteriler = new List<Musteri>
        {
            new Musteri { MusteriId = 1, Ad = "Ali" },
            new Musteri { MusteriId = 2, Ad = "Veli" },
            new Musteri { MusteriId = 3, Ad = "Ayşe" }
        };

        List<Siparis> siparisler = new List<Siparis>
        {
            new Siparis { SiparisId = 101, MusteriId = 1, Tutar = 250 },
            new Siparis { SiparisId = 102, MusteriId = 1, Tutar = 150 },
            new Siparis { SiparisId = 103, MusteriId = 2, Tutar = 100 }
        };

        // Sorgu Sözdizimi
        var musteriSiparis = from m in musteriler
                             join s in siparisler on m.MusteriId equals s.MusteriId
                             select new { m.Ad, s.Tutar };

        // Metot Sözdizimi
        var musteriSiparisMetot = musteriler.Join(
            siparisler,
            m => m.MusteriId,
            s => s.MusteriId,
            (m, s) => new { m.Ad, s.Tutar });

        Console.WriteLine("Müşteriler ve Siparişleri:");
        foreach (var item in musteriSiparisMetot)
        {
            Console.WriteLine($"{item.Ad} -> {item.Tutar} TL");
        }
    }
}



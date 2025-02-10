
using System;
using System.Collections.Generic;
using System.Linq;

class Musteri
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public string Sehir { get; set; }
}

class Siparis
{
    public int Id { get; set; }
    public int MusteriId { get; set; }
    public double Tutar { get; set; }
    public DateTime Tarih { get; set; }
}

class Program
{
    static void Main()
    {
        // Müşteri Listesi
        List<Musteri> musteriler = new List<Musteri>
        {
            new Musteri { Id = 1, Ad = "Ali", Sehir = "İstanbul" },
            new Musteri { Id = 2, Ad = "Ayşe", Sehir = "Ankara" },
            new Musteri { Id = 3, Ad = "Mehmet", Sehir = "İzmir" },
            new Musteri { Id = 4, Ad = "Zeynep", Sehir = "İstanbul" }
        };

        // Sipariş Listesi
        List<Siparis> siparisler = new List<Siparis>
        {
            new Siparis { Id = 101, MusteriId = 1, Tutar = 500, Tarih = new DateTime(2023, 01, 10) },
            new Siparis { Id = 102, MusteriId = 2, Tutar = 150, Tarih = new DateTime(2023, 02, 15) },
            new Siparis { Id = 103, MusteriId = 1, Tutar = 300, Tarih = new DateTime(2023, 03, 05) },
            new Siparis { Id = 104, MusteriId = 3, Tutar = 700, Tarih = new DateTime(2023, 04, 20) },
            new Siparis { Id = 105, MusteriId = 4, Tutar = 250, Tarih = new DateTime(2023, 05, 25) }
        };

        var musteriSiparisleri = from m in musteriler
                                 join s in siparisler on m.Id equals s.MusteriId
                                 select new { m.Ad, m.Sehir, s.Tutar, s.Tarih };

        Console.WriteLine("\nMüşterilere Ait Siparişler:");
        foreach (var item in musteriSiparisleri)
        {
            Console.WriteLine($"{item.Ad} ({item.Sehir}) -> " +
                $"Sipariş Tutarı: {item.Tutar} TL - " +
                $"Tarih: {item.Tarih.ToShortDateString()}");
        }

        var toplamHarcamalar = from s in siparisler
                               group s by s.MusteriId into g
                               select new
                               {
                                   MusteriId = g.Key,
                                   ToplamHarcama = g.Sum(x => x.Tutar)
                               };

        Console.WriteLine("\nMüşterilerin Toplam Harcamaları:");
        foreach (var item in toplamHarcamalar)
        {
            var musteriAdi = musteriler.First(m => m.Id == item.MusteriId).Ad;
            Console.WriteLine($"{musteriAdi} -> {item.ToplamHarcama} TL");
        }

        var siparisSayilari = from s in siparisler
                              group s by s.MusteriId into g
                              orderby g.Count() descending
                              select new { MusteriId = g.Key, SiparisSayisi = g.Count() };

        var enCokSiparisVeren = siparisSayilari.First();
        var enAzSiparisVeren = siparisSayilari.Last();

        Console.WriteLine("\nEn Çok ve En Az Sipariş Veren Müşteri:");
        Console.WriteLine($"En Çok Sipariş Veren: {musteriler.First(m => m.Id == enCokSiparisVeren.MusteriId).Ad} " +
            $"({enCokSiparisVeren.SiparisSayisi} sipariş)");
        Console.WriteLine($"En Az Sipariş Veren: {musteriler.First(m => m.Id == enAzSiparisVeren.MusteriId).Ad} " +
            $"({enAzSiparisVeren.SiparisSayisi} sipariş)");



        var enPahaliSiparis = siparisler.OrderByDescending(s => s.Tutar).First();
        var enUcuzSiparis = siparisler.OrderBy(s => s.Tutar).First();

        Console.WriteLine("\nEn Pahalı ve En Ucuz Sipariş:");
        Console.WriteLine($"En Pahalı Sipariş: {enPahaliSiparis.Tutar} TL - " +
            $"{enPahaliSiparis.Tarih.ToShortDateString()}");
        Console.WriteLine($"En Ucuz Sipariş: {enUcuzSiparis.Tutar} TL - " +
            $"{enUcuzSiparis.Tarih.ToShortDateString()}");


        var sehirBazliSiparis = from s in siparisler
                                join m in musteriler on s.MusteriId equals m.Id
                                group s by m.Sehir into g
                                select new { Sehir = g.Key, ToplamSiparisSayisi = g.Count() };

        Console.WriteLine("\n Şehirlere Göre Sipariş Dağılımı:");
        foreach (var item in sehirBazliSiparis)
        {
            Console.WriteLine($"{item.Sehir} -> {item.ToplamSiparisSayisi} sipariş");
        }
    }
}

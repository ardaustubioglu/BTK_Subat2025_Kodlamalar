using System;
using System.Collections.Generic;

// Base Class: Kripto Para
class KriptoPara
{
    public string Ad { get; set; }
    public double Fiyat { get; set; }

    public KriptoPara(string ad, double fiyat)
    {
        Ad = ad;
        Fiyat = fiyat;
    }

    public virtual void FiyatGoster()
    {
        
    }
}

// Derived Class: Bitcoin
class Bitcoin : KriptoPara
{
    public Bitcoin(double fiyat) : base("Bitcoin (BTC)", fiyat) { }

    public override void FiyatGoster()
    {
        Console.WriteLine($"{Ad}: {Fiyat} USD");
    }
}

// Derived Class: Ethereum
class Ethereum : KriptoPara
{
    public Ethereum(double fiyat) : base("Ethereum (ETH)", fiyat) { }

    public override void FiyatGoster()
    {
        Console.WriteLine($"{Ad}: {Fiyat} USD");
    }
}

// Kripto Piyasa Simülasyonu
class KriptoPiyasa
{
    private static List<KriptoPara> TumKriptoParalar;

    public KriptoPiyasa()
    {
        // Varsayılan Kripto Paralar Yükleniyor
        TumKriptoParalar = new List<KriptoPara>
        {
            new Bitcoin(45000),
            new Ethereum(3200)
        };
        Console.WriteLine("Kripto Para Piyasası Başlatıldı.");
    }

    public void PiyasayiGoster()
    {
        Console.WriteLine("\nGüncel Kripto Para Fiyatları:");
        foreach (var kripto in TumKriptoParalar)
        {
            kripto.FiyatGoster();
        }
    }

    public void FiyatGuncelle(string kriptoAdi, double yeniFiyat)
    {
        var kripto = TumKriptoParalar.Find(k => k.Ad.Contains(kriptoAdi));
        if (kripto != null)
        {
            kripto.Fiyat = yeniFiyat;
            Console.WriteLine($"{kriptoAdi} fiyatı güncellendi: {yeniFiyat} USD");
        }
        else
        {
            Console.WriteLine($"{kriptoAdi} bulunamadı.");
        }
    }
}

// Ana Program
class Program
{
    static void Main()
    {
        Console.WriteLine("Kripto Piyasa Takip Sistemi\n");

        KriptoPiyasa kp = new KriptoPiyasa();
        // Mevcut Piyasayı Göster
        kp.PiyasayiGoster();

        // Fiyat Güncelleme
        kp.FiyatGuncelle("Bitcoin", 96000);
        kp.FiyatGuncelle("Ethereum", 8300);

        // Güncellenmiş Piyasayı Göster
        kp.PiyasayiGoster();
    }
}

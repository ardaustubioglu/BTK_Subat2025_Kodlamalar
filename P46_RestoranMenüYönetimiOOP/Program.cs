using System;
using System.Collections.Generic;

// Base Class: Menü Öğesi
class MenuItem
{
    public string Ad { get; set; }
    public double Fiyat { get; set; }

    public MenuItem(string ad, double fiyat)
    {
        Ad = ad;
        Fiyat = fiyat;
    }

    public virtual void BilgiGoster()
    {
        Console.WriteLine($"{Ad} - {Fiyat} TL");
    }
}

// Derived Class: Yemek
class Yemek : MenuItem
{
    public string Porsiyon { get; set; }

    public Yemek(string ad, double fiyat, string porsiyon)
        : base(ad, fiyat)
    {
        Porsiyon = porsiyon;
    }

    public override void BilgiGoster()
    {
        Console.WriteLine($"{Ad} - {Fiyat} TL ({Porsiyon} Porsiyon)");
    }
}

// Derived Class: İçecek
class Icecek : MenuItem
{
    public bool SicakMi { get; set; }

    public Icecek(string ad, double fiyat, bool sicakMi)
        : base(ad, fiyat)
    {
        SicakMi = sicakMi;
    }

    public override void BilgiGoster()
    {
        Console.WriteLine($"{Ad} - {Fiyat} TL ({(SicakMi ? "Sıcak" : "Soğuk")})");
    }
}

// Menü Yönetim Sistemi
class MenuYonetimi
{
    private static List<MenuItem> Menu;

    static MenuYonetimi()
    {
        // Başlangıçta varsayılan ürünleri yüklüyoruz
        Menu = new List<MenuItem>
        {
            new Yemek("Pizza", 75, "Orta"),
            new Icecek("Türk Kahvesi", 20, true),
            new Yemek("Burger", 60, "Büyük"),
            new Icecek("Limonata", 25, false)
        };
        Console.WriteLine("Varsayılan Menü Yüklendi.");
    }

    public static void MenuGoster()
    {
        Console.WriteLine("\nGüncel Menü:");
        foreach (var item in Menu)
        {
            item.BilgiGoster();
        }
    }

    public static void UrunEkle(MenuItem yeniUrun)
    {
        Menu.Add(yeniUrun);
        Console.WriteLine($"{yeniUrun.Ad} menüye eklendi!");
    }
}

// Ana Program
class Program
{
    static void Main()
    {
        Console.WriteLine("Restoran Menü Yönetim Sistemi\n");

        // Mevcut menüyü göster
        MenuYonetimi.MenuGoster();

        // Yeni ürün ekleme
        MenuYonetimi.UrunEkle(new Yemek("Lahmacun", 50, "Tek"));
        MenuYonetimi.UrunEkle(new Icecek("Çay", 10, true));

        // Güncellenmiş menüyü göster
        MenuYonetimi.MenuGoster();
    }
}

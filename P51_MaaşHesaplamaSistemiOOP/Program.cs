using System;
using System.Collections.Generic;

// Soyut sınıf (abstract class)
abstract class Calisan
{
    public string Ad { get; set; }
    public double TemelMaas { get; set; }

    public Calisan(string ad, double temelMaas)
    {
        Ad = ad;
        TemelMaas = temelMaas;
    }

    public abstract double MaasHesapla();

    public void BilgiGoster()
    {
        Console.WriteLine($"{Ad} - Aylık Maaş: {MaasHesapla()} TL");
    }
}

// Sabit maaşlı çalışan sınıfı
class SabitMaasliCalisan : Calisan
{
    public SabitMaasliCalisan(string ad, double temelMaas) : base(ad, temelMaas) { }

    public override double MaasHesapla()
    {
        return TemelMaas;
    }
}

// Saat başı ücretle çalışan sınıfı
class SaatlikCalisan : Calisan
{
    public int CalismaSaati { get; set; }
    public double SaatlikUcret { get; set; }

    public SaatlikCalisan(string ad, double saatlikUcret, int calismaSaati)
        : base(ad, saatlikUcret * calismaSaati)
    {
        SaatlikUcret = saatlikUcret;
        CalismaSaati = calismaSaati;
    }

    public override double MaasHesapla()
    {
        return SaatlikUcret * CalismaSaati;
    }
}

// Çalışan yönetim sistemi
class CalisanYonetimi
{
    private List<Calisan> calisanlar = new List<Calisan>();

    public void CalisanEkle(Calisan calisan)
    {
        calisanlar.Add(calisan);
        Console.WriteLine($"{calisan.Ad} sisteme eklendi.");
    }

    public void MaaslariGoster()
    {
        Console.WriteLine("\nÇalışan Maaşları:\n");
        foreach (var calisan in calisanlar)
        {
            calisan.BilgiGoster();
        }
    }
}

// Program Başlangıcı
class Program
{
    static void Main()
    {
        CalisanYonetimi sirket = new CalisanYonetimi();

        // Farklı çalışan türleri ekleniyor
        sirket.CalisanEkle(new SabitMaasliCalisan("Ahmet Yılmaz", 12000));
        sirket.CalisanEkle(new SaatlikCalisan("Mehmet Kaya", 150, 160));

        // Çalışan maaşları gösteriliyor
        sirket.MaaslariGoster();
    }
}

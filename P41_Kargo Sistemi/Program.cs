using System;
using System.Collections.Generic;

// 1️⃣ Müşteri Sınıfı (Encapsulation)
class Musteri
{
    public string Ad { get; private set; }
    public string Adres { get; private set; }

    public Musteri(string ad, string adres)
    {
        Ad = ad;
        Adres = adres;
    }

    public void MusteriBilgisiGoster()
    {
        Console.WriteLine($"Müşteri: {Ad} - Adres: {Adres}");
    }
}

// 2️⃣ Kargo Durumları Enum
enum KargoDurumu
{
    Hazırlanıyor,
    Yolda,
    TeslimEdildi
}

// 3️⃣ Kargo Sınıfı (Encapsulation ve Composition)
class Kargo
{
    public int KargoNo { get; private set; }
    public Musteri Gonderici { get; private set; }
    public Musteri Alici { get; private set; }
    private KargoDurumu durum;
    private List<KargoDurumu> durumGecmisi = new List<KargoDurumu>(); // Durum geçmişi

    public Kargo(int kargoNo, Musteri gonderici, Musteri alici)
    {
        KargoNo = kargoNo;
        Gonderici = gonderici;
        Alici = alici;
        durum = KargoDurumu.Hazırlanıyor; // Varsayılan durum
        durumGecmisi.Add(durum);
    }

    // Durumu değiştir ve geçmişe kaydet
    public void DurumDegistir(KargoDurumu yeniDurum)
    {
        durum = yeniDurum;
        durumGecmisi.Add(durum);
        Console.WriteLine($"Kargo {KargoNo} durumu değişti: {durum}");
    }

    // Kargo Bilgilerini Göster
    public void KargoBilgisiGoster()
    {
        Console.WriteLine($"Kargo No: {KargoNo}");
        Gonderici.MusteriBilgisiGoster();
        Alici.MusteriBilgisiGoster();
        Console.WriteLine($"Güncel Durum: {durum}");
    }

    // Geçmiş Durumları Listele
    public void DurumGecmisiGoster()
    {
        Console.WriteLine($"Kargo {KargoNo} Durum Geçmişi:");
        foreach (var d in durumGecmisi)
        {
            Console.WriteLine($"  - {d}");
        }
    }
}

// 4️⃣ Kargo Takip Sistemi (Composition Kullanımı)
class KargoTakipSistemi
{
    private List<Kargo> kargolar = new List<Kargo>();

    public void KargoEkle(Kargo kargo)
    {
        kargolar.Add(kargo);
    }

    public void TumKargolariListele()
    {
        Console.WriteLine("\nSistemdeki Tüm Kargolar:");
        foreach (var kargo in kargolar)
        {
            kargo.KargoBilgisiGoster();
            Console.WriteLine("------------------------");
        }
    }
}

class Program
{
    static void Main()
    {
        // Müşteriler Tanımlanıyor
        Musteri gonderici = new Musteri("Ali Yılmaz", "İstanbul");
        Musteri alici = new Musteri("Ayşe Demir", "Ankara");

        // Kargo Tanımlanıyor
        Kargo kargo1 = new Kargo(1001, gonderici, alici);

        // Kargo Sistemi Tanımlanıyor
        KargoTakipSistemi sistem = new KargoTakipSistemi();
        sistem.KargoEkle(kargo1);

        // Kargo Bilgilerini Göster
        kargo1.KargoBilgisiGoster();
        Console.WriteLine();

        // Kargo Durumu Güncelleniyor
        kargo1.DurumDegistir(KargoDurumu.Yolda);
        kargo1.DurumDegistir(KargoDurumu.TeslimEdildi);
        Console.WriteLine();

        // Durum Geçmişini Göster
        kargo1.DurumGecmisiGoster();
        Console.WriteLine();

        // Sistemdeki Tüm Kargoları Listele
        sistem.TumKargolariListele();
    }
}

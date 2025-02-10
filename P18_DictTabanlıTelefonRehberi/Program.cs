using System;
using System.Collections.Generic;

class TelefonRehberiDict
{
    // Dictionary: ad -> telefon
    static Dictionary<string, string> rehber = new Dictionary<string, string>();

    static void Main()
    {
        rehber["Ahmet"] = "1234";
        rehber["Ayşe"] = "5678";

        bool devam = true;
        while (devam)
        {
            Console.WriteLine("\n--- Telefon Rehberi (Dictionary) ---");
            Console.WriteLine("1) Ekleme/Güncelleme");
            Console.WriteLine("2) Arama");
            Console.WriteLine("3) Silme");
            Console.WriteLine("4) Listeyi Göster");
            Console.WriteLine("5) Çıkış");
            Console.Write("Seçim: ");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    EkleVeyaGuncelle();
                    break;
                case "2":
                    Ara();
                    break;
                case "3":
                    Sil();
                    break;
                case "4":
                    ListeyiGoster();
                    break;
                case "5":
                    devam = false;
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }
    }

    static void EkleVeyaGuncelle()
    {
        Console.Write("İsim: ");
        string ad = Console.ReadLine();
        Console.Write("Telefon: ");
        string tel = Console.ReadLine();

        // Dictionary'de key yoksa ekler, varsa günceller
        rehber[ad] = tel;
        Console.WriteLine("Kayıt eklendi/güncellendi.");
    }

    static void Ara()
    {
        Console.Write("Aranacak isim: ");
        string aranan = Console.ReadLine();
        if (rehber.ContainsKey(aranan))
        {
            string tel = rehber[aranan];
            Console.WriteLine($"Bulundu: {aranan} - {tel}");
        }
        else
        {
            Console.WriteLine("Kayıt bulunamadı.");
        }
    }

    static void Sil()
    {
        Console.Write("Silinecek isim: ");
        string silinecek = Console.ReadLine();
        if (rehber.Remove(silinecek))
        {
            Console.WriteLine("Kayıt silindi.");
        }
        else
        {
            Console.WriteLine("Kayıt bulunamadı.");
        }
    }

    static void ListeyiGoster()
    {
        Console.WriteLine("--- Rehber Listesi ---");
        foreach (var kvp in rehber)
        {
            Console.WriteLine($"{kvp.Key} - {kvp.Value}");
        }
    }
}

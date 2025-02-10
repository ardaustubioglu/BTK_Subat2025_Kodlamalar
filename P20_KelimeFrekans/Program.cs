using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // 1) Kullanıcıdan bir cümle alalım
        Console.Write("Bir cümle giriniz: ");
        string cumle = Console.ReadLine();

        // 2) Cümleyi kelimelere ayır (boşluk karakterine göre)
        //    Elde edilen dizi elemanlarını List<string> içine atacağız
        string[] kelimeDizisi = cumle.Split(' ');
        List<string> kelimeListesi = new List<string>();

        for (int i = 0; i < kelimeDizisi.Length; i++)
        {
            // Boş string veya tamamen boşluk gibi durumlardan kaçınmak için kontrol:
            if (!string.IsNullOrWhiteSpace(kelimeDizisi[i]))
            {
                // Küçük-büyük harf farkını görmezden gelmek istiyorsak ToLower() kullanabiliriz:
                kelimeListesi.Add(kelimeDizisi[i].ToLower());
            }
        }

        // 3) Kelimelerin tekrar sayılarını tutacak Dictionary<string, int>
        //    Key   -> Kelime
        //    Value -> Sayı (kaç kez geçtiği)
        Dictionary<string, int> frekansSozlugu = new Dictionary<string, int>();

        // 4) Liste üzerindeki her kelime için döngüyle frekans hesaplama
        for (int i = 0; i < kelimeListesi.Count; i++)
        {
            string kelime = kelimeListesi[i];

            // Daha önce eklenmiş mi kontrol edelim
            if (frekansSozlugu.ContainsKey(kelime))
            {
                frekansSozlugu[kelime]++;
            }
            else
            {
                frekansSozlugu.Add(kelime, 1);
            }
        }

        // 5) Sonuçları ekrana yazdıralım
        Console.WriteLine("\n----- Kelime Frekans Sonuçları -----");
        foreach (var kvp in frekansSozlugu)
        {
            // kvp.Key -> kelime
            // kvp.Value -> tekrar sayısı
            Console.WriteLine("Kelime: " + kvp.Key + ", Adet: " + kvp.Value);
        }
    }
}

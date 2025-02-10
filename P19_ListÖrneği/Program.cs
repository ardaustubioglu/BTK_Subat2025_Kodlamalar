public class Program
{
    public static void Main(string[] args)
    {
        // 1) Kullanıcıdan kaç adet not gireceğini al
        Console.Write("Kaç adet not gireceksiniz? ");
        int adet = int.Parse(Console.ReadLine());

        // 2) Notları tutacak List<int>
        List<int> notlar = new List<int>();

        // 3) Klavyeden notları al ve listeye ekle
        for (int i = 0; i < adet; i++)
        {
            Console.Write($"{i + 1}. notu giriniz: ");
            int girilenNot = int.Parse(Console.ReadLine());
            notlar.Add(girilenNot);
        }

        // 4) Listeyi ekrana yazdır
        Console.WriteLine("\nGirilen Notlar:");
        ListeyiYazdir(notlar);

        // 5) Listeyi küçükten büyüğe sırala (Sort)
        notlar.Sort();
        Console.WriteLine("\nKüçükten büyüğe sıralandıktan sonra:");
        ListeyiYazdir(notlar);

        // 6) Listeyi ters çevir (Reverse)
        notlar.Reverse();
        Console.WriteLine("\nTers çevrildikten sonra (büyükten küçüğe olacak):");
        ListeyiYazdir(notlar);

        // 7) BinarySearch ile arama
        //    Sort yapacağımız için öncelikle tekrar küçükten büyüğe sıralıyoruz.
        notlar.Sort();
        Console.WriteLine("\nTekrar küçükten büyüğe sıralandı:");
        ListeyiYazdir(notlar);

        Console.Write("\nAramak istediğiniz notu giriniz: ");
        int aranan = int.Parse(Console.ReadLine());
        int index = notlar.BinarySearch(aranan);

        if (index >= 0)
        {
            Console.WriteLine($"Aradığınız not ({aranan}) listede bulundu. İndeks: {index}");
        }
        else
        {
            Console.WriteLine($"Aradığınız not ({aranan}) listede bulunamadı.");
        }

        // 8) Insert ile belli bir konuma eleman ekleme
        //    Örneğin 0. indekse 100 ekleyelim
        notlar.Insert(0, 100);
        Console.WriteLine("\nEn başa (indeks 0'a) 100 notunu ekledikten sonra:");
        ListeyiYazdir(notlar);

        // 9) GetRange ile bir alt liste alma (örneğin 2. indeksten itibaren 3 eleman)
        //    Dikkat: bu metot, istenen aralık index dışına çıkarsa hata verir, normalde kontrol etmek gerekir.
        if (notlar.Count >= 5) // Güvenlik amaçlı örnek kontrol
        {
            List<int> altListe = notlar.GetRange(2, 3);
            Console.WriteLine("\n2. indeksten itibaren 3 elemanlık alt liste:");
            ListeyiYazdir(altListe);
        }

        // 10) 70 ve üzeri olan notları MANUEL filtreleme
        List<int> yetmisVeUzeri = new List<int>();
        for (int i = 0; i < notlar.Count; i++)
        {
            if (notlar[i] >= 70)
            {
                yetmisVeUzeri.Add(notlar[i]);
            }
        }

        Console.WriteLine("\n70 ve üzeri olan notlar (Manuel filtreleme):");
        ListeyiYazdir(yetmisVeUzeri);
    }

    // Yardımcı metot: List<int> yazdırma
    private static void ListeyiYazdir(List<int> list)
    {
        // Elemanları yan yana yazdırıyoruz.
        // Örneğin: 10 20 30 40
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i] + (i < list.Count - 1 ? " " : ""));
        }
        Console.WriteLine(); // Satır sonu
    }
}

//Birden Fazla Asenkron İşlemi Art Arda Yapma
class Program
{
    static async Task Main()
    {
        Console.WriteLine("Main başlıyor.");

        // Her biri 1 saniye bekleyen üç işi sırayla yapıyoruz.
        await IsYapAsync("İş 1", 1000);
        await IsYapAsync("İş 2", 1000);
        await IsYapAsync("İş 3", 1000);

        Console.WriteLine("Tüm işler bitti. Çıkış için bir tuşa basın.");
        Console.ReadKey();
    }

    static async Task IsYapAsync(string isAdi, int gecikmeMs)
    {
        Console.WriteLine($"{isAdi} başladı.");
        await Task.Delay(gecikmeMs);
        Console.WriteLine($"{isAdi} bitti.");
    }
}

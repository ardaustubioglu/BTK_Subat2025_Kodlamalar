class Program
{
    static async Task Main()
    {
        Console.WriteLine("Main başlıyor.");

        // 1) Asenkron işleri aynı anda başlatıyoruz.
        Task is1 = IsYapAsync("İş 1", 2000);
        Task is2 = IsYapAsync("İş 2", 3000);
        Task is3 = IsYapAsync("İş 3", 1000);

        // 2) İki işi de bekliyoruz.
        await Task.WhenAll(is1, is2, is3);

        Console.WriteLine("Her iki iş de tamamlandı. Çıkış için tuşa basın.");
        Console.ReadKey();
    }

    static async Task IsYapAsync(string isAdi, int gecikmeMs)
    {
        Console.WriteLine($"{isAdi} BAŞLADI. ({gecikmeMs} ms sürecek)");
        await Task.Delay(gecikmeMs);
        Console.WriteLine($"{isAdi} BİTTİ.");
    }
}

class ZodyakBurcu
{
    static void Main()
    {
        Console.Write("Ay (1-12): ");
        int ay = int.Parse(Console.ReadLine());
        Console.Write("Gün (1-31): ");
        int gun = int.Parse(Console.ReadLine());

        // Basit geçerlilik kontrolü
        if (ay < 1 || ay > 12 || gun < 1 || gun > 31)
        {
            Console.WriteLine("Geçersiz tarih girdiniz!");
        }
        else
        {
            string burc = "";

            // Tek seferlik büyük if-else zinciri:
            if ((ay == 3 && gun >= 21) || (ay == 4 && gun <= 20))
                burc = "Koç";
            else if ((ay == 4 && gun >= 21) || (ay == 5 && gun <= 21))
                burc = "Boğa";
            else if ((ay == 5 && gun >= 22) || (ay == 6 && gun <= 21))
                burc = "İkizler";
            else if ((ay == 6 && gun >= 22) || (ay == 7 && gun <= 22))
                burc = "Yengeç";
            // ... diğer burç aralıkları ...
            else if ((ay == 2 && gun >= 19) || (ay == 3 && gun <= 20))
                burc = "Balık";
            else
                burc = "Bilinmeyen aralık"; // ay/gün sınır aşımı vs.

            Console.WriteLine("Burcunuz: " + burc);
        }
    }
}

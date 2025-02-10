class TahminOyunuDenemeSinir
{
    static void Main()
    {
        Random rnd = new Random();
        int gizliSayi = rnd.Next(1, 101);
        int hak = 7; // max 7 deneme
        bool bildi = false;

        while (hak > 0)
        {
            Console.Write($"Tahmininiz (1-100) [Kalan Hak: {hak}]: ");
            int tahmin = int.Parse(Console.ReadLine());

            if (tahmin == gizliSayi)
            {
                Console.WriteLine($"Tebrikler! {7 - hak + 1}. denemede bildiniz.");
                bildi = true;
                break; // döngüyü kır
            }
            else if (tahmin < gizliSayi)
            {
                Console.WriteLine("Daha büyük bir sayı girin!");
            }
            else
            {
                Console.WriteLine("Daha küçük bir sayı girin!");
            }

            hak--;
        }

        if (!bildi)
        {
            Console.WriteLine($"Üzgünüm, bilemediniz. Gizli sayı: {gizliSayi}");
        }
    }
}

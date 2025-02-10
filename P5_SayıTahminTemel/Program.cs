class SayiTahminOyunu
{
    static void Main()
    {
        // 1) Rastgele sayı üretimi
        Random rnd = new Random();
        int gizliSayi = rnd.Next(1, 101); // 1 ile 100 dahil

        int tahmin = 0;  // kullanıcı tahmini

        while (tahmin != gizliSayi)
        {
            Console.Write("Tahmininiz (1-100): ");
            tahmin = int.Parse(Console.ReadLine());

            if (tahmin < gizliSayi)
            {
                Console.WriteLine("Daha büyük bir sayı girin!");
            }
            else if (tahmin > gizliSayi)
            {
                Console.WriteLine("Daha küçük bir sayı girin!");
            }
            else
            {
                Console.WriteLine("Tebrikler, doğru tahmin!");
            }
        }
    }
}

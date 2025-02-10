class UcgenKontrol
{
    static void Main()
    {
        Console.Write("1. kenar: ");
        double s1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("2. kenar: ");
        double s2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("3. kenar: ");
        double s3 = Convert.ToDouble(Console.ReadLine());

        // 1) Kenarlar geçerli mi?
        if (s1 <= 0 || s2 <= 0 || s3 <= 0)
        {
            Console.WriteLine("Geçersiz girdi! Kenar uzunlukları pozitif olmalıdır.");
        }
        else
        {
            // 2) Üçgen kontrolü
            bool ucgenMi = (s1 + s2 > s3) && (s1 + s3 > s2) && (s2 + s3 > s1);
            if (!ucgenMi)
            {
                Console.WriteLine("Bu bir üçgen değildir.");
            }
            else
            {
                // 3) Üçgen tipi
                if (s1 == s2 && s2 == s3)
                {
                    Console.WriteLine("Eşkenar üçgen.");
                }
                else if (s1 == s2 || s2 == s3 || s1 == s3)
                {
                    Console.WriteLine("İkizkenar üçgen.");
                }
                else
                {
                    Console.WriteLine("Çeşitkenar üçgen.");
                }
            }
        }
    }
}

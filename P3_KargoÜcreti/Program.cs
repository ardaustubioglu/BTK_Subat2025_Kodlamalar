class KargoHesap
{
    static void Main()
    {
        Console.Write("Ağırlık (kg): ");
        double agirlik = double.Parse(Console.ReadLine());
        Console.Write("Mesafe (km): ");
        double mesafe = double.Parse(Console.ReadLine());
        Console.Write("Hizmet (1=Standart,2=Hızlı,3=Ekspres): ");
        int hizmet = int.Parse(Console.ReadLine());

        if (agirlik <= 0 || mesafe <= 0)
        {
            Console.WriteLine("Geçersiz girdi! Ağırlık ve mesafe pozitif olmalı.");
        }
        else
        {
            double ucret = mesafe * 0.50 + agirlik * 0.75;
            if (hizmet == 1)
            {
                // Standart
            }
            else if (hizmet == 2)
            {
                // Hızlı → %20 ek
                ucret *= 1.20;
            }
            else if (hizmet == 3)
            {
                // Ekspres → %40 ek
                ucret *= 1.40;
            }
            else
            {
                Console.WriteLine("Geçersiz hizmet türü!");
                return; // Programı bitiriyoruz
            }

            Console.WriteLine("Kargo ücreti = " + ucret + " TL");
        }
    }
}

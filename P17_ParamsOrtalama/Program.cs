using System;

public class Program
{
    public static void Main()
    {
        double ort1 = OrtalamaHesapla(10, 20, 30, 40);
        double ort2 = OrtalamaHesapla(); // Hiç parametre yok
        Console.WriteLine("Ortalama1: " + ort1);
        Console.WriteLine("Ortalama2: " + ort2);
    }

    public static double OrtalamaHesapla(params int[] sayilar)
    {
        if (sayilar.Length == 0)
            return 0; // Hiç sayı yoksa 0

        double toplam = 0;
        foreach (int s in sayilar)
            toplam += s;

        return toplam / sayilar.Length;
    }
}

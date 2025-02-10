using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Dizinin eleman sayısı: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] dizi = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{i}. elemanı girin: ");
            dizi[i] = Convert.ToInt32(Console.ReadLine());
        }

        int max = DiziMaxDeger(dizi);
        Console.WriteLine("Dizinin en büyük değeri: " + max);
        Console.ReadLine();
    }

    static int DiziMaxDeger(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }
}

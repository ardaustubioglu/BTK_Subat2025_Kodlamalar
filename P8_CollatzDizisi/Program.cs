using System;

class CollatzLongestChain
{
    static void Main()
    {
        Console.Write("Collatz için üst sınır N giriniz: ");
        int N = int.Parse(Console.ReadLine());

        int maxChainStart = 1;     // En uzun zinciri başlatan sayı
        int maxChainLength = 1;    // En uzun zincir uzunluğu

        // 1..N arası tüm sayılar için
        for (int x = 1; x <= N; x++)
        {
            // Collatz zincir uzunluğunu hesaplayacağız,
            // fakat metot kullanmadığımız için inline döngü kuruyoruz
            long current = x;  // collatz işleminde büyüyebileceğinden long
            int length = 1;    // en az 1 eleman var (x'in kendisi)

            while (current != 1)
            {
                if (current % 2 == 0)
                {
                    current = current / 2;
                }
                else
                {
                    current = 3 * current + 1;
                }
                length++;
            }

            if (length > maxChainLength)
            {
                maxChainLength = length;
                maxChainStart = x;
            }
        }

        Console.WriteLine($"1..{N} arasında en uzun Collatz zinciri {maxChainStart} sayısında. Uzunluk = {maxChainLength}.");
    }
}

using System;

class SquareFreeNumbers
{
    static void Main()
    {
        Console.Write("N giriniz (square-free listeleyeceğiz): ");
        int N = int.Parse(Console.ReadLine());

        // 1) kareleri dizide tut
        // max kare: en büyük k = floor(sqrt(N))
        int maxK = 1;
        while ((maxK + 1) * (maxK + 1) <= N)
        {
            maxK++;
        }
        int[] squares = new int[maxK]; // 0..maxK-1
        for (int i = 1; i <= maxK; i++)
        {
            squares[i - 1] = i * i;
        }

        // 2) 1..N arası her sayı için kare bölme kontrolü
        Console.WriteLine("Square-free sayılar:");
        for (int x = 1; x <= N; x++)
        {
            bool isSquareFree = true;
            // karelerden herhangi biri x'i bölüyor mu
            for (int idx = 0; idx < maxK; idx++)
            {
                int sq = squares[idx];
                if (sq == 1)
                    continue; // 1^2 =1, her sayıyı böler, es geçelim
                if (sq > x)
                    break; // daha büyük kare, kontrol gereksiz

                if (x % sq == 0)
                {
                    isSquareFree = false;
                    break;
                }
            }

            if (isSquareFree)
            {
                Console.Write(x + " ");
            }
        }
        Console.WriteLine();
    }
}

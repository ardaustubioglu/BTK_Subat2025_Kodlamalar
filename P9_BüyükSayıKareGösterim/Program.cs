using System;

class SumOfTwoSquares
{
    static void Main()
    {
        Console.Write("Bir sayı (N) giriniz: ");
        int N = int.Parse(Console.ReadLine());

        bool foundAny = false;

        // 0..b <= sqrt(N)
        // a her değeri denerken b^2 = N - a^2
        // b = sqrt(N - a^2) -- tamsayı mı kontrol ederiz

        for (int a = 0; a * a <= N; a++)
        {
            int remain = N - a * a;
            // b = sqrt(remain), ve b >= a
            // sqrt'u inline yapıyoruz:
            int b = (int)Math.Floor(Math.Sqrt(remain));

            if (b * b == remain && b >= a)
            {
                Console.WriteLine($"a={a}, b={b} => {a * a} + {b * b} = {N}");
                foundAny = true;
            }
        }

        if (!foundAny)
        {
            Console.WriteLine("Hiç (a,b) çifti bulunamadı.");
        }
    }
}

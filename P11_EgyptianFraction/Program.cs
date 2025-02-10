using System;

class EgyptianFraction
{
    static void Main()
    {
        Console.Write("Pay (A): ");
        int A = int.Parse(Console.ReadLine());
        Console.Write("Payda (B): ");
        int B = int.Parse(Console.ReadLine());

        if (A == 0)
        {
            Console.WriteLine("Sıfır kesir. Bitti.");
            return;
        }

        Console.Write($"{A}/{B} = ");

        while (A != 0)
        {
            // eğer A=1 ise, 1/B'dir.
            if (A == 1)
            {
                Console.Write($"1/{B}");
                break;
            }
            // d = ceil(B/A)
            int d = (int) Math.Ceiling((double)B / A);

            Console.Write($"1/{d} + ");

            // yeni kesir => A/B - 1/d => (A*d - B) / (B*d)
            A = A * d - B;
            B = B * d;

            // sadeleştirmek iyi olabilir, gcd ile
            int x = A, y = B;
            while (y != 0)
            {
                int temp = x % y;
                x = y;
                y = temp;
            }
            int g = Math.Abs(x);
            A /= g;
            B /= g;
        }

        Console.WriteLine();
    }
}

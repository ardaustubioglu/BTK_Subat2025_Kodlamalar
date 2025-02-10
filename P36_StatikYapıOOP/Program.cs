class Matematik
{
    public static double PI = 3.14;

    public static double KareAl(double sayi)
    {
        return sayi * sayi;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine($"PI: {Matematik.PI}");
        Console.WriteLine($"5'in karesi: {Matematik.KareAl(5)}");
    }
}

class Ornek
{
    public Ornek()
    {
        Console.WriteLine("Constructor çalıştı.");
    }

    ~Ornek()
    {
        Console.WriteLine("Destructor çalıştı.");
        Console.Out.Flush();
    }
}

class Program
{
    static void Main()
    {
        for (int i = 0; i < 2; i++)
        {
            var obj = new Ornek();
            obj = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        Console.ReadKey();
    }
}

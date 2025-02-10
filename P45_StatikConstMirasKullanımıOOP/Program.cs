using System;

class BaseClass
{
    static BaseClass()
    {
        Console.WriteLine("BaseClass static constructor çalıştı!");
    }

    public BaseClass()
    {
        Console.WriteLine("BaseClass constructor");
    }
}

class DerivedClass : BaseClass
{
    static DerivedClass()
    {
        Console.WriteLine("DerivedClass static constructor çalıştı!");
    }

    public DerivedClass()
    {
        Console.WriteLine("DerivedClass constructor");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Main metodu çalışıyor...");
        DerivedClass obj = new DerivedClass(); // Statik constructor tetiklenmez!
    }
}

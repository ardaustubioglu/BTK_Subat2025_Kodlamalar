using System;

class Arac
{
    public virtual void Calistir()
    {
        Console.WriteLine("Araç çalıştırıldı.");
    }
}

class Otomobil : Arac
{
    public override void Calistir()
    {
        Console.WriteLine("Otomobil çalıştırıldı.");
    }
}

class Kamyon : Arac
{
    public override void Calistir()
    {
        Console.WriteLine("Kamyon çalıştırıldı.");
    }
}

class Program
{
    static void Main()
    {
        Arac arac1 = new Otomobil();
        Arac arac2 = new Kamyon();

        arac1.Calistir();  // Otomobil çalıştırıldı.
        arac2.Calistir();  // Kamyon çalıştırıldı.
    }
}

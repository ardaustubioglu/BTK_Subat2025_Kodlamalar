using System;

class Arac
{
    public virtual void Calistir()
    {
        Console.WriteLine("Araç çalıştırılıyor.");
    }
}

class Otomobil : Arac
{
    public sealed override void Calistir()
    {
        Console.WriteLine("Otomobil çalıştırılıyor.");
    }
}

// Alt sınıf, sealed metodu tekrar override edemez
class ElektrikliAraba : Otomobil
{
    // Bu satır hata verecektir!
    // public override void Calistir() { Console.WriteLine("Elektrikli araba çalıştırılıyor."); }
}

class Program
{
    static void Main()
    {
        Arac arac = new Otomobil();
        arac.Calistir();  // Otomobil çalıştırılıyor.
    }
}

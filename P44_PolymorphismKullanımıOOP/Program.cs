using System;

class Hayvan  // Base Class
{
    public virtual void SesCikar()
    {
        Console.WriteLine("Hayvan sesi çıkarıyor.");
    }
}

class Kedi : Hayvan  // Derived Class
{
    public override void SesCikar()
    {
        Console.WriteLine("Miyav!");
    }
}

class Kopek : Hayvan  // Derived Class
{
    public override void SesCikar()
    {
        Console.WriteLine("Hav Hav!");
    }
}

class Program
{
    static void Main()
    {
        Hayvan hayvan = new Hayvan();
        Hayvan hayvan1 = new Kedi();
        Hayvan hayvan2 = new Kopek();

        hayvan.SesCikar();  // Hayvan sesi çıkarıyor.
        hayvan1.SesCikar();  // Miyav!
        hayvan2.SesCikar();  // Hav Hav!
    }
}

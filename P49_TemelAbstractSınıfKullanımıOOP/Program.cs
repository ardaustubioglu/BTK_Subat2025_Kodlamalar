using System;

// Soyut sınıf (abstract class)
abstract class Hayvan
{
    public string Ad { get; set; }
    public abstract void SesCikar(); // Soyut metot
}

// Derived (türetilmiş) sınıf
class Kedi : Hayvan
{
    public override void SesCikar()
    {
        Console.WriteLine($"{Ad} Miyavlıyor!");
    }
}

// Derived (türetilmiş) sınıf
class Kopek : Hayvan
{
    public override void SesCikar()
    {
        Console.WriteLine($"{Ad} Havlıyor!");
    }
}

class Program
{
    static void Main()
    {
        Hayvan hayvan1 = new Kedi() { Ad = "Minnak" };
        Hayvan hayvan2 = new Kopek() { Ad = "Karabaş" };

        hayvan1.SesCikar();  // Minnak Miyavlıyor!
        hayvan2.SesCikar();  // Karabaş Havlıyor!
    }
}

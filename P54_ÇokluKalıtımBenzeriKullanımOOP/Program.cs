using System;

interface IA
{
    void MetotA();
}

interface IB
{
    void MetotB();
}

class C : IA, IB
{
    public void MetotA() {
        Console.WriteLine("Metot A çalıştı.");
    } 
    public void MetotB() => Console.WriteLine("Metot B çalıştı.");
}

class Program
{
    static void Main()
    {
        C nesne = new C();
        nesne.MetotA();
        nesne.MetotB();
    }
}

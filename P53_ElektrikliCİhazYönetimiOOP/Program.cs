using System;

// Interface tanımı
interface ICihaz
{
    void Ac();
    void Kapat();
}

// Interface uygulayan sınıflar
class Bilgisayar : ICihaz
{
    public void Ac() => Console.WriteLine("Bilgisayar açıldı.");
    public void Kapat() => Console.WriteLine("Bilgisayar kapatıldı.");
}

class Telefon : ICihaz
{
    public void Ac() => Console.WriteLine("Telefon açıldı.");
    public void Kapat() => Console.WriteLine("Telefon kapatıldı.");
}

class Program
{
    static void Main()
    {
        ICihaz cihaz1 = new Bilgisayar();
        ICihaz cihaz2 = new Telefon();

        cihaz1.Ac();
        cihaz2.Ac();
        cihaz1.Kapat();
        cihaz2.Kapat();
    }
}

using System;

// Soyut sınıf
abstract class BankaHesabi
{
    public string HesapSahibi { get; set; }
    public double Bakiye { get; protected set; }

    public BankaHesabi(string hesapSahibi, double bakiye)
    {
        HesapSahibi = hesapSahibi;
        Bakiye = bakiye;
    }

    public abstract void ParaCek(double miktar);  // Soyut metot

    public void BakiyeGoster()
    {
        Console.WriteLine($"Hesap Sahibi: {HesapSahibi}, Bakiye: {Bakiye} TL");
    }
}

// Derived Class (Türetilmiş Sınıf)
class VadesizHesap : BankaHesabi
{
    public VadesizHesap(string hesapSahibi, double bakiye) : base(hesapSahibi, bakiye) { }

    public override void ParaCek(double miktar)
    {
        if (Bakiye >= miktar)
        {
            Bakiye -= miktar;
            Console.WriteLine($"{miktar} TL çekildi. Güncel Bakiye: {Bakiye} TL");
        }
        else
        {
            Console.WriteLine("Yetersiz bakiye!");
        }
    }
}

class Program
{
    static void Main()
    {
        VadesizHesap hesap = new VadesizHesap("Ahmet Yılmaz", 5000);
        hesap.BakiyeGoster();
        hesap.ParaCek(2000);
        hesap.BakiyeGoster();
    }
}

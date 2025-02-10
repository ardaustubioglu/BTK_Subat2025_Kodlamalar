using System;

// Kredi Kartı Ödeme Arayüzü
interface ICreditCardPayment
{
    void KartlaOdeme(double miktar);
}

// Banka Havalesi Ödeme Arayüzü
interface IBankTransferPayment
{
    void HavaleYap(double miktar);
}

// Kredi Kartı Ödeme Sınıfı
class CreditCardPayment : ICreditCardPayment
{
    public void KartlaOdeme(double miktar)
    {
        Console.WriteLine($"Kredi Kartı ile {miktar} TL ödeme yapıldı.");
    }
}

// Banka Havalesi Ödeme Sınıfı
class BankTransferPayment : IBankTransferPayment
{
    public void HavaleYap(double miktar)
    {
        Console.WriteLine($"Banka Havalesi ile {miktar} TL gönderildi.");
    }
}

// Ödeme Yönetim Sistemi
class OdemeYoneticisi
{
    public void OdemeYap(ICreditCardPayment kart, double miktar)
    {
        kart.KartlaOdeme(miktar);
    }

    public void HavaleYap(IBankTransferPayment havale, double miktar)
    {
        havale.HavaleYap(miktar);
    }
}

class Program
{
    static void Main()
    {
        OdemeYoneticisi odemeYoneticisi = new OdemeYoneticisi();

        ICreditCardPayment kartOdeme = new CreditCardPayment();
        IBankTransferPayment bankaOdeme = new BankTransferPayment();

        odemeYoneticisi.OdemeYap(kartOdeme, 500);
        odemeYoneticisi.HavaleYap(bankaOdeme, 1000);
    }
}

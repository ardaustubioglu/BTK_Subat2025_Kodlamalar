class Urun
{
    public string Ad;
    public double Fiyat;

    // Varsayılan Constructor
    public Urun()
    {
        Ad = "Bilinmiyor";
        Fiyat = 0;
    }

    // Parametreli Constructor
    public Urun(string ad, double fiyat)
    {
        Ad = ad;
        Fiyat = fiyat;
    }

    public void BilgiGoster()
    {
        Console.WriteLine($"Ürün: {Ad}, Fiyat: {Fiyat} TL");
    }
}

class Program
{
    static void Main()
    {
        Urun urun1 = new Urun();
        Urun urun2 = new Urun("Laptop", 15000);

        urun1.BilgiGoster();
        urun2.BilgiGoster();
    }
}

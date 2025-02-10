class Ogrenci
{
    public string Ad;
    public int Yas;

    // Yapılandırıcı (Constructor)
    public Ogrenci(string ad, int yas)
    {
        Ad = ad;
        Yas = yas;
    }

    public void BilgiGoster()
    {
        Console.WriteLine($"Ad: {Ad}, Yaş: {Yas}");
    }
}

class Program
{
    static void Main()
    {
        Ogrenci ogrenci1 = new Ogrenci("Ahmet", 20);
        ogrenci1.BilgiGoster();
    }
}

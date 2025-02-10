class Ders
{
    public string Ad;
    public Ders(string ad)
    {
        Ad = ad;
    }
}

class Ogrenci
{
    public string Ad;
    public Ders OgrDersi;

    public Ogrenci(string ad, Ders ders)
    {
        Ad = ad;
        OgrDersi = ders;
    }

    public void BilgiGoster()
    {
        Console.WriteLine($"{Ad}, {OgrDersi.Ad} dersini alıyor.");
    }
}

class Program
{
    static void Main()
    {
        Ders ders1 = new Ders("Matematik");
        Ogrenci ogrenci1 = new Ogrenci("Zeynep", ders1);
        ogrenci1.BilgiGoster();
    }
}

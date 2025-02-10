class Arac
{
    public string Marka { get; set; }
    public int ModelYili { get; set; }

    public Arac(string marka, int modelYili)
    {
        Marka = marka;
        ModelYili = modelYili;
    }

    public void BilgiGoster()
    {
        Console.WriteLine($"Marka: {Marka}, Model Yılı: {ModelYili}");
    }
}

class Otomobil : Arac
{
    public int KapiSayisi { get; set; }

    public Otomobil(string marka, int modelYili, int kapiSayisi) : base(marka, modelYili)
    {
        KapiSayisi = kapiSayisi;
    }

    public void OtomobilBilgiGoster()
    {
        BilgiGoster();
        Console.WriteLine($"Kapı Sayısı: {KapiSayisi}");
    }
}

class Program
{
    static void Main()
    {
        Otomobil oto = new Otomobil("BMW", 2023, 4);
        oto.OtomobilBilgiGoster();
    }
}

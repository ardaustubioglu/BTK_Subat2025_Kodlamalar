using System;

class Insan  // Base Class
{
    public string Ad { get; set; }
    public int Yas { get; set; }

    public void BilgiGoster()
    {
        Console.WriteLine($"Ad: {Ad}, Yaş: {Yas}");
    }
}

class Ogrenci : Insan  // Derived Class
{
    public int OgrenciNo { get; set; }

    public void OgrenciBilgiGoster()
    {
        BilgiGoster();
        Console.WriteLine($"Öğrenci Numarası: {OgrenciNo}");
    }
}

class Program
{
    static void Main()
    {
        Ogrenci ogr = new Ogrenci();
        ogr.Ad = "Ahmet";
        ogr.Yas = 21;
        ogr.OgrenciNo = 12345;

        ogr.OgrenciBilgiGoster();
    }
}

class Urun
{
    private double fiyat;

    public double Fiyat
    {
        get { return fiyat; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("HATA: Fiyat negatif olamaz!");
            }
            else
            {
                fiyat = value;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Urun urun1 = new Urun();
        urun1.Fiyat = -50;  //  Hata verecek
        Console.WriteLine($"Ürün Fiyatı: {urun1.Fiyat}");
        urun1.Fiyat = 100;  //  Doğru kullanım
        Console.WriteLine($"Ürün Fiyatı: {urun1.Fiyat}");
    }
}

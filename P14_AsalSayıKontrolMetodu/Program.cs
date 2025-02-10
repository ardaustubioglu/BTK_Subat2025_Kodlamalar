bool AsalMi(int sayi)
{
    if (sayi <= 1)
        return false;
    if (sayi == 2)
        return true;
    if (sayi % 2 == 0)
        return false;

    // sayının kareköküne kadar kontrol
    int sinir = (int)Math.Sqrt(sayi);
    for (int i = 3; i <= sinir; i += 2)
    {
        if (sayi % i == 0)
            return false;
    }
    return true;
}

// Kullanım Örneği
Console.Write("Bir sayı giriniz: ");
int giris = Convert.ToInt32(Console.ReadLine());
bool sonuc = AsalMi(giris);

if (sonuc)
    Console.WriteLine($"{giris} asaldır.");
else
    Console.WriteLine($"{giris} asal değildir.");

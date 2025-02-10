List<string> metinler = new List<string>
{
    "LINQ öğrenmek harika!",
    "C# programlama dili LINQ destekler.",
    "LINQ kullanarak veri işleme yapabiliriz.",
    "Bu cümlede LINQ geçmiyor.",
    "LINQ kullanarak veri işleme yapabiliriz.",
    "Buraya ne yazacağımı bilemedim:)"
};

// Sorgu Sözdizimi
var buyukHarfMetinler = from m in metinler
                        select m.ToUpper();

// Metot Sözdizimi
var buyukHarfMetinlerMetot = metinler.Select(m => m.ToUpper());

Console.WriteLine("Büyük Harfli Metinler:");
foreach (var c in buyukHarfMetinlerMetot)
    Console.WriteLine(c);

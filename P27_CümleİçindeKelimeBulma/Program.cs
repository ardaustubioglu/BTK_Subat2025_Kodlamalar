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
var linqIcerenler = from m in metinler
                    where m.Contains("LINQ")
                    select m;

// Metot Sözdizimi
var linqIcerenlerMetot = metinler.Where(m => m.Contains("LINQ"));

// Sonuçları Yazdır
foreach (var c in linqIcerenler)
    Console.WriteLine(c);
Console.WriteLine();
Console.WriteLine("LINQ İçeren Cümleler:");
foreach (var c in linqIcerenlerMetot)
    Console.WriteLine(c);

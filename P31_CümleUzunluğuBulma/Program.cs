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
var uzunluklar = from m in metinler
                 select new { Metin = m, Uzunluk = m.Length };

// Metot Sözdizimi
var uzunluklarMetot = metinler.Select(m => new { Metin = m, Uzunluk = m.Length });

Console.WriteLine("Metin Uzunlukları:");
foreach (var c in uzunluklarMetot)
    Console.WriteLine($"{c.Metin} -> Uzunluk: {c.Uzunluk}");

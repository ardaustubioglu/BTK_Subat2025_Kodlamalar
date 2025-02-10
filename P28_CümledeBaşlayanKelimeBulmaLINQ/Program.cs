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
var cSharpIleBaslayan = from m in metinler
                        where m.StartsWith("C#")
                        select m;

// Metot Sözdizimi
var cSharpIleBaslayanMetot = metinler.Where(m => m.StartsWith("C#"));

Console.WriteLine("C# ile Başlayan Cümleler:");
foreach (var c in cSharpIleBaslayanMetot)
    Console.WriteLine(c);

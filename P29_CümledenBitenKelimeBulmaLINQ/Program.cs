List<string> metinler = new List<string>
{
    "LINQ öğrenmek harika!",
    "C# programlama dili LINQ destekler.",
    "LINQ kullanarak veri işleme yapabiliriz.",
    "Bu cümlede LINQ geçmiyor."
};

// Sorgu Sözdizimi
var noktaIleBiten = from m in metinler
                    where m.EndsWith(".")
                    select m;

// Metot Sözdizimi
var noktaIleBitenMetot = metinler.Where(m => m.EndsWith("."));

Console.WriteLine("Nokta ile Biten Cümleler:");
foreach (var c in noktaIleBitenMetot)
    Console.WriteLine(c);

List<int> sayilar = new List<int> { 10, 20, 30, 40, 50 };

// Sorgu Sözdizimi
var toplam = (from s in sayilar select s).Sum();
var ortalama = (from s in sayilar select s).Average();
var maksimum = (from s in sayilar select s).Max();
var minimum = (from s in sayilar select s).Min();

// Metot Sözdizimi
var toplamMetot = sayilar.Sum();
var ortalamaMetot = sayilar.Average();
var maksimumMetot = sayilar.Max();
var minimumMetot = sayilar.Min();

// Sonuçları Yazdır
Console.WriteLine($"Toplam: {toplamMetot}");
Console.WriteLine($"Ortalama: {ortalamaMetot}");
Console.WriteLine($"Maksimum: {maksimumMetot}");
Console.WriteLine($"Minimum: {minimumMetot}");

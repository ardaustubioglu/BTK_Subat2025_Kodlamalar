List<int> sayilar = new List<int> { 1, 2, 3, 3, 4, 4, 5 };

// Sorgu Sözdizimi
var benzersizSayilar = (from s in sayilar select s).Distinct();

// Metot Sözdizimi
var benzersizSayilarMetot = sayilar.Distinct();

// Sonuçları Yazdır
Console.WriteLine("Benzersiz Sayılar: " + string.Join(", ", benzersizSayilar));
Console.WriteLine();
Console.WriteLine("Benzersiz Sayılar: " + string.Join(", ", benzersizSayilarMetot));

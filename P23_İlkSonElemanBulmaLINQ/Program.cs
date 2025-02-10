List<int> sayilar = new List<int> { 10, 20, 30, 40, 50 };

// İlk Eleman
var ilk = sayilar.FirstOrDefault();

// Son Eleman
var son = sayilar.LastOrDefault();

Console.WriteLine($"İlk Eleman: {ilk}");
Console.WriteLine($"Son Eleman: {son}");

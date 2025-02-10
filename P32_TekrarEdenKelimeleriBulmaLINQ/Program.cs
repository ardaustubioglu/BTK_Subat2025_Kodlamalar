string metin = "C# LINQ ile LINQ sorguları yapmak çok kolay. LINQ çok güçlüdür.";
List<string> kelimeler = metin.Split(' ').ToList();

// Tekrar eden kelimeleri gruplayarak say
var tekrarEdenKelimeler = from k in kelimeler
                          group k by k into g
                          where g.Count() > 1
                          select new { Kelime = g.Key, Sayı = g.Count() };

Console.WriteLine("Tekrar Eden Kelimeler:");
foreach (var item in tekrarEdenKelimeler)
    Console.WriteLine($"{item.Kelime} -> {item.Sayı} kez geçti.");

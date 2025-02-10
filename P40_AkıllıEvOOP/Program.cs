using System;
using System.Collections.Generic;

// Cihaz Sınıfı
class Cihaz
{
    public string Ad { get; set; }
    private bool Acik;
    private double enerjiTuketimi; // kW cinsinden

    public Cihaz(string ad, double enerji)
    {
        Ad = ad;
        enerjiTuketimi = enerji;
        Acik = false;
    }

    public void Ac()
    {
        if (!Acik)
        {
            Acik = true;
            Console.WriteLine($"{Ad} açıldı.");
        }
    }

    public void Kapat()
    {
        if (Acik)
        {
            Acik = false;
            Console.WriteLine($"{Ad} kapatıldı.");
        }
    }

    public double EnerjiTuket()
    {
        return Acik ? enerjiTuketimi : 0;
    }
}

// Ev Sınıfı (Composition Kullanımı)
class Ev
{
    private List<Cihaz> cihazlar = new List<Cihaz>();

    public void CihazEkle(Cihaz cihaz)
    {
        cihazlar.Add(cihaz);
    }

    public void TumCihazlariAc()
    {
        foreach (var cihaz in cihazlar)
        {
            cihaz.Ac();
        }
    }

    public void TumCihazlariKapat()
    {
        foreach (var cihaz in cihazlar)
        {
            cihaz.Kapat();
        }
    }

    public void EnerjiRaporu()
    {
        double toplamEnerji = 0;
        foreach (var cihaz in cihazlar)
        {
            toplamEnerji += cihaz.EnerjiTuket();
        }
        Console.WriteLine($"Toplam Enerji Tüketimi: {toplamEnerji} kW");
    }
}

class Program
{
    static void Main()
    {
        Ev ev = new Ev();
        Cihaz lamba = new Cihaz("Lamba", 0.05);
        Cihaz isitici = new Cihaz("Isıtıcı", 1.5);

        ev.CihazEkle(lamba);
        ev.CihazEkle(isitici);

        ev.TumCihazlariAc();
        ev.EnerjiRaporu();
        ev.TumCihazlariKapat();
    }
}

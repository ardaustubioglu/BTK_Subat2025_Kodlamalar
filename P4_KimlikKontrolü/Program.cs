class KimlikKontrol
{
    static void Main()
    {
        Console.Write("Kimlik Numarası (11 haneli): ");
        string tckn = Console.ReadLine();

        // 1) Uzunluk kontrolü
        if (tckn.Length != 11)
        {
            Console.WriteLine("Geçersiz kimlik no! (11 haneli olmalı)");
        }
        else
        {
            // 2) Tümü rakam mı?
            bool hepsiRakam = true;
            // Döngüsüz yaklaşım: TryParse uzunluğundaki string'i 'long' veya 'ulong' çevirmeye çalışmak:

            if (!ulong.TryParse(tckn, out _))
            {
                Console.WriteLine("Geçersiz! Rakam dışı karakter bulunuyor.");
            }
            else
            {
                // 3) İlk karakter '0' olmamalı
                if (tckn[0] == '0')
                {
                    Console.WriteLine("Geçersiz! İlk hane '0' olamaz.");
                }
                else
                {
                    // 4) Son rakam çift mi?
                    char sonChar = tckn[10]; // index 10
                    int sonRakam = sonChar - '0';
                    if (sonRakam % 2 != 0)
                    {
                        Console.WriteLine("Geçersiz! Son rakam çift olmalı.");
                    }
                    else
                    {
                        Console.WriteLine("Kimlik geçerli.");
                    }
                }
            }
        }
    }
}

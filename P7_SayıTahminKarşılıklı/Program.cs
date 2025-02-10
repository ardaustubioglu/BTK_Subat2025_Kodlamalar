using System;

class SayiTahminYarisi
{
    static void Main()
    {
        // Bilgisayar kendi sayısını (pcNumber) rastgele seçer.
        Random rnd = new Random();
        int pcNumber = rnd.Next(1, 101);

        // Bilgisayarın ikili arama için kullanacağı aralık
        int min = 1;
        int max = 100;

        bool userKazandi = false;
        bool pcKazandi = false;

        int roundCount = 0; // kaç tur oynandığını izlemek için (isteğe bağlı)

        while (!userKazandi && !pcKazandi)
        {
            roundCount++;
            Console.WriteLine($"\n--- {roundCount}. Tur ---");

            // 1) Kullanıcı tahmini
            Console.Write($"Kullanıcı, PC'nin sayısını tahmin et (1-100): ");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess == pcNumber)
            {
                Console.WriteLine("Tebrikler! PC'nin tuttuğu sayıyı bildiniz. Kullanıcı kazandı!");
                userKazandi = true;
                break; // oyun biter
            }
            else if (userGuess < pcNumber)
            {
                Console.WriteLine("Daha büyük bir sayı deneyin!");
            }
            else // userGuess > pcNumber
            {
                Console.WriteLine("Daha küçük bir sayı deneyin!");
            }

            // 2) Bilgisayar tahmini (ikili arama mantığı)
            if (min > max)
            {
                Console.WriteLine("Bilgisayar: Aralık bozuldu, demek ki yanlış yönlendirme oldu. Çıkış!");
                break;
            }

            int pcGuess = (min + max) / 2;
            Console.WriteLine($"Bilgisayarın tahmini: {pcGuess}");

            // Kullanıcının geri bildirimi
            // B => (benim sayı) userNumber > pcGuess
            // K => userNumber < pcGuess
            // D => userNumber == pcGuess
            Console.Write("Geri bildirim (B=Benim sayı Daha Büyük, K=Benim sayı Daha Küçük, D=Doğru): ");
            string feedback = Console.ReadLine().ToUpper();

            if (feedback == "D")
            {
                Console.WriteLine($"Bilgisayar, {roundCount}. turda buldu! PC kazandı!");
                pcKazandi = true;
            }
            else if (feedback == "B")
            {
                // userNumber > pcGuess
                min = pcGuess + 1;
            }
            else if (feedback == "K")
            {
                // userNumber < pcGuess
                max = pcGuess - 1;
            }
            else
            {
                // Geçersiz giriş
                Console.WriteLine("Geçersiz yanıt! Bilgisayara yanlış bilgi verilirse oyun bozulabilir.");
                // Bu turu pas geçiyoruz, ama aralığı değiştirmiyoruz.
            }
        }

        if (!userKazandi && !pcKazandi)
        {
            // Buraya geldiysek, ya döngü break oldu ya da aralık bozuldu.
            Console.WriteLine("Oyun sonlandı. Kimse kazanamadı veya yanlış yönlendirme yapıldı.");
        }
    }
}

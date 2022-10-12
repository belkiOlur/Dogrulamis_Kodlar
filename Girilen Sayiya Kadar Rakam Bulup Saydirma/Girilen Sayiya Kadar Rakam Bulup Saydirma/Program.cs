internal class Program
{
    private static void Main(string[] args)
    {


    ilk:
        int sayac = 0;
        int sayi = 0;
        double val = 0;
        string gir = "";
  



        Console.Write("En Fazla 4 Basamaklı Sayı giriniz =");
        ConsoleKeyInfo karakter;
        do
        {
            karakter = Console.ReadKey(true);
            if (karakter.Key != ConsoleKey.Backspace)
            {
                bool kontrol = double.TryParse(karakter.KeyChar.ToString(), out val);
                if (kontrol)
                {
                    gir += karakter.KeyChar;
                    Console.Write(karakter.KeyChar);
                }
            }
            else

            {
                if (karakter.Key == ConsoleKey.Backspace && gir.Length > 0)
                {
                    gir = gir.Substring(0, gir.Length - 1);
                    Console.Write("\b \b");
                }
            }
            if (karakter.Key == ConsoleKey.Enter && gir.Length <= 0)
            {
                Console.Write("\n");
                Console.Write("Boş Geçilemez Lütfen En Fazla 4 Basamaklı Bir Sayı Giriniz \n");
                goto ilk;
            }
            if (gir.Length > 4)
            {
                Console.Write("\nLütfen En Fazla 4 Basamaklı Bir Sayı Giriniz\n");
                Console.ReadKey(true);
                Console.Clear();
                goto ilk;
            }
        }
        while (karakter.Key != ConsoleKey.Enter);
        Console.WriteLine("");
        int x = Convert.ToInt32(gir);
        
    enbas:
        double val1 = 0;
        string gir1 = "";
        int y = 0;
        Console.Write("Aranacak Rakamı Giriniz =");
        ConsoleKeyInfo karakter1;
        do
        {
            karakter1 = Console.ReadKey(true);
            if (karakter1.Key != ConsoleKey.Backspace)
            {
                bool kontrol = double.TryParse(karakter1.KeyChar.ToString(), out val1);
                if (kontrol)
                {
                    gir1 += karakter1.KeyChar;
                    Console.Write(karakter1.KeyChar);
                }
            }
            else

            {
                if (karakter1.Key == ConsoleKey.Backspace && gir1.Length > 0)
                {
                    gir1 = gir1.Substring(0, gir1.Length - 1);
                    Console.Write("\b \b");
                }
            }
            if (karakter1.Key == ConsoleKey.Enter && gir1.Length <= 0)
            {
                Console.Write("\n");
                Console.Write("Boş Geçilemez Lütfen Bir Rakam Giriniz \n");
                goto enbas;
            }
            if (gir1.Length > 1)
            {
                Console.Write("\nRakam Tek Basamaklı Sayıdır. Lütfen Bir Rakam Giriniz\n");
                Console.ReadKey(true);
                goto enbas;
            }
        }
        while (karakter1.Key != ConsoleKey.Enter);
        Console.WriteLine("");
        y = Convert.ToInt32(gir1);


        for (sayi = 0; sayi <= x; sayi++)
        {
            int birler = (sayi % 10);
            int onlar = ((sayi % 100 - birler) / 10);
            int yuzler = ((sayi - onlar * 10 - birler) / 100);
            int binler = ((sayi - yuzler * 100 - onlar * 10 - birler) / 1000);
            
            if (birler == y)
            {
                sayac++;
            }
            if (onlar == y)
            {
                sayac++;
            }
            if (yuzler == y)
            {
                sayac++;
            }
            if (binler == y)
            {
                sayac++;
            }           

        }
        if (y == 0 && x < 10)
        {
            int sayi2 = 0;
            sayi2 = (x + 1) * 3;
            sayac -= sayi2;
        }
        if (y == 0 && x >= 10 && x < 100)
        {
            int sayi2 = 0;
            sayi2 = 30 + ((x - 10) + 1) * 2;
            sayac -= sayi2;
        }
        if (y == 0 && x >= 100 && x < 1000)
        {
            int sayi2 = 0;
            sayi2 = 210 + ((x - 100) + 1);
            sayac -= sayi2;
        }
        if (y == 0 && x >= 1000 && x < 10000)
        {
            int sayi2 = 0;
            sayi2 = 1110 + ((x - 1000) + 1) * 0;
            sayac -= sayi2;
        }
        Console.Write("1'den " + x + "'e kadar " + y + " rakamı adeti = " + sayac + "\n");
        Console.Write("______________________________________\n");
        Console.Write("Tekrar Denemek İçin Bir Tuşa Basınız\n");
        Console.Write("\n");
        Console.ReadKey(true);
        goto ilk;
    }
}
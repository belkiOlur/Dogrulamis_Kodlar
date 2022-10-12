using System.Text.Json.Serialization;
int sayac = 0;
ilk:
double val = 0;
string gir = "";
int x = 0;
Console.Write("En Fazla 5 Basamaklı Sayı giriniz =");
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
            gir = gir.Substring(0, (gir.Length - 1));
            Console.Write("\b \b");
        }
    }
    if (karakter.Key == ConsoleKey.Enter && gir.Length <= 0)
    {
        Console.Write("\n");
        Console.Write("Boş Geçilemez Lütfen En Fazla 5 Basamaklı Bir Sayı Giriniz \n");
        goto ilk;
    }
    if (gir.Length > 5)
    {
        Console.Write("\nLütfen En Fazla 5 Basamaklı Bir Sayı Giriniz\n");
        Console.ReadKey(true);
        Console.Clear();
        goto ilk;
    }
}
while (karakter.Key != ConsoleKey.Enter);
Console.WriteLine("");
x = Convert.ToInt32(gir);

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
            gir1 = gir1.Substring(0, (gir1.Length - 1));
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

for (int sayi = 0; sayi < x; sayi++)
{
    int birler = (sayi % 10);
    int onlar = (((sayi % 100) - birler) / 10);
    int yuzler = ((sayi - (onlar * 10) - (birler)) / 100);
    int binler = ((sayi - (yuzler * 100) - (onlar * 10) - (birler)) / 1000);

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

Console.Write("1'den "+x+"'e kadar " + y + " rakamı adeti = " + sayac);
Console.ReadLine();

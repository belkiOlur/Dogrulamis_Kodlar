ilk:
double val = 0;
bool asal = true;
string sayi = "";
double i = 0;
double num = 0;
int sayac = 0;
Console.Write("Lütfen Asal Çarpanlara Ayrılacak Sayıyı Giriniz =");
ConsoleKeyInfo karakter;
do
{
    karakter = Console.ReadKey(true);
    if (karakter.Key != ConsoleKey.Backspace)
    {
        bool kontrol = double.TryParse(karakter.KeyChar.ToString(), out val);
        if (kontrol)
        {
            sayi += karakter.KeyChar;
            Console.Write(karakter.KeyChar);
        }
    }
    else

    {
        if (karakter.Key == ConsoleKey.Backspace && sayi.Length > 0)
        {
            sayi = sayi.Substring(0, (sayi.Length - 1));
            Console.Write("\b \b");
        }
    }
    if (karakter.Key == ConsoleKey.Enter && sayi.Length <= 0)
    {
        Console.Write("\n");
        Console.Write("Öğrenci Sayısı Boş Geçilemez Lütfen Bir Sayı Giriniz \n");
        goto ilk;
    }
}
while (karakter.Key != ConsoleKey.Enter);
Console.WriteLine("");
num = Convert.ToDouble(sayi);

    for (i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            Console.WriteLine(i);
            sayac++;
        }
        if(sayac == 4)
        {
        break;
        }
    }
Console.ReadKey(true);
Console.Clear();
goto ilk;

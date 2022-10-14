bas:
double val = 0;
string sayi = "";
double a = 0;
double b = 1;
double sum = 0;
Console.Write("Bir Sayı Giriniz =");
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
        Console.Write("Lütfen Bir Sayı Giriniz \n");
        goto bas;
    }
  
    
}
while (karakter.Key != ConsoleKey.Enter);
Console.WriteLine("");
int n = Convert.ToInt32(sayi);

for (int i = 0; i < n; i++)
{
    
    double fibo = a + b;
    a = b;
    b = fibo;
    if (fibo <4000000 && fibo % 2 == 0) 
    {
        sum += fibo;        
    }
    
}
Console.Write(sum);
Console.ReadKey(true);
Console.Clear();
goto bas;


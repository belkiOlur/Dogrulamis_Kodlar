using System.Text.Json.Serialization;
int sayac = 0;

    for (int sayi = 0; sayi < 1000; sayi++)
    {
    int birler = (((sayi % 1000) % 100) % 10);
    int onlar = (((sayi % 100) - birler) / 10);
    int yuzler = ((sayi  - (onlar * 10) - (birler)) / 100);
  
    if (birler == 2)
    {
        sayac++;
    }
    if (onlar == 2)
    {
        sayac++;
    }
    if (yuzler == 2)
    {
        sayac++;
    }
}

Console.Write("1'den 1000'e kadar 2 rakamı adeti = "+sayac);

Console.ReadLine();
        
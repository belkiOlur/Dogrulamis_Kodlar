int toplam = 0;
for (int i = 0; i<1000; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        toplam +=  i;
    }
    
}
Console.Write("1000'e kadar 3 veya 5'in katları toplamı = "+toplam);
Console.ReadKey(true);
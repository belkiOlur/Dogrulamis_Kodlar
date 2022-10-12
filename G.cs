using System.Reflection.Emit;

namespace ForG
{
    internal class Program
    {
        static void Main(string[] args)

        {
            ilk:
            Console.Write("Yukseklik Giriniz =");
            int sutun = Convert.ToInt32(Console.ReadLine());
           
            if (5 > sutun || sutun > 20)
            {
                Console.Write("Lütfen 5 ile 20 arasında Sayi Giriniz\n");
                goto ilk;
            }
            

                int x = sutun / 2;
                int y = (sutun - 1) * 2;

                for (int i = 0; i < sutun; i++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
                for (int i = 0; i <= x; i++)
                {
                    Console.WriteLine("*");
                }
                for (int i = 0; i < 1; i++)
                {
                    Console.Write("*");
                    for (int j = 0; j < sutun; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < sutun / 2; j++)
                    {
                        Console.Write("* ");
                    }
                }
                Console.Write("\n");
                for (int i = 0; i <= x; i++)
                {
                    Console.Write("*");
                    for (int j = 0; j < y; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    Console.Write("\n");

                }
                for (int i = 0; i < sutun; i++)
                {
                    Console.Write("* ");
                }
            }
        }
    }

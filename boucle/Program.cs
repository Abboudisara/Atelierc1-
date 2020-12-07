using System;

namespace Applicationboucle
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            int m = 2;
            do
            {
                Console.WriteLine(k * m);
                k++;

            }
            while (k < 30);




            float x = 1;
            do
            {
                Console.WriteLine(x);
                x += x * 1 / 2;

            } while (x < 10);



            for (int i = 1; i < 16; i++)
            {
                Console.WriteLine("On y arrive presque");
            }

            for (int a = 20; a > 0; a--)
            {
                Console.WriteLine("C'est presque bon");
            }

            for (int b = 1; b < 101; b += 15)
            {
                Console.WriteLine("On tient le bon bout");
            }

            for (int c = 200; c >= 0; c -= 12)
            {
                Console.WriteLine("Enfin ! ! !");
            }
        }
    }
}


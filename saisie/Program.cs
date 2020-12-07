using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const float TVA = 0.19f;
            Console.Write("écrivez le Nom de produit que vous souiter trouver : ");
            string str = Console.ReadLine();
            Console.WriteLine("le produit " + str);
            Console.WriteLine("écrivez le prix de " + str + ":");
            string strNum = Console.ReadLine();
            int prix = int.Parse(strNum);

            Console.WriteLine("Le prix du " + str + " TVA est de " + (prix * TVA));


        }
    }
}


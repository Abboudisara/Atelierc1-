using System;

namespace functioncal
{
    class Program
    {
        static void Main(string[] args)
        {

            // calcule 1 a 7 
            Console.WriteLine("Bienvenu dans votre calcule!");

            void addition(int num1, int num2)
            {
                Console.WriteLine(" somme des nombres");
                Console.WriteLine(num1 + num2);
            }
            void soustraction(int num1, int num2)
            {
                Console.WriteLine(" substraction des nombres");
                Console.WriteLine(num1 - num2);
            }
            void multiplication(int num1, int num2)
            {
                Console.WriteLine(" multiplication des nombres");
                Console.WriteLine(num1 * num2);
            }
            void divition(int num1, int num2)
            {
                Console.WriteLine(" divition des nombres");
                Console.WriteLine(num1 / num2);
                Console.WriteLine(" le reste de l application");
                Console.WriteLine(num1 % num2);

            }
            Console.Write("donnée le premier Nombre : " + "");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("choisir l application que vous souiter : (* + - /) :");
            string calc = Console.ReadLine();
            if (calc == "q")
            {
                Environment.Exit(1);
            }
            Console.Write("donné le deuxiéme numéro :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (calc == "+")
            {
                addition(num1, num2);
            }
            else if (calc == "*")
            {
                multiplication(num1, num2);
            }
            else if (calc == "*")
            {
                soustraction(num1, num2);
            }
            else if (calc == "/")
            {
                divition(num1, num2);
            }
            else
            {
                divition(num1, num2);
            }







        }
    }
}


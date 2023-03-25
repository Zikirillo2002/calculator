using System;

namespace ConsoleApp2

{

    internal class Program
    {

        static void Main(string[] args)
        {

            double son1, son2;
            string amal;
            bool isnumber1, isnumber2;
            Console.Write("   Mini Kalkulyator dasturimizga xush kelibsiz !!!! ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("1-sonni kiriting --> ");
            isnumber1 = double.TryParse(Console.ReadLine(), out son1);
            Console.WriteLine();
            while (!isnumber1)
            {
                Console.WriteLine("Siz noto'g'ri son kiritdingiz !!! ");
                Console.WriteLine("Tekshirib boshqa son kiriting !!! ");
                Console.WriteLine();
                Console.Write("1-sonni kiriting --> ");
                isnumber1 = double.TryParse(Console.ReadLine(), out son1);
                Console.WriteLine();
            }
            Console.Write("amalni kiriting --> ");
            amal = Console.ReadLine();
            Console.WriteLine();
            while (amal != "+" && amal != "-" && amal != "*" && amal != "/" && amal != "%")
            {
                Console.WriteLine(" Amalni xato kiritdingiz ! ");
                Console.WriteLine($" ( {amal} ) bunday amal mavjud emas !!!");
                Console.WriteLine(" Iltimos shu amallardan birini kiriting [ + ] , [ - ] , [ * ] , [ / ] , [ % ] !!!");
                Console.WriteLine();
                Console.Write("amalni kiriting --> ");
                amal = Console.ReadLine();
                Console.WriteLine();
            }
            Console.Write("2-sonni kiriting --> ");
            isnumber2 = double.TryParse(Console.ReadLine(), out son2);
            Console.WriteLine();
            while (!isnumber2)
            {
                Console.WriteLine("Siz noto'g'ri son kiritdingiz !!! ");
                Console.WriteLine("Tekshirib boshqa son kiriting !!! ");
                Console.WriteLine();
                Console.Write("2-sonni kiriting --> ");
                isnumber2 = double.TryParse(Console.ReadLine(), out son2);
                Console.WriteLine();
            }
            if (amal == "+")
            {
                Console.WriteLine($"Natija -->  {son1} {amal} {son2} = {son1 + son2} ");
            }
            else if (amal == "-")
            {
                Console.WriteLine($"Natija -->  {son1} {amal} {son2} = {son1 - son2} ");
            }
            else if (amal == "*")
            {
                Console.WriteLine($"Natija -->  {son1} {amal} {son2} = {son1 * son2} ");
            }
            else if (amal == "/")
            {
                while (son2 == 0)
                {
                    Console.WriteLine(" Error !!! ");
                    Console.WriteLine(" Siz arifmetik xato qildingiz !!! ");
                    Console.WriteLine(" Iltimos boshqa sonni kiriting !!! ");
                    Console.WriteLine();
                    Console.Write("2-sonni kiriting --> ");
                    son2 = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine($"Natija -->  {son1} {amal} {son2} = {son1 / son2} ");
            }
            else if (amal == "%")
            {
                Console.WriteLine($"Natija -->  {son1} {amal} {son2} = {son1 % son2} ");
            }
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine();
            Main(args);

        }

    }

}
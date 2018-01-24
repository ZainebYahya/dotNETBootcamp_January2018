using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Exit = false;
            while (!Exit)
            {
                // put my code!!!!
                // input 
                Console.WriteLine("Welcome to GCs Resturant!");
                Console.WriteLine("Please make a selection:");
                Console.WriteLine("1. Cheese Burger");
                Console.WriteLine("2. Salad");
                Console.WriteLine("3. Water");
                Console.WriteLine("4. Coke");
                Console.WriteLine("5. You know what, I changed my mind. Exit");

                int Choice = int.Parse(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        Console.WriteLine("Here you go, your cheese burger is ready!");
                        break;
                    case 2:
                        Console.WriteLine("Here you go, your salad is ready!");
                        break;
                    case 3:
                        Console.WriteLine("take your water!");
                        break;
                    case 4:
                        Console.WriteLine("take your coke!");
                        break;

                    default:
                        Console.WriteLine("See you soon!");
                        Exit = true;
                        break;

                }
            }

        }
    }
}

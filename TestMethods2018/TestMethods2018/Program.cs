using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace TestMethods2018
{
    class Program
    {
        static void Main(string[] args)
        {
              
            //int X, Y;

            //X = ReadUserInput("Please enter X");

            //Y = ReadUserInput("Please enter Y");

            //Console.WriteLine("The largest number is:" + FindMax(X,Y));


            ReadValidOption();
        }


        // define a method that reads user input and returns that input
        public static int ReadUserInput(string UserPrompt)
        {
            Console.WriteLine(UserPrompt);
            int Input;
            string UserInput = Console.ReadLine();
            while (!Regex.Match(UserInput, @"^\d{1,10}$").Success)
            {
                Console.WriteLine("Please enter a valid number!");
                UserInput = Console.ReadLine();
            }
            // after the while loop, your string will be valid! 
            Input = int.Parse(UserInput);
            return Input;
            //while (!int.TryParse(Console.ReadLine(),out Input))
            //{
            //    Console.WriteLine("Please enter a valid number!");
            //}

            // int Input = Convert.ToInt32(Console.ReadLine());

        }

        public static int ReadUserInput()
        {
            Console.WriteLine("Give me some input!");
            int Input = Convert.ToInt32(Console.ReadLine());
            return Input;
        }

        // define a method to find the largest of two integers 
        public static int FindMax(int x, int y)
        {
            //if (x > y)
            //    return x;
            //else
            //    return y;

            return (x > y) ? x : y; // condition ? true part : false part 
        }


        public static string ReadValidOption()
        {
            string Input = Console.ReadLine();

            while (!Regex.Match(Input, @"^(yes|y|no|n)$").Success)
            {
                Console.WriteLine("Please enter only yes|y|no|n");
                Input = Console.ReadLine();
            }

            return Input;

        }
    }
}

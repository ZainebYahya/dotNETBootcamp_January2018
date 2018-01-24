using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestControlStatements2018
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input 
            Console.WriteLine("Please enter a number");
            int Input = int.Parse(Console.ReadLine());

            if (Input % 2 == 0 && Input >= 0) // even and pos 
            {
                Console.WriteLine("The input is even and positive!");
            }
            else if (Input % 2 != 0 && Input >= 0) // odd and pos
            {
                Console.WriteLine("The input is odd and positive!");

            }
            else if (Input % 2 == 0 && Input < 0) // even and neg
            {
                Console.WriteLine("The input is even and negative!");

            }
            else // odd and neg
            {
                Console.WriteLine("The input is odd and negative!");
            }


            // nested ifs


            if (Input % 2 == 0)// even
            {
                if (Input >= 0)//pos
                {
                    Console.WriteLine("The input is even and positive!");
                }
                else// neg
                {
                    Console.WriteLine("The input is even and negative!");
                }

            }

            else//odd 
            {
                if (Input >= 0)//pos
                {
                    Console.WriteLine("The input is odd and positive!");
                }
                else// neg
                {
                    Console.WriteLine("The input is odd and negative!");
                }

            }






        }
    }
}

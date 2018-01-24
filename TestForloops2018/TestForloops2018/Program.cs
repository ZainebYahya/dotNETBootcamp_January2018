using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForloops2018
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Print numbers between 1 and 10 inclusive

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // 2. Print numbers between 1 and some user input 
            //int Max = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= Max; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // 3. print even numbers between 1 and 200 using a for loop
            //for (int i = 2; i <= 200; i+=2)
            //{   
            //    //if (i % 2 == 0)// even 
            //    //  Console.WriteLine(i);
            //    Console.WriteLine(i);
            //}

            //4. Print numbers between 100 and 1 inclusive 

            //for (int i = 100; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}

            // 5. print even numbers between 1 and 200 using a for loop
            for (int i = 1; i <= 200; i ++)
            {
                if (i % 2 != 0)// odd 
                  continue;


                Console.WriteLine(i);
            }


        }
    }
}

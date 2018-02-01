using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExceptions2018
{
    class Program
    {
        static void Main(string[] args)
        {

            unsafe
            {
                int* c;

                int x = 4;

                c = &x;



            }

            try
            {
                int x = int.Parse(Console.ReadLine());

                int y = int.Parse(Console.ReadLine());

                int result = x / y;

            }

            catch (OverflowException e)
            {


            }

            catch (FormatException e)
            {


            }

            catch (DivideByZeroException e)
            {


            }

            catch (Exception e)// comes after the exception
            {
                // record and send the error info to programmers 
                // print a message to the user 

                Console.WriteLine("I think you tried to divide on zero! Nice try!");

                //Console.WriteLine(e.ToString());

                // you can send e.ToString to developers to help them fix this bug 
            }




        }
    }
}

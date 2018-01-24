using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            double Input;

            

            // input 

            // Input = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Please enter a number! Like now!");
            Input = double.Parse(Console.ReadLine());


            // processing 
            //Input = Input + 1; // Input+=1; Input++; 
            Input = Math.Sqrt(Input);

            //Output 
            //Console.WriteLine("Output is equal to: "+Input);
            Console.WriteLine($"Output is equal to {Input}");
        }
    }
}

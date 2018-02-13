using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {

            float? salary = null;

            // int @int = 4; 
           
            Console.WriteLine(Sum(1,1,2));

            Console.WriteLine(Sum(1, 1, 2,4,56,6,7,8,89,9,90,09,0));
        }

        public static int Sum(params int[] ar)
        {
            int sum = 0;

            foreach (int element in ar)
                sum += element;

            return sum; 

        }
    }
}

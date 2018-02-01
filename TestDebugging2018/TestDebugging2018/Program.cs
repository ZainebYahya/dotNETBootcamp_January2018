using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDebugging2018
{
    public class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int Result = CalcPow(X, Y);

            Console.WriteLine(Result);
        }

        public static int CalcPow(int X, int Y)
        {
            int Result = 1;

            for (int i = 1; i <= Y; i++)
            {
                Result = Result * X;
            }

            return Result;
        }
    }
}

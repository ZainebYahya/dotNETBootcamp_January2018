using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; 

namespace TestThreads
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(new ParameterizedThreadStart(Play));
                t.Start(i);// will start a new thread
                
              //  Play(i);
            }

        }

        public static void Play(object x)
        {

            Console.WriteLine(x);

        }
    }
}

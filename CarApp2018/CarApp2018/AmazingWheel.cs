using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp2018
{
    class AmazingWheel : IWheel // agree on the terms of that interface 
    {
        public float Radius { get; set; }

        public void Rotate()
        {
            Console.WriteLine("The wheels on the car goes round and round.... ");
        }
    }
}

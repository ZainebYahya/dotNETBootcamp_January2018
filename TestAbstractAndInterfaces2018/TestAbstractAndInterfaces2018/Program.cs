using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAbstractAndInterfaces2018
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> ShapeList = new List<Shape>();

            ShapeList.Add(new Rectangle("R1", 3, 5));
            ShapeList.Add(new Circle("C1", 3));

          //  Shape p = new Shape(); can't do 

            float Sum = 0;

            foreach (Shape s in ShapeList)
            {
                Sum = Sum + s.CalculateArea();

            }

            Console.WriteLine($"Total sum of all shapes = {Sum}");
        }
    }
}

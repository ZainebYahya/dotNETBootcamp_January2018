using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAbstractAndInterfaces2018
{
    class Circle:Shape
    {
        public float Radius { set; get; }

        public override float CalculateArea()
        {
            return (float)(Math.PI * Radius * Radius);
        }

        public Circle(string name, float R)
        {
            ShapeName = name;
            Radius = R; 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAbstractAndInterfaces2018
{
    class Rectangle: Shape
    {
        public float Width { set; get; }
        public float Length { set; get; }

        public Rectangle(string name, float W, float L)
        {
            ShapeName = name;
            Width = W;
            Length = L;
        }

        public override float CalculateArea()
        {
            return Width * Length; 
        }
    }
}

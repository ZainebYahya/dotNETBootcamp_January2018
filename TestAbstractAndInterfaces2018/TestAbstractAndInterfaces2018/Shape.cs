using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAbstractAndInterfaces2018
{
     abstract class Shape
    {
        public string ShapeName { set; get; }

        public abstract float CalculateArea();// abstract method 
      
    }
}

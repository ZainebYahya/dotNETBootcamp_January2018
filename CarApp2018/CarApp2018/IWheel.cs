using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp2018
{
    interface IWheel
    {

     void Rotate(); // abstract and Virtual 
     float Radius { set; get; }
     
    }
}

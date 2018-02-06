using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp2018
{
    class Car
    {
        public List<IWheel> CarWheels { set; get; }
        public IEngine carEngine { set; get; }
        public Car(List<IWheel> newWheels, IEngine newEngine)// Injection 
        {
            CarWheels = newWheels;
            carEngine = newEngine;
        }

      // Wheels
      // Engine
      // Doors

    }
}

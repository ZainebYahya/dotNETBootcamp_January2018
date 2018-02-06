using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp2018
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IWheel> carWheels = new List<IWheel>();

            carWheels.Add(new AmazingWheel());
            carWheels.Add(new AmazingWheel());
            carWheels.Add(new AmazingWheel());


            Car BMW = new Car(carWheels, new SuperDuperEngine());

            BMW.carEngine = new SixSEngine();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP2018
{
    class CEO:Manager
    {
        public float StockOptions { set; get;  }

        public CEO(string name, string address, string dept,
            float stockoptions)
            : base(name, address, dept)
        {
            StockOptions = stockoptions;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("********CEO of the company********");
            Console.WriteLine(Address);
            Console.WriteLine(Name);
            Console.WriteLine(Department);
            Console.WriteLine(StockOptions);
            Console.WriteLine(new string('*', 20));
        }

        public override string ToString()
        {
            return "CEO:" + StockOptions;
        }

    }
}

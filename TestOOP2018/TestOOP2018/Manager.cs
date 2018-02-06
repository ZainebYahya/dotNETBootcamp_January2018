using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP2018
{
    class Manager:Employee
    {
        // default property 
       public string Department {
            set ;
            get ;
        }

        //private string department;
        //public string Department
        //{
        //    set { department = value; }
        //    get { return department;  }
        //}

        // constructor 
        public Manager(string name, string address, string dept)
            :base(name,address)
        {
           // Name = name;
           //  Address = address;
            Department = dept; 
        }

        public override void PrintInfo()
        {
            Console.WriteLine("********Manager********");
            Console.WriteLine(Address);
            Console.WriteLine(Name);
            Console.WriteLine(Department);
            Console.WriteLine(new string('*', 20));
        }

        public override string ToString()
        {
            return "Manager:" + Department + ":" + Name;
        }
    }
}

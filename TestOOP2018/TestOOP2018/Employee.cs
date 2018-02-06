using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestOOP2018
{
    class  Employee
    {
        // Fields 
        #region Fields
        private string name;
        private string address;
        private string ssn;
        private float salary;
        private string phoneno;
        #endregion

        #region properties
        public string Name
        {
            set { name = value; } // used to change the value of the field 
            get { return name; } // used to return the value of the field 

        }

        public string Address
        {
            set { address = value; } // used to change the value of the field 
            get { return address; } // used to return the value of the field 

        }

        public string SSN
        {
            set {
                if (!Regex.Match(value, @"^\d{9}$").Success)
                    throw new FormatException("Wrong SSN format");
                else
                ssn = value;


            } // used to change the value of the field 
            get { return ssn; } // used to return the value of the field 

        }

        public string Phoneno
        {
            set { phoneno = value; } // used to change the value of the field 
            get { return phoneno; } // used to return the value of the field 

        }

        public float Salary
        {
            set { salary = value;
               // value = salary;  /// BUG!!!!!!!
            } // used to change the value of the field 
            get { return salary; } // used to return the value of the field 

        }
        #endregion

        #region Constructors
        public Employee(string employeeName, string employeeAddress)
        {
            Name = employeeName;
            Address = employeeAddress; 
        }

        public Employee():this("no provided!", "1570")
        {
            //Name = "no provided!";
            //Address = "1570";
        }
        #endregion


        // Methods

        // print the employee's info
        public virtual void PrintInfo()
        {
            Console.WriteLine(new string('*',20));
            Console.WriteLine(Address);
            Console.WriteLine(Name);
            Console.WriteLine(new string('*', 20));
        }


        // give a raise to an employee 

        public void GiveRaise(float Percentage)
        {
            float Raise;
            Raise = (Percentage / 100) + 1;
            Salary *= Raise; 

        }

        public override string ToString()
        {
            return "Employee:" + Name; 
        }

    }
}

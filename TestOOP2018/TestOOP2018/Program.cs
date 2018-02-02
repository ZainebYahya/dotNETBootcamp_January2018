using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP2018
{
    class Program
    {
        static void Main(string[] args)
        {
            // type variablename = new type();            ()=> constructors 

            Employee Jacob = new Employee("Jacob", "1570 woodward");

            Employee John = new Employee();

            Jacob.Name = "Jacob Snover";// set 

            Jacob.Address = "1570 Woodward Ave., Detroit, MI, 48202"; // set 

            Jacob.PrintInfo();

            Jacob.Salary = 2000;

            Jacob.GiveRaise(3);

            Console.WriteLine(Jacob.Salary);


            // using arrays or other DS to store an manipulate objects! 


            Employee[] EmpList = new Employee[10];

            for (int i = 0; i < EmpList.Length; i++)
            {
                EmpList[i] = new Employee();

                Console.WriteLine("Please enter the name of the employee");
                EmpList[i].Name = Console.ReadLine();

                Console.WriteLine("Please enter the address of the employee");
                EmpList[i].Address = Console.ReadLine();

                Console.WriteLine("Please enter the SSN of the employee");
                EmpList[i].SSN = Console.ReadLine();

                Console.WriteLine("Please enter the Salary of the employee");
                EmpList[i].Salary = float.Parse(Console.ReadLine());

            }

            // write a code that prints the names of all employees with a salary larger than 2000

            for (int i = 0; i < EmpList.Length; i++)
            {
                if (EmpList[i].Salary > 2000)
                {
                    Console.WriteLine(EmpList[i].Name);
                }
            }

            foreach (Employee EMP in EmpList)
            {
                if (EMP.Salary > 2000)
                {
                    Console.WriteLine(EMP.Name);
                }
            }

        }
    }
}

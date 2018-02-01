using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArrays2018
{
    class Program
    {
        static void Main(string[] args)
        {

            // int[] Ages = new int[15];

            // array of integers with size = 3 
            //int[] SalaryArray = {1000,1000,2000 };

            //int[] SalaryArray = new int[3] { 1000, 1000, 2000 };
            //// char[] Vowels = { 'a','u','i'};

            //int Sum = 0; 
            //for (int i = 0; i < SalaryArray.Length; i++)
            //{
            //    Sum = Sum + SalaryArray[i]; 
            //}

            //// SalaryArray[i] => element 
            //foreach (int element in SalaryArray)
            //{
            //    // element += 500; 
            //    Sum += element; 
            //}

            ////for (int i = SalaryArray.Length; i >= 0; i--)
            ////{
            ////    // reverse 

            ////}

            //Console.WriteLine(Sum);


            // create an array of DOBs
            // print the age of each person 

            Console.WriteLine("Please enter the number of Employees");
            int Size = int.Parse(Console.ReadLine());
            DateTime[] DOBs = new DateTime[Size];

            //// read the DOB for all employees 
            for (int i = 0; i < DOBs.Length; i++)
            {
                DOBs[i] = DateTime.Parse(Console.ReadLine());
                //Console.WriteLine(DOBs[i]);
            }

            //// calculate the age of each employee (in years!)
            foreach (DateTime D in DOBs)
            {
                //    //Console.WriteLine($"Employee's age is {DateTime.Now.Year - D.Year}");

                //    //int age = DateTime.Now.Year - D.Year;
                //    //if (D > DateTime.Now.AddYears(-age)) age--;

                //    //Console.WriteLine(age);

                //    TimeSpan temp = DateTime.Now - D;
                //    Console.WriteLine(Math.Floor(temp.TotalDays/365));
                LocalDate birthday = new LocalDate(D.Year,D.Month,D.Day);
                LocalDate today = new LocalDate(DateTime.Now.Year,
                DateTime.Now.Month, DateTime.Now.Day);
                Period period = Period.Between(birthday, today,
                                           PeriodUnits.Years);

                Console.WriteLine(period.Years);

            }

            
          


        }
    }
}

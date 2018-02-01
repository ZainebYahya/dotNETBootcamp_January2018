using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2DArrays2018
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program will read number of students

            // Will read number of grades 
            Console.WriteLine("Please enter number of students");
            int NumberOfStudents = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter number of grades");
            int NumberOfGrades = int.Parse(Console.ReadLine());


            // create a 2d array 

            float[,] StudentGradeSheet = new float[NumberOfStudents, NumberOfGrades];

            // read the grades
            for (int Row = 0; Row < NumberOfStudents; Row++)
            {
                Console.WriteLine($"You will start entering grades for student No.{Row+1}");
                for (int Column = 0; Column < NumberOfGrades; Column++)
                {
                    Console.WriteLine($"Please enter grade No.{Column + 1}");
                    StudentGradeSheet[Row, Column] = float.Parse(Console.ReadLine());

                }
            }


            // calculate the letter grade 

            for (int Row = 0; Row < NumberOfStudents; Row++)// for each student
            {
                float Sum = 0;
                for (int Column = 0; Column < NumberOfGrades; Column++)// for each grade
                {
                    Sum = Sum + StudentGradeSheet[Row,Column];
                }

                Console.WriteLine($"Letter grade for studnet {Row+1} is {CalculateLetterGrade(Sum)}");
            }


        }


        static char CalculateLetterGrade(float Sum)
        {
            if (Sum >= 90)
                return 'A';
            else if (Sum >= 79)
                return 'B';
            else if (Sum >= 60)
                return 'C';
            else
                return 'F';

        }
    }
}

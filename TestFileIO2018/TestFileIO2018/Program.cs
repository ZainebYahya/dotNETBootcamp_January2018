using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestFileIO2018
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> EmpList = GetEmployeeList("../../EmployeeDB.txt");
            int count = 0;
            char[] Vowels = {'a','e','i','o','u' };
            foreach (string Employee in EmpList)
            {
                Console.WriteLine(Employee);

                if (Vowels.Contains(char.ToLower(Employee[0])))
                    count++;

            }
            Console.WriteLine(count);

            WriteToFile("../../OutPut.txt", count);



        }


        public static List<string> GetEmployeeList(string FileName)
        {
            StreamReader Reader = new StreamReader(FileName);

            string TheWholeFile=Reader.ReadToEnd();

            Reader.Close();

            return TheWholeFile.Split('\n').ToList();
        }

        public static List<string> GetEmployeeListLineByLine(string FileName)
        {
            StreamReader Reader = new StreamReader(FileName);

            string CurrentLine = Reader.ReadLine();// reads the first line
            List<string> EmpList = new List<string>();

            while (CurrentLine != null)// I have more lines to read 
            {
                EmpList.Add(CurrentLine);
                CurrentLine = Reader.ReadLine();// read next line 
            }
            Reader.Close();// Thanks Dan! 
            return EmpList; 
        }


        public static void WriteToFile(string FileName, int count)
        {

            StreamWriter Writer = new StreamWriter(FileName); // Clear, then add new line 
            //StreamWriter Writer = new StreamWriter(FileName,true); Append to the end of the file

            Writer.WriteLine($"Count = {count}, Time={DateTime.Now.TimeOfDay}");

            Writer.Close();
        }
    }
}

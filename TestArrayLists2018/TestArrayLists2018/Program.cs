using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArrayLists2018
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ContactList = new List<string>();

            //ArrayList lst  = new ArrayList();

            ContactList.Add("Emergency 911");
            ContactList.Add("Jacob 3135666655");
          

            while (true)
            {  
                Console.WriteLine("Please choose an option");
                Console.WriteLine("1. Add New Contact");
                Console.WriteLine("2. Remove a Contact");
                Console.WriteLine("3. Print Contacts");
                Console.WriteLine("4. Exit");
                int Choice = int.Parse(Console.ReadLine());
                if (Choice == 1)// add new contacts 
                {
                    Console.WriteLine("Please enter a new contact");
                    ContactList.Add(Console.ReadLine());
                }
                else if (Choice == 2)// remove contacts 
                {
                    Console.WriteLine("Please choose a contact to remove: ");
                    for (int i = 0; i < ContactList.Count; i++)
                    {
                        Console.WriteLine($"{i} {ContactList[i]}");
                    }
                    int UserChoice = int.Parse(Console.ReadLine());
                    ContactList.RemoveAt(UserChoice);
                        
                }
                else if (Choice == 3)// print the contact list
                {
                    //for (int i = 0; i < ContactList.Count; i++)
                    //{
                    //    Console.WriteLine(ContactList[i]);
                    //}
                    Console.WriteLine(new string('*', 20));

                    foreach (string Contact in ContactList)
                    {
                        Console.WriteLine(Contact);
                    }

                    Console.WriteLine(new string('*', 20));

                }
                else
                {
                    break; 
                }
            }

        }
    }
}

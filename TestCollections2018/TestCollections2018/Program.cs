using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TestCollections2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ht1 = new Dictionary<string, int>();
            

            Hashtable ContactList = new Hashtable();


            // adding values to a hashtable 
            string UserInput = Console.ReadLine();

            int Key =UserInput.GetHashCode();// get the key from the value 

            ContactList.Add(Key, UserInput); // stores the value using the key 


            // locate values 

            Console.WriteLine("Please enter a name!");
            string NameToSearchFor = Console.ReadLine();
            if (ContactList[NameToSearchFor.GetHashCode()] != null)
            {
                Console.WriteLine("You found it!");
            }
            else
            {
                Console.WriteLine("Name not found!");
            }

        }

        
    }
}

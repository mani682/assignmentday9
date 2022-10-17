using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook
{
    public static class uc4_addressbook
    {
        public static void DeleteContact()
        {
            Console.WriteLine("Enter the first name you want to edit");
            string Firstname = Console.ReadLine();

            //int index = people.IndexOf(Firstname);
            int index = -1;
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].Firstname.ToLower() == Firstname.ToLower())
                {
                    index = i;
                    break;
                }
            }

            if (index >= 0)
            {
                people.RemoveAt(index);
                Console.WriteLine("Person deleted successfully");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("No such person exist in database.");
                Console.ReadLine();
            }
        }
    }
}
    }
}

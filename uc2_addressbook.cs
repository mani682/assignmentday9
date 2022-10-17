using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook
{
    public static class uc2_addressbook
    {
        public static void Display()
        {
            foreach (var contact in people)
            {
                Console.WriteLine($"Firstname : {contact.Firstname}\t Lastname : {contact.Lastname}\t PhoneNumber : {contact.PhoneNumber}\t city : {contact.city}\t Zip : {contact.Zip}\t Email : {contact.Email}\t Adress : {contact.Adress}\n ");

            }
            Console.ReadLine();
        }
    }
}

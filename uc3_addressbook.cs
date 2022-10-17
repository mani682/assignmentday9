using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook
{
    public static class uc3_addressbook
    {
        public static void EditContact()
        {
            Console.WriteLine("Enter the first name you want to edit");
            string Firstname = Console.ReadLine();
            foreach (Contact contact in uc3_addressbook)
            {
                if (contact.Firstname.ToLower() == Firstname.ToLower())
                {
                    Console.WriteLine("Enter which information you want to change ");
                    Console.WriteLine("Enter 1 To edit last nam \n 2 to change the city \n  3 to change the phonenumber \n 4 to change the zip \n 5 to change the Email \n 6to change the address");
                    int option = Convert.ToInt32((Console.ReadLine()));
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter the Lastname");
                            contact.Lastname = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter the city");
                            contact.city = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter the Phonenumber");
                            contact.PhoneNumber = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter the Zip");
                            contact.zip = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter the Email");
                            contact.Email = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter the Adress");
                            contact.Adress = Console.ReadLine();
                            break;
                    }

                }
            }
        }
    }
}

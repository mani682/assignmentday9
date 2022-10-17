using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook
{
    public static class uc1_addressbook
    {
        public static void PrintPerson()
        {
            Console.WriteLine("Welcome to my address book program");
            Console.WriteLine("*********************");
            Console.WriteLine("Please Enter your Firstname");
            string str1 = "Firstname";
            str1 = Console.ReadLine();
            string valueString1 = str1;
            Console.WriteLine("Please Enter your Lastname");
            string str2 = "Lastname";
            str2 = Console.ReadLine();
            string valueString2 = str2;
            Console.WriteLine("Please Enter your Address, house number and town");
            string str3 = "Address";
            str3 = Console.ReadLine();
            string valueString3 = str3;
            Console.WriteLine("Please Enter your city");
            string str4 = "city";
            str4 = Console.ReadLine();
            string valueString4 = str3;
            Console.WriteLine("Please Enter your zipcode");
            string str5 = "zipcode";
            str5 = Console.ReadLine();
            string valueString5 = str5;
            Console.WriteLine("Please Enter your number");
            string str6 = "number";
            str6 = Console.ReadLine();
            string valueString6 = str6;
            Console.WriteLine("Please Enter your email");
            string str7 = "email";
            str7 = Console.ReadLine();
            string valueString7 = str7;
            Console.WriteLine("Here is a list of the stored names and addresees that you have entered so far");
            Console.WriteLine("******************************************************************************");
            Console.ReadLine();
            Console.WriteLine("Lastname you entered: " + valueString2);
            Console.WriteLine("Firstname you entered: " + valueString1);
            Console.WriteLine("Address and house number and town you entered: " + valueString3);
            Console.WriteLine("County you entered: " + valueString5);
            Console.WriteLine("Postcode you entered: " + valueString6);
            Console.ReadLine();

        }
    }
}

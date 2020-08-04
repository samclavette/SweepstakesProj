using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        public static string EnterInformation(string infoType)
        {
            Console.WriteLine("Please enter your " + infoType);
            string input = Console.ReadLine();
            return input;
        }

        public static string EnterManagerChoice()
        {
            Console.WriteLine("Please choose a Sweepstakes Manager type number:\n1.)Stack\n2.)Queue");
            string input = Console.ReadLine();
            if (input != "1" || input != "2")
            {
                EnterManagerChoice();
                return input;
            }
            else
            return input;
        }

        //public static string EnterLastName()
        //{
        //    Console.WriteLine("Please enter your last name: ");
        //    string input = Console.ReadLine();
        //    return input;
        //}

        //public static string EnterEmail()
        //{
        //    Console.WriteLine("Please enter your email: ");
        //    string input = Console.ReadLine();
        //    return input;
        //}

        public static int EnterRegistrationNumber()
        {
            Console.WriteLine("Please enter your registration number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        public static string EnterFirstName()
        {
            Console.WriteLine("Please enter your first name: ");
            string input = Console.ReadLine();
            return input;
        }

        public static string EnterLastName()
        {
            Console.WriteLine("Please enter your last name: ");
            string input = Console.ReadLine();
            return input;
        }

        public static string EnterEmail()
        {
            Console.WriteLine("Please enter your email: ");
            string input = Console.ReadLine();
            return input;
        }

        public static int EnterRegistrationNumber()
        {
            Console.WriteLine("Please enter your registration number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }
    }
}

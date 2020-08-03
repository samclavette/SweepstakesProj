using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        public string firstName;
        public string lastName;
        public string email;
        public int registrationNumber;

        public Contestant()
        {
            firstName = UserInterface.EnterInformation("first name");
            lastName = UserInterface.EnterInformation("last name");
            email = UserInterface.EnterInformation("email address");
            registrationNumber = UserInterface.EnterRegistrationNumber();
        } 
    }
}

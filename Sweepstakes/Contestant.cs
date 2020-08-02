﻿using System;
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
            firstName = UserInterface.EnterFirstName();
            lastName = UserInterface.EnterLastName();
            email = UserInterface.EnterEmail();
            registrationNumber = UserInterface.EnterRegistrationNumber();
        } 
    }
}

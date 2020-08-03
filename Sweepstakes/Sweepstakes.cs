using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        private Dictionary<int, Contestant> contestants;
        public Random rand;
        private string name;
        public string Name
        {
            get { return name; }
        }


        public Sweepstakes(string name)
        {
            this.name = name;
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.registrationNumber, contestant);            
        }

        public Contestant PickWinner()
        {
            int randomInt = rand.Next(contestants.Count);
            Contestant contestant = contestants.Values.ElementAt(randomInt);
            return contestant;
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}

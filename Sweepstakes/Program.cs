using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Contestant man1 = new Contestant();
            Contestant man2 = new Contestant();
            Contestant man3 = new Contestant();
            Contestant man4 = new Contestant();
            Contestant man5 = new Contestant();
            Sweepstakes goose = new Sweepstakes("Test");
            goose.RegisterContestant(man1);
            goose.RegisterContestant(man2);
            goose.RegisterContestant(man3);
            goose.RegisterContestant(man4);
            goose.RegisterContestant(man5);

            Contestant poop = goose.PickWinner();
        }
    }
}

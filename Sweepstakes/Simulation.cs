using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        //public void CreateMarketingFirmWithManager()
        //{
        //    ISweepstakesManager manager;
        //    string input = UserInterface.EnterManagerChoice();
        //    if (input == "1")
        //    {
        //        manager = new SweepstakesStackManager();
        //        MarketingFirm firm = new MarketingFirm(manager);
        //    }
        //    else if (input == "2")
        //    {
        //        manager = new SweepstakesQueueManager();
        //        MarketingFirm firm = new MarketingFirm(manager);
        //    }
        //}

        public void CreateMarketingFirmWithManager()
        {
            ISweepstakesManager manager = null;
            string input = UserInterface.EnterManagerChoice();

            switch(input)
            {
                case "1":
                    manager = new SweepstakesStackManager();
                    //MarketingFirm stackFirm = new MarketingFirm(manager);
                    break;
                case "2":
                    manager = new SweepstakesQueueManager();
                    //MarketingFirm queueFirm = new MarketingFirm(manager);
                    break;
            }
            MarketingFirm firm = new MarketingFirm(manager);
        }
    }
}

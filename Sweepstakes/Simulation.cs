using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        public void CreateMarketingFirmWithManager()
        {
            ISweepstakesManager manager;
            string input = UserInterface.EnterManagerChoice();
            if (input == "1")
            {
                manager = new SweepstakesStackManager();
                MarketingFirm firm = new MarketingFirm(manager);
            }
            else if (input == "2")
            {
                manager = new SweepstakesQueueManager();
                MarketingFirm firm = new MarketingFirm(manager);
            }
        }
    }
}

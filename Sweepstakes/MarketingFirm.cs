using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        private ISweepstakesManager manager;

        // constructor injection is used so that either type of sweepstakes manager (stack/queue) can be passed in
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }
        
        public void CreateSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes("New Sweepstakes");
            manager.InsertSweepstakes(sweepstakes);
        }
    }
}

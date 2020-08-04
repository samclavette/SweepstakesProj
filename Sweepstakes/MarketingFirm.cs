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

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }
        
        public void CreateSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes("New Sweepstakes");
        }
    }
}

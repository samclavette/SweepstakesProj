using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        private Queue<Sweepstakes> queue;

        //insert is enqueue, delete is dequeue

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakesFromQueue = queue.Dequeue();
            return sweepstakesFromQueue;
        }
    }
}

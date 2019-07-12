using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskWithHangFire.Jobs
{
    public class ContinuationsJob
    {
        public ContinuationsJob()
        {
            //Delayed job
            var parentJobId = BackgroundJob.Schedule(() => Console.WriteLine("I am a Delayed Job !!"), TimeSpan.FromMinutes(4));


            //Continuations job
            BackgroundJob.ContinueWith(parentJobId, () => ProcessContinuationsJob());
        }

        public void ProcessContinuationsJob()
        {
            Console.WriteLine("I am a Recurring Job !!");
        }
    }
}

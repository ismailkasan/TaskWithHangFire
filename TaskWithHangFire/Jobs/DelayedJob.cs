using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskWithHangFire.Jobs
{
    public class DelayedJob
    {
        public DelayedJob()
        {
            // Delayed Jobs
            var jobId = BackgroundJob.Schedule(()=>ProcessDelayedJob(),TimeSpan.FromMinutes(4));
        }
        public void ProcessDelayedJob()
        {

            throw new NotImplementedException();
        }
    }
}

using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskWithHangFire.Jobs
{
    public class FireAndForgetJob
    {
        public FireAndForgetJob()
        {
            // Fire and forget
            var jobId = BackgroundJob.Enqueue(()=>ProcessFireAndForgetJob());

            
        }
        public void ProcessFireAndForgetJob()
        {

            throw new NotImplementedException();
        }
    }
}

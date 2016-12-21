using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example2
{
    public class LongRunningProcess
    {
        public event EventHandler<DateTime> ProcessFinished;
        //public event EventHandler ProcessFinished;

        public void Run()
        {
            Thread.Sleep(5000);
            if (ProcessFinished != null)
                ProcessFinished(this, DateTime.Now);
            //ProcessFinished(this, EventArgs.Empty);
            Thread.Sleep(5000);
        }

        public static int GetProccesId()
        { return 0; }
    }
}

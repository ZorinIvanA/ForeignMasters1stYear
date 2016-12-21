using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program
    {
        //DON'T USE STATIC FIELDS!!!
        static LongRunningProcess _process1;

        static void Main(string[] args)
        {
            Int32 i = 1;
            i += 4;
            i = i + 4;

            _process1 = new LongRunningProcess();
            _process1.ProcessFinished += OnProcessFinished;
            LongRunningProcess p2 = new LongRunningProcess();
            p2.ProcessFinished += OnProcessFinished;
            _process1.Run();

            var x = Math.Max(3, 4);
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();
        }

        static void Method2()
        {
            _process1.Run();
            
        }

        public static void OnProcessFinished(Object sender,
            DateTime e)
        {
            Console.WriteLine(e);
        }

        //public static void OnProcessFinished(Object sender,
        //    EventArgs e)
        //{
        //    Console.WriteLine(DateTime.Now);
        //}
    }
}

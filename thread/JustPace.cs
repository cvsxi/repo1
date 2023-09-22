using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace thread
{
    public static class JustPace
    {
        static object locker = new();
        public static void justpace()
        {
            Pacing pacing = new Pacing();
            pacing.Pace();
            Console.WriteLine($"{Thread.CurrentThread.Name}  :  крокує до мосту");
            bool acquiredLock = false;
            try
            {
                Monitor.Enter(locker, ref acquiredLock);
                Console.WriteLine($"{Thread.CurrentThread.Name} :  йде через мiст");
                pacing.Pace();
            }
            finally
            {
                if (acquiredLock) Monitor.Exit(locker);
            }



        }
    }
}

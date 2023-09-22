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
        static Semaphore sem = new Semaphore(3, 3);
        static Thread myThread;
        static int count = 3;
        public static void justpace()
        {
            while (count>0 )
            {
                sem.WaitOne();
                Pacing pacing = new Pacing();
                pacing.Pace();
                Console.WriteLine($"{Thread.CurrentThread.Name}  :  крокує до мосту");
                

               
                Console.WriteLine($"{Thread.CurrentThread.Name} :  йде через мiст");
                pacing.Pace();
                sem.Release();
                count--;
            }



        }
    }
}

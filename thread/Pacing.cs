using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thread
{
     class Pacing
    {
        public void Pace()
        {
            int MyX = 0;
            Random random = new Random();

           
            while (MyX != 100)
            {
                int randomNumber = random.Next(1, 10);
                MyX += randomNumber;
                Console.WriteLine($" {Thread.CurrentThread.Name} {MyX} Крокiв");
                if (MyX >= 100)
                {
                    break;
                }
            }
            
        }
    }
}

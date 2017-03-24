using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            Set_thenout();
         
            Console.ReadKey();
        }

        static void Set_thenout()
        {


            System.Timers.Timer t = new System.Timers.Timer(1000);
            var ss= new System.Timers.ElapsedEventHandler(theout);
            t.Elapsed += ss;
            t.AutoReset = true;
            t.Start();
          
        }
    
        static void theout(object source, System.Timers.ElapsedEventArgs e)
        {
            if (e.SignalTime.Second%10==0)
            {
                Console.WriteLine("时间到了！");
            }
          
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentScheduler;

namespace FluentScheduler
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 简单定时执行
            //JobManager.AddJob(() =>  {     Console.WriteLine( DateTime.Now);    }, t =>  {     t.ToRunNow().AndEvery(1).Seconds();  });

            //简单执行 方法
            //JobManager.AddJob(Write,t => t.ToRunEvery(1).Seconds());

            //每天10:00 定时执行
            //JobManager.AddJob(Write,t => t.ToRunEvery(1).Days().At(10,34));
            Console.ReadKey();
        }

        static void Write()
        {
            Console.WriteLine(DateTime.Now);
        }
       
      
    }
}

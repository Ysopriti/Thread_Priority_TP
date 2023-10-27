using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace frmTrackThread
{
   
    internal class MyThreadClass //Create class named "MyThreadClass"
    {      
        public static void Thread1() //static method named "Thread1"
        {          
            for (int LoopCount = 0; LoopCount <= 2;  LoopCount++) //Create a loop that loops two (2) times in Thread1
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + LoopCount);
                Thread.Sleep(500);
            }
        }

        public static void Thread2() //static method named "Thread2"
        {           
            for (int LoopCount = 0; LoopCount < 6; LoopCount++) //Create a loop that loops six (6) times
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + LoopCount);
                Thread.Sleep(1500);
            }
        }
    }
}

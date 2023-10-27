using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmTrackThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void Thread()
        {
            Console.WriteLine("--Thread Starts--");

            ThreadStart threadstart = new ThreadStart(MyThreadClass.Thread1);

            //creating thread named "threadA"
            Thread threadA = new Thread(threadstart);
            threadA.Priority = System.Threading.ThreadPriority.Highest; //setting the priority for each thread
            threadA.Name = "Thread A Process";

            //creating thread named "threadB"
            Thread threadB = new Thread(new ThreadStart(MyThreadClass.Thread2));
            threadB.Priority = System.Threading.ThreadPriority.Normal; //setting the priority for each thread
            threadB.Name = "Thread B Process";

            //creating thread named "threadC"
            Thread threadC = new Thread(threadstart);
            threadC.Priority = System.Threading.ThreadPriority.AboveNormal; //setting the priority for each thread
            threadC.Name = "Thread C Process";

            //creating thread named "threadD"
            Thread threadD = new Thread(new ThreadStart(MyThreadClass.Thread2));
            threadD.Priority = System.Threading.ThreadPriority.BelowNormal; //setting the priority for each thread
            threadD.Name = "Thread D Process";
          
            //starting the thread
            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            //use the join() method to stop calling thread
            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            Console.WriteLine("--End of Thread--");
          
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "--Thread Starts--";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread();
            label1.Text = "--End of Thread--";
        }
    }
}

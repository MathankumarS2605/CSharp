using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingTheC_
{
    internal class ClassA
    {
        public static void TestOne()
        {
            int id = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"CurrentThreadID:{id}");
            TaskFactory tf = new TaskFactory();
            Task t1 = tf.StartNew(ClassA.TaskMethodA);         



            Task t2 = Task.Factory.StartNew(ClassA.TaskMethodA);

            Task t3 = new Task(ClassA.TaskMethodA);
            t3.Start();
            Console.WriteLine("hii");
            Task t4 = new Task(ClassA.TaskMethodA);
            Console.WriteLine("hii");
            t4.Start();
        }

        private static void TaskMethodA()
        {
            int id = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"CurrentThreadID:{id}");

            //Console.WriteLine("TaskMethodA called");
        }
    }
}

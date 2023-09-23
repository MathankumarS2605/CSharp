using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization1
{
    internal class Task1
    {
        public static void TestOne()
        {
            int id = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"CurrentThreadID:{id}");
            //TaskFactory tf = new TaskFactory();
            //Task t1 = tf.StartNew(ClassA.TaskMethodA);         



            //Task t2 = Task.Factory.StartNew(ClassA.TaskMethodA);



            Task t3 = new Task(ClassA.TaskMethodA);
            t3.Start();
            Task t4 = new Task(ClassA.TaskMethodA);
            t4.Start();
        }

    }
    public class ClassA
    {
       static  CancellationTokenSource cts = new CancellationTokenSource();
        public static void TaskMethodA()
        {
            Console.WriteLine("Running TaskA");
            Console.WriteLine($"TaskAn ID : {Task.CurrentId} completed");
            
        }
        public static void TaskMethodB(Task t)
        {
            Console.Write("running TaskB");
            Console.WriteLine($" After task {t.Id} ");
            Thread.Sleep(15000);
            Console.WriteLine($"taskB id {Task.CurrentId} Completed");
        }
        public static void TaskMethodC(Task t)
        {
            Console.Write("running TaskC");
            Console.WriteLine(" After task {0} ", t.Id);
            Thread.Sleep(1000);
            Console.WriteLine("taskC id {0} Completed", Task.CurrentId);
        }
        public static void TaskMethodB1(Task t)
        {
            Console.Write("running TaskB1");
            Console.WriteLine(" After task {0} ", t.Id);
            Console.WriteLine("taskB1 id {0} Completed", Task.CurrentId);
        }
        public static async void ContinueTask()
        {
           
            
            Task t1 = new Task(ClassA.TaskMethodA);
            
            //  t1.,TaskContinuationOptions.OnlyOnRanToCompletion;
            Task t2 = t1.ContinueWith(ClassA.TaskMethodB);
            Task t3 = t1.ContinueWith(ClassA.TaskMethodC);
            Task t4 = t2.ContinueWith(ClassA.TaskMethodB1);
            t1.Start(); 
         
            Task.WaitAll(t2,t3,t4);

            //Console.WriteLine(t1.Status);
            Console.WriteLine("Bye from ContinueTask");
        }
        public static void ParentTask()
        {
            Console.WriteLine("Inside parentTask ");
            Console.WriteLine($"ParentTask id {Task.CurrentId}");
            Task child = new Task(ChildTask, TaskCreationOptions.AttachedToParent);
            child.Start();
            Console.WriteLine("parent has started child");
            Thread.Sleep(1000);
        }
        public static void ChildTask()
        {
            Console.WriteLine("child started");
            Console.WriteLine($"childTask id {Task.CurrentId}");
            Thread.Sleep(10000);
            Console.WriteLine("child finished");
        }
        public static void ParentAndChild()
        {
            var parent = new Task(ClassA.ParentTask);
            Console.WriteLine("ParentStatus1: " + parent.Status);
            parent.Start();
            Console.WriteLine("ParentStatus2: " + parent.Status);
            #region A
            Thread.Sleep(1000);
            Console.WriteLine("ParentStatus: " + parent.Status);
            Thread.Sleep(1000);
            Console.WriteLine("ParentStatus: " + parent.Status);
            #endregion
            Console.WriteLine("Test Completed");
        }
    }
}

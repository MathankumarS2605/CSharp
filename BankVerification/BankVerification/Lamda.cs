using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BankVerification
{
    internal class Lamda
    {
        int x = 0;
        public static void DemoCurrentTH()
        {
            Thread t1=Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("ThreadID"+id);
            Console.WriteLine("ISAlive= "+t1.IsAlive);
            Console.WriteLine("Pripority="+t1.Priority);
            Console.WriteLine("ThreadState="+t1.ThreadState);
            Console.WriteLine("CurrentCulture="+t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());

            t1.CurrentCulture=new System.Globalization.CultureInfo("fr-FR");
            Console.WriteLine("CurrentCulture="+t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            t1.CurrentCulture = new System.Globalization.CultureInfo("ta");
            Console.WriteLine(DateTime.Now.ToLongDateString());

        }

        /// <summary>
        /// 
        /// </summary>
        public   void DoTask()
           
        {
            Monitor.Enter(this);
            Thread t1=Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("inside DoTask");
            Console.WriteLine(id);
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    //  Thread t1=new Thread(x);
                    x += i;

                    Console.WriteLine("ID: " + id + "X= " + x + " i=" + i);
                    Thread.Sleep(1000);//1s=1000ms

                }
            }
            finally
            {
                Monitor.Exit(this); 
            }
        }
        public static void DemoA()
        {
            Thread t1=Thread.CurrentThread;
            int id= t1.ManagedThreadId;
            Console.WriteLine("MainTh ID "+id);
            Lamda l1=new Lamda();
            l1.DoTask();
        }
        public static void DemoB()
        {
            Thread t1=Thread.CurrentThread; 
            int id= t1.ManagedThreadId;
            Console.WriteLine("MainTh ID "+id);
            Lamda lamda=new Lamda();
            Thread thread = new Thread(lamda.DoTask);//delegate
            lamda.DoTask(); 
            Console.WriteLine("----------End of DemoB--------");
            //thread.Priority
        }
        public static void DemoB2()
        {
            Thread t=Thread.CurrentThread;
            int id= t.ManagedThreadId;
            Console.WriteLine("Main ID" + id);
            Lamda a1 = new Lamda();
            Thread t1 = new Thread(a1.DoTask);
            Console.WriteLine(t1.ManagedThreadId+"T1  State "+t1.ThreadState);
            t1.Start();
            Console.WriteLine(t1.ManagedThreadId+"  State After Start "+t1.ThreadState);
            Thread.Sleep(3000);
            Console.WriteLine(t1.ManagedThreadId + " T1 state After sleep "+t1.ThreadState);
            Console.WriteLine("--------End of DemoB------");

        }

        public static void Demo2()
        {
            Thread thread=Thread.CurrentThread;
            int id= thread.ManagedThreadId;
            Console.WriteLine("Mainth ID"+id);
            Lamda lamda = new Lamda();
            ThreadStart ts=lamda.DoTask;
            Thread t1 = new Thread(ts);
          

        }
    }
}

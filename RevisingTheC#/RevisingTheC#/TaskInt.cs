using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace RevisingTheC_
{
    public delegate int fel(CancellationToken ct);
    internal class TaskInt
    {
       
       public  static int GenerateNumbers(CancellationToken ct)
        {
            int i;
            for (i = 0; i < 1000; i++)
            {
                Console.WriteLine("Method1 - Number: {0}", i);
                Thread.Sleep(1000);
                // poll the IsCancellationRequested property
                // to check if cancellation was requested
                if (ct.IsCancellationRequested)
                {
                    break;
                }
            }
            return i;
        }
        // Notify when task is cancelled
        static void CancelNotification()
        {
            Console.WriteLine("Cancellation request made!!");
        }
        public static void TestCancelToken()
        {
            Console.WriteLine("Press 1 to cancel task");
            var cTokenSource = new CancellationTokenSource();
           
            var cToken = cTokenSource.Token;
           // var car = () => ;
           var t= Task<int>.Factory.StartNew(
              () => TaskInt.Ku(cToken), cToken);
            // to register a delegate for a callback when a 
            // cancellation request is made
            cToken.Register(TaskInt.CancelNotification);
            // If user presses 1, request cancellation.
            //if (Console.ReadKey().KeyChar == '1')
            //{
            //    cTokenSource.Cancel();
            //}
            Kv();
           
            
;        }
        public static int Ku(CancellationToken ct )
        {
            Console.WriteLine("KU KU HIIII");
            return 0;
        }
        public static void Kv()
        {
            Console.WriteLine("Kv Kx HIIII");
        } 

        }
    }

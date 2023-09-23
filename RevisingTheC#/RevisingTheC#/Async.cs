using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingTheC_
{
    internal class Async
    {
        public static async void Await()
        {
            Task<int> name = Async.Asynic();

            int result = await name;
            Console.WriteLine(result);  

        }
        public  static async Task<int> Asynic()
        {
            await Task.Delay(1000);
            return 1;
        }

    }
}

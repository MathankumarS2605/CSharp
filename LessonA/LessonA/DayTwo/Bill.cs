using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayTwo
{
    internal class Bill
    {
        private Bill()
        {
            Console.WriteLine("hii");
        }
        public static Bill CreateBill()
        {
            return new Bill();  
        }
    }
}

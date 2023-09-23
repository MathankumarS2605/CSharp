using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TestPreparation
{
    internal class Inheritance
    {
        public  virtual void Name()
        {
            Console.WriteLine("parent class");
        }
    }
    internal class Hi : Inheritance
    {
        public override void Name()
        {
            Console.WriteLine("child class");
        }
    }

}

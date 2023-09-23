using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayTwo
{
    internal abstract  class  Vehicle
    {
        public Vehicle()
        {
            Console.WriteLine("Vehicle Constructor");
        }
        public abstract void Start();
        public void Stop()
        {
            Console.WriteLine("Stop");
        }
    }
    internal class Car : Vehicle
    {
       // public TwoWheeler() { }
        public override void Start()
        {
            Console.WriteLine("");
        }
    }
}

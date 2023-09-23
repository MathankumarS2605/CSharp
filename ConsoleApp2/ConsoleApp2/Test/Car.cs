using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum FuelType
{
    Petrol,
    Deisel
}
namespace ConsoleApp2.Test
{
    internal class Car
    {
        private readonly Wheel __wheel;
        private readonly Engine __engine;

        public int registrationNo { get; set; }
        public string model { get; set; }
        public FuelType type;

        public Car()
        {
            __wheel = new Wheel(this);
            __engine = new Engine(this);

        }
        public Wheel GetWheel() { return __wheel; } 
        public Engine   
        




        public class Wheel
        {
            private readonly Car __car;
            public Wheel(Car c)
            {
                if (__car != null)
                {
                    new Exception("Car Object is null");
                }
                __car = c;


            }
            public void startWheeling()
            {
                if (Car.Engine.start == false)
                {
                    Console.WriteLine("First Start the Engine");
                }
            }

            public Car getOuterObject()
            {
                return __car;
            }
        }
        class Engine
        {
            public static bool start = false;
            public static bool stop = false;
            static int i = 1;
            private readonly Car __car;
            public Engine(Car c)
            {
                if (__car != null)
                {
                    new Exception("Car Object is null");
                }
                __car = c;

            }
            public Engine()
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("engine Start");
                    i++;
                    start = true;
                }
                else
                {
                    Console.WriteLine("Engine Stop");
                    i++;
                    stop = true;

                }


            }

        }
    }
}

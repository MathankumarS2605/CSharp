using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySeven.NewFolder
{
    internal class Car
    {
        private readonly Wheel __wheel;
        private readonly Engine __engine;
        public int no { get; set; }
        public string model { get; set; }   

        
         

        public Car()
        {
            __wheel = new Wheel(this);
            __engine = new Engine(this);
        }
        public Wheel GetWheel() { return __wheel; }
        public Engine GetEngine() { return __engine; }  

        public class Wheel
        {
            private readonly Car car;
            const int NO_OF_WHEELS = 4;
            public int wheel { get; set; }
            public static bool isFourWheel = true;


            public Wheel(Car c)
            {
                if (c== null)
                {
                    Console.WriteLine("CAR object is not instantiated");
                }
                else
                {
                    car = c;
                }
            }
            //Second Method put the COnstructor to private 
            private Wheel()
            {
                Console.WriteLine("Not Allow to create the Wheel Object");
            }

            public static bool CheckTheWheel(int n)
            {
                if(n != NO_OF_WHEELS)
                {
                    Console.WriteLine("Wheel Must 4 Set Wheel to 4");
                    isFourWheel= false;
                    return isFourWheel;
                }
                return isFourWheel;
            }
            public static void StartDriving()
            {
                if(Engine.isStart == true  )
                {
                    Console.WriteLine("Start driving");
                }
                else
                {
                    Console.WriteLine("First Start the engine");
                }
            }
        }
        public class Engine {
            public static bool isStart = false;
           // public static bool isStop = false;
            private readonly Car car;
            public Engine(Car c)
            {
                if(c == null)
                {
                    Console.WriteLine("CAR object is not instantiated");
                }
                else { car = c; 
                }
            }
            //Second Method put the COnstructor to private 
            private Engine()
            {
                Console.WriteLine("Not Allow to create the gine Object");
            }

            public void Start()
            {
                if (Wheel.isFourWheel == true && isStart == false)
                {
                    Console.WriteLine("Engine starting");
                    isStart = true;
                }
                else
                {
                    Console.WriteLine("Wheel must be 4 Unable to Start");
                }
            }
            public void Stop()
            {  if (isStart == true)
                {
                    Console.WriteLine("Engine Stoping");
                    isStart = false;
                }
                else
                {
                    Console.WriteLine("It is Already  Stopped");
                }
            }
        }


    }
  
        public delegate void MethodHandlerA();
        public delegate int MethodHandlerB(int x, int y);

        public class MathCalculator
        {
            public void DoTask()
            {
                Console.WriteLine("calculator DoTask");
            }
            public int Add(int x, int y)
            {
                Console.WriteLine(x + ", " + y);
                return x + y;
            }
            public int Multiply(int x, int y)
            {
                Console.WriteLine(x + ", " + y);
                return x * y;
            }
            public double Divide(double x, double y)
            {
                Console.WriteLine(x + ", " + y);
                return x / y;
            }
            public String GetModel()
            {
                return "x500";

            }
        }
        public class DelegateDemo
        {
            public static void TestOne()
            {
                MathCalculator mc = new MathCalculator();
                MethodHandlerA methodHandlerA = mc.DoTask;// new MethodHandlerA(mc.DoTask);
                MethodHandlerB methodHandlerBd = mc.Add;
                MethodHandlerB methodHandlerTwo = mc.Multiply;
                methodHandlerA();
                int addresult = methodHandlerBd(100, 50);
                Console.WriteLine(addresult);
                int multiplyresult = methodHandlerTwo(20, 5);
                Console.WriteLine(multiplyresult);



            }
            public static void TestTWO()
            {
                MathCalculator mc = new MathCalculator();
                MethodHandlerB methodHandlerB = mc.Add;
                methodHandlerB += mc.Multiply;
                int x = methodHandlerB(2, 3);
                Console.WriteLine(x);


            }

        }
    }

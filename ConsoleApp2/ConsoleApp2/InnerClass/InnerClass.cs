using ConsoleApp2.Arrays;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp2.InnerClass.Emp;

namespace ConsoleApp2.InnerClass
{
    internal class Emp
    {
        public int Eno = 0;
        private readonly Address address;
        public Emp()
        {
            address = new Address(this);
             Console.WriteLine(address);
           // Console.WriteLine(this);
        }
        public Address GetAddress()
        {
            return address;
        } 
        public class Address
        {
            public string Address1;
            public string Address2;
            private readonly Emp e1;

           public  Address(Emp outerEmp)
            {
                if(outerEmp == null)
                {
                    throw new NullReferenceException("Outer Emp is NULL");
                }
                e1 = outerEmp;
                Console.WriteLine(e1);
            }
        }
    }
    class TestEmp
    {
        public static void TestA()
        {
            try
            {
                Emp.Address address = new Emp.Address(null);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            Emp e1 = new Emp();
            //Inner class object
            Emp.Address add = e1.GetAddress();
            add.Address1 = "Ambattur";
            add.Address2 = "Chennai";
           // Console.WriteLine($"Address1:{add.Address1}");
           // Console.WriteLine($"Address2:{add.Address2}");
        }
    }

}

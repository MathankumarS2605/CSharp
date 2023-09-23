using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    public enum City { Chennai, Banglore, Hyderbad, Pune };
    public enum Designation { Manager, Admin, Developer };
    internal class Employee
    {
        public readonly int Eid;
        public String Ename;
        public City Ecity;
        public Designation JobTitle;
        public Employee(int v1)
        {
            this.Eid = v1;
        }
        public override string ToString()
        {
            String output = String.Empty;
            output = $"Details of a employee are ID ={Eid} Name={Ename} {Ecity} {JobTitle}";
            return output;
        }
    }
    internal class TestMovieRating
    {
        public static void TestMovie1Rating()
        {
            Type t1= typeof(TestMovieRating);
            String[] enumNames=Enum.GetNames(t1);   
            for(int i=0; i<enumNames.Length; i++)
            {
               
            }


        }
    }
    
}

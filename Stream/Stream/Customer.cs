using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream1
{
    [Serializable]//attributes
    internal class Customer
    {
        private readonly double _id;
        public String Title;
        //obj.Title="ccc";
        
        public string FirstName { get; set; }  
        //obj.firstName="Mathan"
        //string s=obj.firstName;
        public string LastName { get; set; } =String.Empty;

        public double? CreditLimit { get; set; }
        public Customer(double v1) {
            _id = v1;
       }
        public override string ToString()
        {
            return $"Details:{_id} {FirstName} {LastName} {CreditLimit}";
        }
    }
}

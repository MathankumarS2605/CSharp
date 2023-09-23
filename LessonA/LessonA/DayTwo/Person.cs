using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayTwo
{
    internal class Person
    {
        //public Person(Person person) { 
        //    Pers
        ////{
        //}
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;// is instantiate the string so that to avoid null pointer Exception .
        public string LastName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"ID:{this.Id},Name {this.FirstName},LastName:{this.LastName} , \n" +
             $"Address:{Address},Phone:{Phone},Country:{Country}, City:{this.Country},\n Region.{this.Region}";
        }

    }
    internal class TestPerson
    {
        public static void TestOne()
        {
            //DateOnly.FromDateTime;
            Person person = new Person();
            person.FirstName = "Mathan";
            person.LastName = "Kumar";
            person.Address = "Thanjavur";
            person.City = "Thanjavur";
            person.Country = "India";
            person.Phone = "12345";
            person.Region = "HHHH";

            //String value = person.ToString();
            //Console.WriteLine(value);
            string[] arr=person.Title.Split(',');
             for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}

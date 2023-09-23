using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayTwo
{
    internal class Insurance
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Occupation { get; set; } = string.Empty;
        public string Age { get; set; } = string.Empty;
        public String DateOfBirth { get; set; } = String.Empty;
        public string TypeOfInsurance { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"Id: {Id} \nName: {this.Name} \nOccupation: {this.Occupation} \n" +
                $"Age: {this.Age} \nDateOfBirth: {this.DateOfBirth}\nTypeOfInsurance: {this.TypeOfInsurance}";
        }

    }
    internal class TestInsurance
    {
        public static void TestInsurances()
        {
            string con = "y";
            
                while (con != "0")
               {
                   int i = 1;
                   Insurance insurance = new Insurance();
                    insurance.Id = i++;
                  Console.WriteLine("Enter the Name:");
                    insurance.Name = Console.ReadLine();
                   Console.WriteLine("Enter the DateOfBirth:");
                   insurance.DateOfBirth = Console.ReadLine();
                   Console.WriteLine("Enter the Occupation:");
                    insurance.Occupation = Console.ReadLine();
                   Console.WriteLine("Enter the AGE:");
                   insurance.Age = Console.ReadLine();
                   Console.WriteLine("Enter the Type Of Insurance:");
                    insurance.TypeOfInsurance = Console.ReadLine();

                    string value = insurance.ToString();
                    Console.WriteLine(value);
                      Console.WriteLine("enter 0 to exit: ");
                    String ans =Console.ReadLine();
                    con = ans;
                }
              }
        }
    }

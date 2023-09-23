using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstMVCApp.Models
{
    //public enum EmployeeEnum {
    //    Chennai,
    //    Banglore,

    //}

    public class Employee
    {
        [Key]
        public int Eno { get; set; }
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "Name must be between 3 and 20 chars")]
        public string Name { get; set; }   =string.Empty;
        public decimal Salary { get; set; }

        public string City { get; set; }=string.Empty;
    }
}

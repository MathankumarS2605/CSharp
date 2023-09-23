using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCEFApp.Models
{
    public class Patient
    {
        [Key]
        [Column("patientno")]
        public int Id { get; set; } = 0;
        [Required]
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "Name must be between 3 and 20")]
        public string Name { get; set; } = String.Empty;
        [Required]
        public string City { get; set; } = string.Empty;
        [Required]
         public DateTime DateOfBirth { get; set; }
        [Column(TypeName ="numeric(18,0)")]
        public long PhoneNumber { get; set; }   

    }
}

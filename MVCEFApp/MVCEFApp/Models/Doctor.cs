﻿using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVCEFApp.Models
{
    public class Doctor
    {
        [Key]
        [Column("doctorno")]
        public int Id { get; set; } = 0;
        [Required]
        [StringLength(20)]
        [MinLength(3,ErrorMessage ="Name must be between 3 and 20")]
        public string Name { get; set; } = String.Empty;
        [Required]
        public string Speciality { get; set; } = String.Empty;
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [Column(TypeName = "numeric(18,2)")]
        public decimal VistingFees { get;set; }
        [Required]
        [Column(TypeName = "numeric(18,0)")]
        public long PhoneNumebr { get; set; }   
    }
}

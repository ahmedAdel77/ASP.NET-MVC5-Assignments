using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Day02.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Range(1000.00, 20000.00)]
        public double Salary { get; set; }

        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabTask1.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Provide Your Name")]
        public string Name { get; set; }
        [Required]
        public DateTime Dob { get; set; }
        [Required]
        public int Credit { get; set; }
        [Required]
        public double CGPA { get; set; }
        [Required]
        public int Dept { get; set; }
    }
}
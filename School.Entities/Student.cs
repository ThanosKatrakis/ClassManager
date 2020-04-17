using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace School.Entities
{
    public class Student
    {
        public int StudentId { get; set; }


        [Required, MaxLength(40), MinLength(2)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Required, MaxLength(40), MinLength(2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Required, Range(0, 5000)]
        [Display(Name = "Tuition Fees")]
        public int TuitionFees { get; set; }


        [Required]
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }


        [Display(Name = "Photo")]
        public string PhotoUrl { get; set; }


        // Navigation Properties
        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}

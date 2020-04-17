using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace School.Entities
{
    public class Course
    {
        public int CourseId { get; set; }


        [Required, MaxLength(40), MinLength(2)]
        public string Title { get; set; }


        [Required, MaxLength(40), MinLength(2)]
        public string Stream { get; set; }


        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }


        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }


        [Display(Name = "Photo")]
        public string PhotoUrl { get; set; }


        // Navigation Properties
        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual ICollection<Trainer> Trainers { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace School.Entities
{
    public class Assignment
    {
        public int AssignmentId { get; set; }


        [Required, MaxLength(40), MinLength(2)]
        public string Title { get; set; }


        [Required, MaxLength(40), MinLength(5)]
        public string Description { get; set; }


        [Required]
        [Display( Name = "Submission Date")]
        public DateTime SubmissionDate { get; set; }


        [Required, Range(0, 100)]
        [Display(Name = "Oral Mark")]
        public int OralMark { get; set; }


        [Required, Range(0, 100)]
        [Display(Name = "Total Mark")]
        public int TotalMark { get; set; }


        // Navigation Properties
        public virtual ICollection<Student> Students { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}

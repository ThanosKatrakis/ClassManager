using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace School.Entities
{
    public class Trainer
    {
        public int TrainerId { get; set; }


        [Required, MaxLength(40), MinLength(2)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Required, MaxLength(40), MinLength(2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Required, MaxLength(40), MinLength(1)]
        [Display(Name = "Subject")]
        public string Subject { get; set; }


        [Display(Name = "Photo")]
        public string PhotoUrl { get; set; }


        // Navigation Properties
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}

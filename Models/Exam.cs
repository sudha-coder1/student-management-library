using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    internal class Exam
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal MaxMarks { get; set; }

        

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SchoolManagement.EnumValues;

namespace SchoolManagement.Models
{
    public class User
    {
        //public string Id { get; set; }
        [Required]
        public string FName { get; set; }
        [Required]
        public string LName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public Users Usertype { get; set; }
        public Gender Gender { get; set; }
        public string Phone { get; set; }
        [Required]
        public string Password { get; set; }
    }
}

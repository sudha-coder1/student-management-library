using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    internal class School
    {

        public string Name { get; set; }
        public string FounderName { get; set; }
        public string Affliation { get; set; }
        public string Email { get; set; }
        public string PanNumber { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }
        public bool AnyBranch { get; set; }

    }
}

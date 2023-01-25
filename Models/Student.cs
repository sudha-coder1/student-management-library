using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SchoolManagement.EnumValues;

namespace SchoolManagement.Models
{
    public class Student : User
    {
        public int RollNumber { get; set; }
        public Standard EnrolledClass { get; set; }
    }
}

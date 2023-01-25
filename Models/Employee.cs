using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SchoolManagement.EnumValues;

namespace SchoolManagement.Models
{
    public class Employee : User
    {
        public int EmployeeId { get; set; }
        public Designation Designation { get; set; }

        public long Salary { get; set; }

        public float Experience { get; set; }


    }
}

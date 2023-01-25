using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SchoolManagement.EnumValues;

namespace SchoolManagement.Models
{
    internal class Attendance
    {
        public int RollNumber { get; set; }
        public Status AttendanceStatus { get; set; }
    }
}

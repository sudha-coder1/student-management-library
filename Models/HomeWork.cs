using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    internal class HomeWork
    {
        public DateTime AssignedDate { get; set; }

        public DateTime LastDateToComplete { get; set; }

        public bool IsCompleted { get; set; }


    }
}

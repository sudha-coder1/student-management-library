using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SchoolManagement.EnumValues;

namespace SchoolManagement.Models
{
    internal class Request
    {
        public int Id { get; set; }

        public RequestCategory Category { get; set; }

        public Users RequesterId { get; set; }

        public int Title { get; set; }

        public int Description { get; set; }

    }
}

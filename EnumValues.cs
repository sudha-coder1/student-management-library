using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SchoolManagement
{
    public class EnumValues
    {
        public enum Users
        {
            [Description("Employee")]
            Employee,
            [Description("Student")]
            Student

        }

        public enum Designation
        {
            [Description("Admin")]
            Admin,
            [Description("Teacher")]
            Teacher

        }

        public enum Gender
        {
            [Description("Male")]
            Male,
            [Description("Female")]
            Female,
            [Description("Others")]
            Others
        }

        public enum Subjects
        {
            [Description("English")]
            English,
            [Description("Telugu")]
            Telugu,
            [Description("Hindi")]
            Hindi,
            [Description("Maths")]
            Maths,
            [Description("Science")]
            Science,
            [Description("Social")]
            Social,
            [Description("Others")]
            Others

        }

        public enum RequestCategory
        {
            [Description("Admin")]
            Admin,
            [Description("Leave")]
            Leave,
            [Description("Others")]
            Others
        }

        public enum Languages
        {
            [Description("English")]
            English,
            [Description("Hindi")]
            Hindi,
            [Description("Telugu")]
            Telugu,
            [Description("Others")]
            Others
        }

        public enum Standard
        {
            [Description("Default")]
            Default,
            [Description("Nursery")]
            Nursery,
            [Description("LKG")]
            LKG,
            [Description("UKG")]
            UKG,
            [Description("FIRST")]
            I,
            [Description("SECOND")]
            II,
            [Description("THIRD")]
            III,
            [Description("FOURTH")]
            IV,
            [Description("FIFTH")]
            V,
            [Description("SIXTH")]
            VI,
            [Description("SEVENTH")]
            VII,
            [Description("EIGHT")]
            VIII,
            [Description("NINTH")]
            IX,
            [Description("TENTH")]
            X
        }

        public enum Status
        {
            [Description("Present")]
            Present,
            [Description("Absent")]
            Absent,
            [Description("OnLeave")]
            OnLeave
        }

        public enum BloodGroup
        {
            [Display(Name = "O+")]
            OPositive,
            [Display(Name = "A+")]
            APositive,
            [Display(Name = "B+")]
            BPositive,
            [Display(Name = "AB+")]
            ABPositive,
            [Display(Name = "AB-")]
            ABNegative,
            [Display(Name = "A-")]
            ANegative,
            [Display(Name = "B-")]
            BNegative,
            [Display(Name = "O-")]
            ONegative

        }
    }
}

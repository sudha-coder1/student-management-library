using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static SchoolManagement.EnumValues;

namespace SchoolManagement
{
    public static class EnumExtension
    {

        public  static Gender getGenderName(this EnumValues enumValues)
        {
            Gender genderTypeName;
            int count = 0;
            foreach (string gender in Enum.GetNames(typeof(Gender)))
            {

                {
                    count++;
                    Console.Write(count);
                    Console.WriteLine(":" + gender);
                }
            }

            Console.WriteLine("Enter the value for your Gender");
            int GenderValue = Convert.ToInt32(Console.ReadLine());

            if (GenderValue == 1)
            {
                genderTypeName = EnumValues.Gender.Male;
            }
            else if (GenderValue == 2)
            {
                genderTypeName = EnumValues.Gender.Female;
            }

            else
            {
                genderTypeName = EnumValues.Gender.Others;
            }
            return genderTypeName;
            ;
        }
        public static Users getUserTypeName(this EnumValues enumValues)
        {
            Users UserTypeName;
            int count = 0;
            foreach (string user in Enum.GetNames(typeof(Users)))
            {

                {
                    count++;
                    Console.Write(count);
                    Console.WriteLine(":" + user);
                }
            }

            Console.WriteLine("Enter the value for user type");
            int UserTypeValue = Convert.ToInt32(Console.ReadLine());

            if (UserTypeValue == 1)
            {
                UserTypeName = Users.Employee;
            }
            else
            {
                UserTypeName = Users.Student;
            }

            return UserTypeName;

        }

        public static Designation getDesignation(this EnumValues enumValues)
        {
            Designation Designation1;

            int count = 0;
            foreach (string designation in Enum.GetNames(typeof(Designation)))
            {

                {
                    count++;
                    Console.Write(count);
                    Console.WriteLine(":" + designation);
                }
            }

            Console.WriteLine("Enter the value for Designation");
            int DesignationValue = Convert.ToInt32(Console.ReadLine());

            if (DesignationValue == 1)
            {
                Designation1 = Designation.Admin;
            }
            else
            {
                Designation1 = Designation.Teacher;
            }

            return Designation1;

        }

        public static Standard getEnrolledClass(this EnumValues enumValues)
        {

            Standard EnrolledClass = Standard.Default;
            int count = 0;
            foreach (string enrolled in Enum.GetNames(typeof(Standard)))
            {

                {
                    count++;
                    Console.Write(count);
                    Console.WriteLine(":" + enrolled);
                }
            }

            Console.WriteLine("Enter the value for Enrolling a Class");
            int EnrolledValue = Convert.ToInt32(Console.ReadLine());

            switch (EnrolledValue)
            {
                case 1:
                    EnrolledClass = Standard.Nursery;
                    break;
                case 2:
                    EnrolledClass = Standard.LKG;
                    break;
                case 3:
                    EnrolledClass = Standard.UKG;
                    break;
                case 4:
                    EnrolledClass = Standard.I;
                    break;
                case 5:
                    EnrolledClass = Standard.II;
                    break;
                case 6:
                    EnrolledClass = Standard.III;
                    break;
                case 7:
                    EnrolledClass = Standard.IV;
                    break;
                case 8:
                    EnrolledClass = Standard.V;
                    break;
                case 9:
                    EnrolledClass = Standard.VI;
                    break;
                case 10:
                    EnrolledClass = Standard.VII;
                    break;
                case 11:
                    EnrolledClass = Standard.VIII;
                    break;
                case 12:
                    EnrolledClass = Standard.IX;
                    break;
                case 13:
                    EnrolledClass = Standard.X;
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            };


            return EnrolledClass;

        }

    }
}

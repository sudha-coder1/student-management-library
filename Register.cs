using Newtonsoft.Json;
using SchoolManagement.Models;
using static SchoolManagement.EnumValues;

namespace SchoolManagement
{
    public class Register
    {

        public string studentJsonPath = @"F:\repo\Sample\SchoolManagement\SchoolMnagement\Data\StudentList.json";
        public string employeeJsonPath = @"F:\repo\Sample\SchoolManagement\SchoolMnagement\Data\EmployeeList.json";
        EnumValues enumValues = new EnumValues();
        public void RegisterUser()
        {
            int id = 0;
            Console.WriteLine("Enter FirstName");
            var fName = Console.ReadLine();
            Console.WriteLine("Enter LastName");
            var lName = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            var phone = Console.ReadLine();
            Gender gender = enumValues.getGenderName();
            Users userType = enumValues.getUserTypeName();
            Console.WriteLine("Enter Email");
            var email = Console.ReadLine();
            Console.WriteLine("Enter Password");
            var password = Console.ReadLine();

            if (userType.ToString() == "Student" )
            {
                 
                Console.WriteLine("Enter value for the enrolling class");
                Standard enrolledClass = enumValues.getEnrolledClass();
                Student student = new Student();
                student.FName = fName;
                student.LName = lName;
                student.Email = email;
                student.Password = password;
                student.Phone = phone;   
                student.Gender = gender;
                student.Usertype = userType;
                student.EnrolledClass = enrolledClass;
                var studentList = GetStudentsData();

                int val = studentList.Count > 0 ?  1 : 0;
              
                if (studentList == null)
                {
                    id = 1;
                    List<Student> newStudentList = new List<Student>();
                    
                    student.RollNumber = id;
                    newStudentList.Add(student);
                    var newStudent = Newtonsoft.Json.JsonConvert.SerializeObject(newStudentList, Formatting.Indented);
                    System.IO.File.WriteAllText(studentJsonPath, newStudent);
                    Console.WriteLine("Student Saved Successfully");

                }
                else
                {
                    int count = studentList.Count();
                    Console.WriteLine(count);
                    id = new Random().Next(1, 60);
                    foreach (var studentS in studentList)
                    {
                        if (studentS.RollNumber == id)
                        {
                            id = new Random().Next(1, 60);
                            break;
                        }
                    }
                    student.RollNumber = id;
                    studentList.Add(student);
                    var newStudent = Newtonsoft.Json.JsonConvert.SerializeObject(studentList, Formatting.Indented);
                    System.IO.File.WriteAllText(studentJsonPath, newStudent);
                    Console.WriteLine("Student Saved Successfully");
                }




            }
            else
            {
                Console.WriteLine("Enter value for Designation");
                Designation designation = enumValues.getDesignation();
                Console.WriteLine("Enter Salary");
                var salary = Console.ReadLine();
                Console.WriteLine("Enter Experience");
                var experience = Console.ReadLine();
                Employee employee = new Employee();
                employee.FName = fName;
                employee.LName = lName;
                employee.Email = email;
                employee.Password = password;
                employee.Gender = gender;
                employee.Usertype = userType;
                employee.Designation = designation;
                employee.Salary = Convert.ToInt64(salary);
                employee.Experience =(float)Convert.ToDouble(experience);
                var employeeList = GetEmployeesData();

                if (employeeList == null)
                {
                    id = 1;
                    List<Employee> newEmployeeList = new List<Employee>();
                    employee.EmployeeId = id;
                    newEmployeeList.Add(employee);
                    var newEmployee = Newtonsoft.Json.JsonConvert.SerializeObject(newEmployeeList, Formatting.Indented);
                    System.IO.File.WriteAllText(employeeJsonPath, newEmployee);
                    Console.WriteLine("Employee Saved Successfully");

                }
                else
                {
                    int count = employeeList.Count();
                    Console.WriteLine(count);
                    id = employeeList[count - 1].EmployeeId + 1;
                    employee.EmployeeId = id;
                    employeeList.Add(employee);
                    var newEmployee = Newtonsoft.Json.JsonConvert.SerializeObject(employeeList, Formatting.Indented);
                    System.IO.File.WriteAllText(employeeJsonPath, newEmployee);
                    Console.WriteLine("Employee Saved Successfully");
                }


            }


        }
        public void LoginUser()
        {
            Users userType = enumValues.getUserTypeName();
            if (userType.ToString() == "Student")
            {
                StudentLogin();
            }
            else if(userType.ToString() == "Employee")
            {
                EmployeeLogin();
            }
            else
            {
                Console.WriteLine("User input InValid");
            }

        }

        public void UpdateUser()
        {
            Users userType = enumValues.getUserTypeName();
            if (userType.ToString() == "Student")
            {
                UpdateStudent();
            }
            else if (userType.ToString() == "Employee")
            {
                UpdateEmployee();
            }
            else
            {
                Console.WriteLine("User input InValid");
            }

        }
        public void DeleteUser()

        {
            Users userType = enumValues.getUserTypeName();
            if (userType.ToString() == "Student")
            {
                DeleteStudent();
            }
            else if (userType.ToString() == "Employee")
            {
                DeleteStudent();
            }
            else
            {
                Console.WriteLine("User input InValid");
            }
        }


        public  void EmployeeLogin()
        {
            string username = String.Empty;
            string password = String.Empty;
            List<Employee> employeeList = GetEmployeesData(); 
            int count = employeeList.Count();

            Console.WriteLine(count);
            Console.WriteLine("Enter Username");
            username = Console.ReadLine();
            


            for (int i = 0 ; i < count; i++)
            {
                if(username == employeeList[i].Email)
                {
                    if (employeeList[i].Designation.Equals("Admin"))
                    {
                        Console.WriteLine("Enter admin password");
                        Console.ReadLine();
                    }
                    Console.WriteLine("Enter Password");
                    password = Console.ReadLine();

                    if (password == employeeList[i].Password)
                    {
                        Console.WriteLine("Correct username & password");
                        Console.Clear();
                        Console.ReadKey();
                    }
                  
                }
                else
                {
                    Console.WriteLine("Incorrect User or Password");
         
                }
            }

            
        }

        public  void StudentLogin()
        {
            string username = String.Empty;
            string password = String.Empty;
            List<Student> studentList = GetStudentsData();
            int count = studentList.Count();

            Console.WriteLine(count);
            Console.WriteLine("Enter Username");
            username = Console.ReadLine();



            for (int i = 0; i < count; i++)
            {
                if (username == studentList[i].Email)
                {
                    Console.WriteLine("Enter Password");
                    password = Console.ReadLine();

                    if (password == studentList[i].Password)
                    {
                        Console.WriteLine("Correct username & password");
                        Console.Clear();
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Password!");
                        Thread.Sleep(500);
                    }

                }
                else
                {
                    Console.WriteLine("Incorrect User!");
                    Thread.Sleep(500);
                }
               
            }

          
        }

        public void UpdateStudent()
        {

            var studentList = GetStudentsData();
            int id = 0;
            Console.WriteLine("Enter the student ID which you want to update");
            int StudentId = Convert.ToInt32(Console.ReadLine());
            foreach (var student in studentList)
            {
                if (student.RollNumber == StudentId)
                {
                    Console.WriteLine("Enter Phone Number to update");
                    student.Phone = Console.ReadLine();
                    var UpdatedStudent = Newtonsoft.Json.JsonConvert.SerializeObject(studentList, Formatting.Indented);
                    System.IO.File.WriteAllText(@"F:\repo\Sample\SchoolManagement\SchoolMnagement\Data\StudentList.json", UpdatedStudent);
                    Console.WriteLine("User's data updated successfully.");
                }
            }

        }

        public void UpdateEmployee()
        {

            var employeeList = GetEmployeesData();
            int id = 0;
            Console.WriteLine("Enter the employee ID which you want to update");
            int EmployeeId = Convert.ToInt32(Console.ReadLine());
            foreach (var employee in employeeList)
            {
                if (employee.EmployeeId == EmployeeId)
                {
                    Console.WriteLine("Enter Phone Number to update");
                    employee.Phone = Console.ReadLine();
                    var UpdatedEmployee = Newtonsoft.Json.JsonConvert.SerializeObject(employeeList, Formatting.Indented);
                    System.IO.File.WriteAllText(@"F:\repo\Sample\SchoolManagement\SchoolMnagement\Data\StudentList.json", UpdatedEmployee);
                    Console.WriteLine("User's data updated successfully.");
                }
            }
        }
        public void DeleteStudent()
        {
            Console.WriteLine("Enter User Id");
            int userId = Convert.ToInt32(Console.ReadLine());
            List<Student> studentList = new List<Student>();
            int index = 0, currentObjectCount = 0;
            foreach (var student in studentList)
            {
                if (student.RollNumber == userId)
                {
                    index = currentObjectCount;
                }
                currentObjectCount++;
            }
            studentList.Remove(studentList[index]);
            Console.WriteLine("User deleted successfully.");
            var UpdatedList = Newtonsoft.Json.JsonConvert.SerializeObject(studentList);
            System.IO.File.WriteAllText(studentJsonPath, UpdatedList);
        }

        public void DeleteEmployee()
        {
            Console.WriteLine("Enter User Id");
            int userId = Convert.ToInt32(Console.ReadLine());
            List<Employee> employeeList = new List<Employee>();
            int index = 0, currentObjectCount = 0;
            foreach (var employee in employeeList)
            {
                if (employee.EmployeeId == userId)
                {
                    index = currentObjectCount;
                }
                currentObjectCount++;
            }
            employeeList.Remove(employeeList[index]);
            Console.WriteLine("User deleted successfully.");
            var UpdatedList = Newtonsoft.Json.JsonConvert.SerializeObject(employeeList);
            System.IO.File.WriteAllText(employeeJsonPath, UpdatedList);
        }

        public void GetUserDetails()
        {

        }

        public List<Student> GetStudentsData()
        {
            List<Student> studentList = new List<Student>();
            string studentJsonString = System.IO.File.ReadAllText(studentJsonPath);
            studentList = JsonConvert.DeserializeObject<List<Student>>(studentJsonString);
            return studentList;
        }

        public List<Employee> GetEmployeesData()
        {
            List<Employee> employeeList = new List<Employee>();
            string employeeJsonString = System.IO.File.ReadAllText(employeeJsonPath);
            employeeList = JsonConvert.DeserializeObject<List<Employee>>(employeeJsonString);
            return employeeList;
        }

     



    }


    
}

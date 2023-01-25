// See https://aka.ms/new-console-template for more information
using SchoolManagement;

class Program
{
   static void Main(string[] args)
    {
        Register register = new Register();

        //register.RegisterUser();
        //register.studentLogin();
        //register.updateStudent();

        Console.WriteLine("Choose Your Options : 1 - Register User, 2 - LogIn User, 3 - Update User, 4 - Delete User, 5 - Get User  \n");
        var option = Console.ReadLine();
        switch (option)
        {
            case "1":
                register.RegisterUser();
                break;
            case "2":
                register.LoginUser();
                break;
            case "3":
                register.UpdateUser();
                break;
            case "4":
                register.DeleteUser();
                break;
            case "5":
                register.GetUserDetails();
                break;
            default:
                Main(null);
                break;
        }
        Console.ReadLine();
    }


}

      


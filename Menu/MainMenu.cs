using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using simpleApp.Managers.Implementation;
using simpleApp.Managers.Interface;

namespace simpleApp.Menu
{
    public class MainMenu
    {
        ILoginManager _loginManager = new LoginManager();
        IUserManager userManager = new UserManager();
        public void Main()
        {
            System.Console.WriteLine("Enter 1 to register, 2 to login, 3 to check log info");
            int opt = int.Parse(Console.ReadLine());

            if (opt == 1)
            {
                Register();
                Main();
            }
            else if (opt == 2)
            {
                Login();
                Main();
            }
            else if (opt == 3)
            {
                CheckLog();
                Main();
            }
            else
            {
                System.Console.WriteLine("Incorrect Inputs!!!");
            }

        }
        public void Register()
        {
            // string firstName, string lastName, string userPassword
            System.Console.WriteLine("ENter first name : ");
            string first = Console.ReadLine();

            System.Console.WriteLine("Enter last name : ");
            string last = Console.ReadLine();

            System.Console.WriteLine("Enter Password : ");
            string pass = Console.ReadLine();

            var reg = userManager.Register(first, last, pass);
            if (reg == null)
            {
                System.Console.WriteLine("User Already Exist!!");
            }
            else
            {
                System.Console.WriteLine($"You have Succesfully register {first} {last}");
            }
        }

        public void Login()
        {
            System.Console.WriteLine("Enter your first Name : ");
            string first = Console.ReadLine();

            System.Console.WriteLine("Enter your password : ");
            string pass = Console.ReadLine();

            var log = _loginManager.GetLogin(first, pass);
            if (log == null)
            {
                System.Console.WriteLine("Incorrect inputs!!");
            }
            else
            {
                System.Console.WriteLine($"Login Succesfull!!! \nWelcome {first}");
            }
        }

        public void CheckLog()
        {
            System.Console.WriteLine("Enter the firstname of the user : ");
            string first = Console.ReadLine();

            var loginfo = _loginManager.Get(first);
            if (loginfo == null)
            {
                System.Console.WriteLine("User Never Logged in!!!");
            }
            else
            {
                System.Console.WriteLine($"Name : {loginfo.UserName} \nPassword : {loginfo.UserPassword} \nTime Logged In : {loginfo.LogIn}");
            }
        }
    }
}


//  System.Console.WriteLine("Enter the the firstname of the user u want to check thier login info : ");
//             string loginfo = Console.ReadLine();

//             var login = _loginManager.Get(loginfo);
//             if(loginfo == null)
//             {
//                 System.Console.WriteLine("User has never logged in!!");
//             }
//             else 
//             {
//                 login.
//             }
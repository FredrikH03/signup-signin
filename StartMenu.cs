using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signup_signin;

public class StartMenu
{
    public static void SignupSignin()
    {
        string path = @"users.csv";
        bool userFileCheck = File.Exists(path);
        if (!userFileCheck)
        {
            File.Create(path).Close();
        }
        string[] users = File.ReadAllLines(path);

        if (users.Length > 0)
        {
            bool foundUser = false;
            Console.WriteLine("Enter username");
            string usernameInput = Console.ReadLine();
            foreach (string user in users)
            {
                string[] userInfo = user.Split(",");
                if (userInfo[0] == usernameInput)
                {
                    bool login = true;
                    foundUser = true;
                    while(login)
                    {
                        Console.WriteLine("user found");
                        string passwordInput = Console.ReadLine();

                    }
                }
            }
            if (!foundUser)
            {
                Console.WriteLine("user not found, do you want to create a new user?");
                Console.ReadKey();
                Console.WriteLine("please enter password");
                string passwordInput = Console.ReadLine();
                File.AppendAllText(path, $"\n{usernameInput},{passwordInput},Customer");
            }
        }
        if (users.Length == 0)
        {
            Console.WriteLine("user not found, creating new default: login, password");
            File.WriteAllText(path, "login,password,Admin");
            Console.ReadKey();
        }
    }
}

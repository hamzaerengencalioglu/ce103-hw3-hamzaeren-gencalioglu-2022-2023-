using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace libraryapplication
{
    class LoginMenu
    {
        public void Loginscreen()

        {
            Console.Clear();
            string welcome = @"
                                 __          ________ _      _____ ____  __  __ ______ 
                                 \ \        / /  ____| |    / ____/ __ \|  \/  |  ____|
                                  \ \  /\  / /| |__  | |   | |   | |  | | \  / | |__   
                                   \ \/  \/ / |  __| | |   | |   | |  | | |\/| |  __|  
                                    \  /\  /  | |____| |___| |___| |__| | |  | | |____ 
                                     \/  \/   |______|______\_____\____/|_|  |_|______|
                                                       
                                                       
";

            Console.WriteLine(welcome);
            Console.WriteLine("Please Enter Your Username :");
            string username = Console.ReadLine();
            Console.WriteLine("Please Enter Your Password :");
            string password = Console.ReadLine();
            while (true)
            {
                if (username == "Eren" && password == "Eren61")
                {
                    Console.Clear();
                    Console.WriteLine("                                            You Have Successfully Logged In");
                    Thread.Sleep(900);

                    MainMenu menu = new MainMenu();
                    menu.Menu();

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("                                 Your Username Or Password Is Incorrect. Please Try Again");
                    Thread.Sleep(2000);
                    LoginMenu login =  new LoginMenu();
                    login.Loginscreen();
                }
                break;
            }
        }
    }
}

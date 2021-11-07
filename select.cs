using System;
using Func;
namespace SelectMenu
{

    public class main_menu
    {

        public static void selection()
        {
            Console.Clear();

            Console.WriteLine("--- Main Menu ---");
            Console.WriteLine("1. Log in ");
            Console.WriteLine("2. Sign up");
            Console.WriteLine("0. Exit");
            Console.Write("Select ....");

        }

        public static void login(){

            Console.Clear();

            Console.WriteLine("--- Log In ---");
            Console.WriteLine("User : ");





        }

        public static void signup(){

            user_func.AddNewUser(user_func.CreateUser(), user_func.CreatePassWord());
            
        }
    }   // end class main_menu

}
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

        public static void login()
        {

            Console.Clear();

            Console.WriteLine("--- Log In ---");
            Console.WriteLine("User : ");





        }

        public static void signup()
        {

            user_func.AddNewUser(user_func.CreateUser(), user_func.CreatePassWord());

        }
    }   // end class main_menu

    public class menu 
    {   
        public static void selection()
        {
                Console.WriteLine("*----Menu----*");
                Console.WriteLine("1.Shop");
                Console.WriteLine("2.Libray");
                Console.WriteLine("3.Return");
                Console.Write("Select ....");
        }

        public static void shop()
        {
                    Console.WriteLine("*----Shop----*");
                    Console.WriteLine("1. gta x");
                    Console.WriteLine("2.cyberpunk 1999");
                    Console.WriteLine("3.old world");
                    Console.WriteLine("4.mario cart");
                    Console.WriteLine("5.return");
        }

        public static void libary()
        {
                    Console.WriteLine("*----Libary----*");

        }

    }


}
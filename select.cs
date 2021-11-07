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
            string user_name, user_password;
            string[] check_password;
            Console.Clear();

            Console.WriteLine("--- Log In ---");
            Console.Write("User : ");
            
            user_name = Console.ReadLine();

            if(file_func.ScanData(user_name, 1, file_func.PullData("user"))){
                Console.Write("Password : ");
                user_password = Console.ReadLine();

                check_password = file_func.SelectData(user_name, 1, file_func.PullData("user"));

                if(user_password == check_password[1]){
                    Console.WriteLine("Suc");
                }

                else{
                    Console.WriteLine("Fail");
                }

            }
            else{
                Console.WriteLine("Fail");
            }

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
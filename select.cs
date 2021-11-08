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

        public static string login()
        {
            string user_name, user_password;
            string[] check_password;
            Console.Clear();

            Console.WriteLine("--- Log In ---");
            Console.Write("User : ");

            user_name = Console.ReadLine();

            if (file_func.ScanData(user_name, 1, file_func.PullData("user")))
            {
                Console.Write("Password : ");
                user_password = Console.ReadLine();

                check_password = file_func.SelectData(user_name, 1, file_func.PullData("user"));

                if (user_password == check_password[1])
                {
                    Console.WriteLine("Suc");
                    return user_name;
                }

                else
                {
                    Console.WriteLine("Fail");
                    return "Fail";
                }

            }
            else
            {
                Console.WriteLine("Fail");
                return "Fail";
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
            Console.Clear();

            Console.WriteLine("*----Menu----*");
            Console.WriteLine("1.Shop");
            Console.WriteLine("2.Libray");
            Console.WriteLine("0.Return");
            Console.Write("Select ....");
        }

        public static void shop()
        {
            Console.Clear();

            Console.WriteLine("*----Shop----*");
            Console.WriteLine("1. gta x");
            Console.WriteLine("2.cyberpunk 1999");
            Console.WriteLine("3.old world");
            Console.WriteLine("4.mario cart");
            Console.WriteLine("0.return");
        }

        public static void libary(string user_name)
        {
            Console.WriteLine("*----Libary----*");

            string[] show_game = file_func.SelectData(user_name, 1, file_func.PullData("libary"));

            for (int i = 1; i < show_game.Length; i++)
            {
                Console.WriteLine(i + ". " + show_game[i]);
                
            }


            // foreach (string game_name in show_game){
            //     Console.WriteLine(i + ". " + game_name);
            //     i++;
            // }

        }

    }


}
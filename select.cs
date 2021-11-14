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
            int again = 1;         // 

            Console.Clear();
            Console.WriteLine("--- Log In ---");

            do
            {
                if (again == 2)
                {
                    Console.Clear();
                    Console.WriteLine("--- Log In ---");
                    Console.WriteLine("Username or Password is wrong");
                }

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
                        again = 2;
                    }

                }
                else
                {
                    again = 2;
                }

            } while (true);


        }

        public static void signup()
        {
            string user_name, user_password, user_password_confilm;
            int again = 1;

            // user_name condition if(new_user_name) {do something}

            Console.Clear();
            Console.WriteLine("--- Sign Up ---");

            do
            {
                if (again == 2)
                {
                    Console.Clear();
                    Console.WriteLine("--- Sign Up ---");
                    Console.WriteLine("Duplicate");

                    // Console.WriteLine("Me kon chai leaw");

                }

                Console.Write("User : ");
                user_name = Console.ReadLine();

                again = 2;

            } while (user_func.CheckUserName(user_name) == true);   // have no user
                             


            again = 1;
            do
            {
                if (again == 2)
                {
                    Console.Clear();
                    Console.WriteLine("--- Sign Up ---");
                    Console.WriteLine("User : " + user_name);
                    Console.WriteLine("Not math");
                }

                Console.Write("Password : ");
                user_password = Console.ReadLine();

                Console.Write("Confilm Password : ");
                user_password_confilm = Console.ReadLine();

                again = 2;

            } while (user_password != user_password_confilm);



            Console.Clear();
            user_func.AddNewUser(user_name, user_password);

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
            Console.Clear();
            Console.WriteLine("*----Libary----*");

            string[] show_game = file_func.SelectData(user_name, 1, file_func.PullData("libary"));

            for (int i = 2; i <= show_game.Length - 1; i++)
            {

                if (show_game[2] == "")
                {
                    Console.WriteLine("Have no game");
                    Console.Write("Enter for return ");
                }

                else if (i == show_game.Length - 1)
                {
                    Console.WriteLine("0. Return");
                    Console.Write("Select... ");

                }

                else
                {
                    Console.WriteLine(i - 1 + ". " + show_game[i]);
                }

            }


            // foreach (string game_name in show_game){
            //     Console.WriteLine(i + ". " + game_name);     // not work (；￣Д￣）
            //     i++;
            // }

        }

    }


}
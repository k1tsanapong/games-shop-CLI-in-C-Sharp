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
            int check_loop = 1;

            Console.Clear();
            Console.WriteLine("--- Log In ---");

            do
            {
                if (check_loop == 2)
                {
                    Console.Clear();
                    Console.WriteLine("--- Log In ---");
                    Console.WriteLine("Username or Password is wong");
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
                        check_loop = 2;
                    }

                }
                else
                {
                    check_loop = 2;
                }

            } while (true);


        }

        public static void signup()
        {
            string user_name, user_password, user_password_confilm;
            int check_loop = 1;

            // user_name condition if(new_user_name) {do something}

            Console.Clear();
            Console.WriteLine("--- Sign Up ---");

            do
            {
                if (check_loop == 2)
                {
                    Console.Clear();
                    Console.WriteLine("--- Sign Up ---");
                    Console.WriteLine("Duplicate");

                    // Console.WriteLine("Me kon chai leaw");

                }

                Console.Write("User : ");
                user_name = Console.ReadLine();

                check_loop = 2;

            } while (user_func.CheckUserName(user_name));



            check_loop = 1;
            do
            {
                if (check_loop == 2)
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

                check_loop = 2;

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

            public static void shop(long balance)
        {

            string[] game_name = { "GTA X", "Cyberpunk 1999", "Old World", "Mariol Cart" };
            int[] game_price = { 999, 1299, 899, 299 };

            Console.Clear();

            Console.WriteLine("*----Shop----*    Your Balance:" + balance);
            Console.WriteLine($"1.{game_name[0]} \t\t {game_price[0]}  baht");
            Console.WriteLine($"2.{game_name[1]} \t {game_price[1]}  baht");
            Console.WriteLine($"3.{game_name[2]} \t\t {game_price[2]}  baht");
            Console.WriteLine($"4.{game_name[3]} \t\t {game_price[3]}  baht");
            Console.WriteLine($"5.my wallet");
            Console.WriteLine("0.Return");

        }

        public static void PrepareMerge(long balance)
        {
            bool success;   // use for no error input
            int select, userInput = 1;

            shop(balance);

            success = Int32.TryParse(Console.ReadLine(), out select);   // input select

            userInput = 1;  // for check the loop
            while (userInput != 0)
            {

                if (select >= 1 && select <= 4)
                {
                    userInput--;        // userInput = 0; break the loop
                    balance = BuyGame(balance, select);
                }

                else if (select == 5)
                {
                    balance = YourWallet(balance);
                    select = 0;
                }

                else
                {
                    shop(balance);
                    success = Int32.TryParse(Console.ReadLine(), out select);   // input select
                }


            }

            Console.WriteLine($"Your current balance is : {balance}");
        }


        public static long BuyGame(long balance, int choose)
        {
            bool success;
            int ans;
            int select;
            choose--;

            var games = new string[4, 2]
            {
            { "GTA X", "999"},
            {"Cyberpunk 1999", "1299"},
            {"Old World", "899"},
            {"Mariol Cart", "299"}
            };

            int name = 0;
            int price = 1;

            Console.Clear();



            Console.WriteLine($"{games[choose, name]}");
            Console.WriteLine($"Would you like to buy {games[choose, name]} for {games[choose, price]} baht? \n1.Yes   2.No");


            success = Int32.TryParse(Console.ReadLine(), out ans);   // input ans


            int game_price = Convert.ToInt32(games[choose, price]);

            Console.Clear();

            if (ans == 1 && balance > game_price)
            {
                Console.Clear();
                Console.WriteLine($"You have purchased {games[choose, name]}.\t Your remaining balance : {balance - game_price}");//เงินที่จะเหลือหลังซื้อเกม

                Console.WriteLine("Comfirm purchase?");
                Console.WriteLine("1.yes");
                Console.WriteLine("2.no");

                success = Int32.TryParse(Console.ReadLine(), out select);

                switch (select)
                {
                    case 1:
                        Console.WriteLine("yes");
                        balance = balance - game_price;
                        break;

                    case 2:
                        Console.WriteLine("purchase failed !!!");
                        break;

                    default:
                        Console.WriteLine("Select only 1,2");
                        break;

                }


                return balance;













            }

            else if (ans == 1 && balance < game_price)
            {
                Console.Clear();
                Console.WriteLine("You don't have enough money.");
            }

            else if (ans == 2)
            {
                Console.Clear();
                Console.WriteLine("Purchase Failed.");
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Please select 1 or 2 only.");
            }

            return balance;

        }

        public static long YourWallet(long balance)
        {
            bool success;
            int select;

            Console.Clear();
            Console.WriteLine("----Your Wallet----");
            Console.WriteLine($"Current Wallet balance = {balance} Baht");//return wallet
            Console.WriteLine("1.Topup");
            Console.WriteLine("0.return");
            success = Int32.TryParse(Console.ReadLine(), out select);   // input select

            int topup_loop = 1;
            while (topup_loop != 0)
            {
                switch (select)
                {
                    case 1:

                        topup_loop--;

                        long topup;
                        Console.WriteLine("Input your balance:");
                        success = Int64.TryParse(Console.ReadLine(), out topup);   // input select

                        balance = balance + topup;

                        Console.WriteLine($"Steam wallet code : {balance}");//return wallet

                        return balance;


                    case 0:
                        topup_loop--;
                        return balance;
                    // ฝาก 0.returnด้วย
                    default:
                        Console.WriteLine("Please select only 0 or 1");
                        break;
                }

            }
            return balance;
        }

        public static void libary(string user_name)
        {
            Console.Clear();
            Console.WriteLine("*----Libary----*");

            string[] show_game = file_func.SelectData(user_name, 1, file_func.PullData("libary"));

            for (int i = 2; i <= show_game.Length; i++)
            {

                if (i == show_game.Length)
                {
                    Console.WriteLine("0. Return");
                    Console.Write("Select... ");

                }

                else if (show_game[i] == "")
                {
                    Console.WriteLine("Have no game");
                    Console.WriteLine("Enter for exit");
                }

                else
                {
                    Console.WriteLine(i - 1 + ". " + show_game[i]);
                }

            }



        }

    }


}
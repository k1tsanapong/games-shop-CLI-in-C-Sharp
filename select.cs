using System;
using Func;
namespace SelectMenu
{


    //  .----------------.  .----------------.  .----------------.  .-----------------.          .----------------.  .----------------.  .-----------------. .----------------. 
    // | .--------------. || .--------------. || .--------------. || .--------------. |         | .--------------. || .--------------. || .--------------. || .--------------. |
    // | | ____    ____ | || |      __      | || |     _____    | || | ____  _____  | |         | | ____    ____ | || |  _________   | || | ____  _____  | || | _____  _____ | |
    // | ||_   \  /   _|| || |     /  \     | || |    |_   _|   | || ||_   \|_   _| | |         | ||_   \  /   _|| || | |_   ___  |  | || ||_   \|_   _| | || ||_   _||_   _|| |
    // | |  |   \/   |  | || |    / /\ \    | || |      | |     | || |  |   \ | |   | |         | |  |   \/   |  | || |   | |_  \_|  | || |  |   \ | |   | || |  | |    | |  | |
    // | |  | |\  /| |  | || |   / ____ \   | || |      | |     | || |  | |\ \| |   | |         | |  | |\  /| |  | || |   |  _|  _   | || |  | |\ \| |   | || |  | '    ' |  | |
    // | | _| |_\/_| |_ | || | _/ /    \ \_ | || |     _| |_    | || | _| |_\   |_  | |         | | _| |_\/_| |_ | || |  _| |___/ |  | || | _| |_\   |_  | || |   \ `--' /   | |
    // | ||_____||_____|| || ||____|  |____|| || |    |_____|   | || ||_____|\____| | |         | ||_____||_____|| || | |_________|  | || ||_____|\____| | || |    `.__.'    | |
    // | |              | || |              | || |              | || |              | |         | |              | || |              | || |              | || |              | |
    // | '--------------' || '--------------' || '--------------' || '--------------' |         | '--------------' || '--------------' || '--------------' || '--------------' |
    //  '----------------'  '----------------'  '----------------'  '----------------'           '----------------'  '----------------'  '----------------'  '----------------' 


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

        //     __                  ____     
        //    / /   ____   ____ _ /  _/____ 
        //   / /   / __ \ / __ `/ / / / __ \
        //  / /___/ /_/ // /_/ /_/ / / / / /
        // /_____/\____/ \__, //___//_/ /_/ 
        //              /____/              
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


        //    _____  _                __  __     
        //   / ___/ (_)____ _ ____   / / / /____ 
        //   \__ \ / // __ `// __ \ / / / // __ \
        //  ___/ // // /_/ // / / // /_/ // /_/ /
        // /____//_/ \__, //_/ /_/ \____// .___/ 
        //          /____/              /_/      
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



    //  .----------------.  .----------------.  .-----------------. .----------------. 
    // | .--------------. || .--------------. || .--------------. || .--------------. |
    // | | ____    ____ | || |  _________   | || | ____  _____  | || | _____  _____ | |
    // | ||_   \  /   _|| || | |_   ___  |  | || ||_   \|_   _| | || ||_   _||_   _|| |
    // | |  |   \/   |  | || |   | |_  \_|  | || |  |   \ | |   | || |  | |    | |  | |
    // | |  | |\  /| |  | || |   |  _|  _   | || |  | |\ \| |   | || |  | '    ' |  | |
    // | | _| |_\/_| |_ | || |  _| |___/ |  | || | _| |_\   |_  | || |   \ `--' /   | |
    // | ||_____||_____|| || | |_________|  | || ||_____|\____| | || |    `.__.'    | |
    // | |              | || |              | || |              | || |              | |
    // | '--------------' || '--------------' || '--------------' || '--------------' |
    //  '----------------'  '----------------'  '----------------'  '----------------'                            

    public class menu
    {
        public static void selection()
        {
            Console.Clear();

            Console.WriteLine("*----Menu----*");
            Console.WriteLine("1.Shop");
            Console.WriteLine("2.Libray");
            Console.WriteLine("0.Sign Out");
            // Console.WriteLine("0. Exit");
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

        //    _____      __          __       ______                   
        //   / ___/___  / /__  _____/ /_     / ____/___ _____ ___  ___ 
        //   \__ \/ _ \/ / _ \/ ___/ __/    / / __/ __ `/ __ `__ \/ _ \
        //  ___/ /  __/ /  __/ /__/ /_     / /_/ / /_/ / / / / / /  __/
        // /____/\___/_/\___/\___/\__/     \____/\__,_/_/ /_/ /_/\___/ 

        public static void SelectGame(long balance)
        {
            bool success;   // use for no error input
            int select;

            do
            {
                shop(balance);
                // Console.WriteLine(select);
                success = Int32.TryParse(Console.ReadLine(), out select);   // input select

                if (select >= 1 && select <= 4)
                {
                    balance = BuyGame(balance, select);

                }

                else if (select == 5)
                {
                    balance = YourWallet(balance);

                }

                else if (select == 0)
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Wong");

                }

            } while (true);



            Console.WriteLine($"Your current balance is : {balance}");
        }

        //     ____                 ______                      
        //    / __ ) __  __ __  __ / ____/____ _ ____ ___   ___ 
        //   / __  |/ / / // / / // / __ / __ `// __ `__ \ / _ \
        //  / /_/ // /_/ // /_/ // /_/ // /_/ // / / / / //  __/
        // /_____/ \__,_/ \__, / \____/ \__,_//_/ /_/ /_/ \___/ 
        //               /____/                                 
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


            // Console.Clear();

            do
            {
                Console.Clear();



                Console.WriteLine($"{games[choose, name]}");
                Console.WriteLine($"Would you like to buy {games[choose, name]} for {games[choose, price]} baht? \n1.Yes   2.No");


                success = Int32.TryParse(Console.ReadLine(), out ans);   // input ans


                int game_price = Convert.ToInt32(games[choose, price]);

                if (ans == 1 && balance > game_price)
                {
                    


                    
                    do
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
                                
                                Console.Clear();
                                Console.WriteLine("yes");
                                balance = balance - game_price;
                                return balance;


                            case 2:
                                
                                Console.Clear();
                                Console.WriteLine("purchase failed !!!");
                                return balance;


                            default:
                                Console.Clear();
                                Console.WriteLine("Select only 1,2");
                                break;

                        }



                    } while (true);




                }

                else if (ans == 1 && balance < game_price)//Taeza007
                {
                    Console.Clear();
                    Console.WriteLine("You don't have enough money.");
                    Console.ReadKey();
                    return balance;
                }

                else if (ans == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Purchase Failed.");
                    Console.ReadKey();
                    return balance;
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Please select 1 or 2 only.");
                    Console.ReadKey();
                }



            } while (true);

        }

        // __  __                    _       __        __ __       __ 
        // \ \/ /____   __  __ _____| |     / /____ _ / // /___   / /_
        //  \  // __ \ / / / // ___/| | /| / // __ `// // // _ \ / __/
        //  / // /_/ // /_/ // /    | |/ |/ // /_/ // // //  __// /_  
        // /_/ \____/ \__,_//_/     |__/|__/ \__,_//_//_/ \___/ \__/  



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
                        Console.Write("Input your balance: ");
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

        //     __     _  __                       
        //    / /    (_)/ /_   ____ _ _____ __  __
        //   / /    / // __ \ / __ `// ___// / / /
        //  / /___ / // /_/ // /_/ // /   / /_/ / 
        // /_____//_//_.___/ \__,_//_/    \__, /  
        //                               /____/   

        public static void libary(string user_name)
        {
            bool success;
            

            Console.Clear();
            Console.WriteLine("*----Libary----*");

            string[] show_game = file_func.SelectData(user_name, 1, file_func.PullData("libary"));

            for (int i = 2; i <= show_game.Length; i++)
            {

                if (i == show_game.Length)
                {
                    Console.WriteLine("0. Return");
                    Console.Write("Select... ");
                    
                    int game;

                    success = Int32.TryParse(Console.ReadLine(), out game);   // input select
                    game = game+1;

                    switch(game)
                    {
                        case <1:
                            goto default;

                        case 1:
                                // return
                            break;

                        case <6:
                                
                                
                                Console.Clear();
                                Console.WriteLine($"{show_game[game]} start======>");

                                Console.WriteLine("   _____ _             _      _____                      ");
                                Console.WriteLine("  / ____| |           | |    / ____|                     ");
                                Console.WriteLine(" | (___ | |_ __ _ _ __| |_  | |  __  __ _ _ __ ___   ___ ");
                                Console.WriteLine("  \\___ \\| __/ _` | '__| __| | | |_ |/ _` | '_ ` _ \\ / _ \\");
                                Console.WriteLine("  ____) | || (_| | |  | |_  | |__| | (_| | | | | | |  __/");
                                Console.WriteLine(" |_____/ \\__\\__,_|_|   \\__|  \\_____|\\__,_|_| |_| |_|\\___|");
                                Console.WriteLine("                                                         ");
                                
                                //kimzafslk;djgo;eghlwjerfl;jksfd

                                Console.ReadKey();
                                Environment.Exit(0);

                            break;

                        default:
                                Console.WriteLine("long");
                                Console.ReadKey();
                            break;

                    }

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
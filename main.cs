using System;
using System.IO;
using Func;
using SelectMenu;
using System.Collections.Generic;

// start

class Program
{
    static void Main(string[] args)
    {
        bool success;   // use for no error input
        int select, userInput = 1;

        string user_name = "";
        user_name = main_menu.login();
        string[] show_game = file_func.SelectData(user_name, 1, file_func.PullData("libary"));
        long balance = Convert.ToInt64(show_game[1]);


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
        
    } // main




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
            Console.WriteLine($"You have purchased {games[choose, name]}.\t Your remaining balance : {balance-game_price}");//เงินที่จะเหลือหลังซื้อเกม
            
            Console.WriteLine("Comfirm purchase?");
            Console.WriteLine("1.yes");
            Console.WriteLine("2.no");

            success = Int32.TryParse(Console.ReadLine(), out select); 

            switch(select)
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

}




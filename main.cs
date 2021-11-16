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
        // int select;
        // int userInput = 1;
        long balance = 500;
        
        int ans;

        var games = new string[4,2]
        {
            { "GTA X", "999"},
            {"Cyberpunk 1999", "1299"},
            {"Old World", "899"},
            {"Mariol Cart", "299"}
        };
        
        int Chose;
        int i = 0;
        // shop(balance);


        // Console.WriteLine($"{some var}"); is easy to use var 

        Console.WriteLine("Chose a game");
        success = Int32.TryParse(Console.ReadLine(), out Chose);   // input ans

        i = Chose-1;

        // userInput--;        // userInput = 0; break the loop

        

        Console.WriteLine($"{games[i,0]}");
        Console.WriteLine($"Would you like to buy {games[i,0]} for {games[i,1]} baht? \n1.Yes   2.No");
        
        
        success = Int32.TryParse(Console.ReadLine(), out ans);   // input ans

        int game_price = Convert.ToInt32(games[i,1]);

        if (ans == 1 && balance > game_price)
        {
            Console.WriteLine($"You have purchased {games[i,0]}. Your remaining balance is: " + (games[i,1]) + "baht.");
        }
        else if (ans == 1 && balance < game_price)
        {
            Console.WriteLine("You don't have enough money.");
        }
        else if (ans == 2)
        {
            Console.WriteLine("Purchase Failed.");
        }
        else
        {
            Console.WriteLine("Please select 1 or 2 only.");
        }




        // success = Int32.TryParse(Console.ReadLine(), out select);   // input select

        // userInput = 1;  // for check the loop
        // while (userInput != 0)
        // {
        //     switch (select)
        //     {

        //         // ---Your Wallet--- //

        //         case 5:

        //             Console.Clear();
        //             Console.WriteLine("----Your Wallet----");
        //             Console.WriteLine($"Current Wallet balance = {balance} Baht");//return wallet
        //             Console.WriteLine("1.Topup");
        //             Console.WriteLine("0.return");
        //             success = Int32.TryParse(Console.ReadLine(), out select);   // input select

        //             int topup_loop = 1;
        //             while (topup_loop != 0)
        //             {
        //                 switch (select)
        //                 {
        //                     case 1:

        //                         topup_loop--;

        //                         long topup;
        //                         Console.WriteLine("Input your balance:");
        //                         success = Int64.TryParse(Console.ReadLine(), out topup);   // input select

        //                         balance = balance + topup;

        //                         Console.WriteLine($"Steam wallet code : {balance}");//return wallet
        //                         select = 6;
        //                         break;
        //                     case 0:
        //                         break;
        //                     // ฝาก 0.returnด้วย
        //                     default:
        //                         Console.WriteLine("Please select only 0 or 1");
        //                         break;
        //                 }

        //             }       // while end





        //             break;   // case 5 end


        //         case 6:    // loop again

        //             shop(balance);




        //             success = Int32.TryParse(Console.ReadLine(), out select);   // input select
        //             break; // case 6 end

        //         default:    // loop again

        //             shop(balance);




        //             success = Int32.TryParse(Console.ReadLine(), out select);   // input select
        //             break;
        //     }
        // }







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
    public static void select(int select)
    {
        string[] game_name = { "GTA X", "Cyberpunk 1999", "Old World", "Mariol Cart" };
        int[] game_price = { 999, 1299, 899, 299 };

        Console.Clear();


    }


    public static Tuple<int, int> payment(int balance)
    {








        // In C# 7 and above, see this answer.

        // In previous versions, you can use .NET 4.0+'s Tuple:

        // For Example:

        // public Tuple<int, int> GetMultipleValue()
        // {
        //     return Tuple.Create(1,2);
        // }
        // Tuples with two values have Item1 and Item2 as properties


        return Tuple.Create(balance, 2);
    }

    public static void paygame(string user_name, string[] user_data)
    {


    }
}




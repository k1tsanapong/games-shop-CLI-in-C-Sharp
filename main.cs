using System;
using System.IO;
using Func;
using SelectMenu;
// start

class Program
{
    static void Main(string[] args)
    {
        bool success;   // use for no error input
        int select, userInput = 1;
        
        
        long balance = 500;

        string[] game_name = {"GTA X","Cyberpunk 1999","Old World","Mariol Cart"};
        int[] game_price = {999, 1299, 899, 299};

        Console.WriteLine("Input your balance:");
        success = Int64.TryParse(Console.ReadLine(), out balance);   // input select
        
    
        Console.WriteLine("*----Shop----*    Your Balance:"+balance);
                
        Console.WriteLine($"1.{game_name[0]} \t\t {game_price[0]}  baht");

        Console.WriteLine($"2.{game_name[1]} \t {game_price[1]}  baht");
        Console.WriteLine($"3.{game_name[2]} \t\t {game_price[2]}  baht");
        Console.WriteLine($"4.{game_name[3]} \t\t {game_price[3]}  baht");
        Console.WriteLine("0.Return");


        // Console.WriteLine($"{some var}"); is easy to use var 

        



        success = Int32.TryParse(Console.ReadLine(), out select);   // input select
   
        userInput = 1;  // for check the loop
        while (userInput != 0)
        {
            switch (select)
            {

                case 1:
                    userInput--;        // userInput = 0; break the loop
                    Console.WriteLine($"{game_name[0]}");
                    Console.WriteLine($"Would you like to buy {game_name[0]} for {game_price[0]}baht? \n1.Yes   2.No");
                    int ans = Convert.ToInt32(Console.ReadLine());
                    


                    if (ans== 1 && balance>999){
                        Console.WriteLine($"You have purchased {game_name[0]}. Your remaining balance is: "+(balance-999)+"baht.");
                    }
                    else if(ans==1 && balance<999){
                        Console.WriteLine("You don't have enough money.");
                    }
                    else if(ans==2){
                        Console.WriteLine("Purchase Failed.");
                    }
                    else{
                        Console.WriteLine("Please select 1 or 2 only.");
                    }
                    break;

                case 2:
                    userInput--;        // userInput = 0; break the loop
                    Console.WriteLine($"{game_name[1]}");
                    Console.WriteLine($"Would you like to buy {game_name[1]} for {game_price[1]}baht? \n1.Yes   2.No");
                    int ans1 = Convert.ToInt32(Console.ReadLine());

                    if (ans1== 1 && balance>1299){
                        Console.WriteLine($"You have purchased {game_name[1]}. Your remaining balance is: "+(balance-1299)+"baht.");
                    }
                    else if(ans1==1 && balance<1299){
                        Console.WriteLine("You don't have enough money.");
                    }
                    else if(ans1==2){
                        Console.WriteLine("Purchase Failed.");
                    }
                    else{
                        Console.WriteLine("Please select 1 or 2 only.");
                    }

                    break;
                
                 case 3:
                    userInput--;        // userInput = 0; break the loop
                    Console.WriteLine($"{game_name[2]}");
                    Console.WriteLine($"Would you like to buy {game_name[2]} for {game_price[2]}baht? \n1.Yes   2.No");
                    int ans2 = Convert.ToInt32(Console.ReadLine());

                    if (ans2== 1 && balance>899){
                        Console.WriteLine($"You have purchased {game_name[2]}. Your remaining balance is: "+(balance-899)+"baht.");
                    }
                    else if(ans2==1 && balance<899){
                        Console.WriteLine("You don't have enough money.");
                    }
                    else if(ans2==2){
                        Console.WriteLine("Purchase Failed.");
                    }
                    else{
                        Console.WriteLine("Please select 1 or 2 only.");
                    }
                    break;
                
                 case 4:
                    userInput--;        // userInput = 0; break the loop
                    Console.WriteLine($"{game_name[3]}");
                    Console.WriteLine($"Would you like to buy {game_name[3]} for {game_price[3]}baht? \n1.Yes   2.No");
                    int ans3 = Convert.ToInt32(Console.ReadLine());

                    if (ans3== 1 && balance>299){
                        Console.WriteLine($"You have purchased {game_name[3]}. Your remaining balance is: "+(balance-299)+"baht");
                    }
                    else if(ans3==1 && balance<299){
                        Console.WriteLine("You don't have enough money.");
                    }
                    else if(ans3==2){
                        Console.WriteLine("Purchase Failed.");
                    }
                    else{
                        Console.WriteLine("Please select 1 or 2 only.");
                    }
                    break;

                 case 5:
                    userInput--;        // userInput = 0; break the loop
                    
                    break;

                default:    // loop again
                    Console.WriteLine("Do again");
                    success = Int32.TryParse(Console.ReadLine(), out select);   // input select
                    break;
            }
        }
        



       


    } // main


}




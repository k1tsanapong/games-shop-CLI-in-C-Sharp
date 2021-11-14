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
        int select, userInput = 1, balance = 500;
        string user_name = "";

        string[] game_name = { };
        string[] game_pirce = { };

        Console.WriteLine("Game library");

        // for loop start

        Console.WriteLine("1.GTA X({0} Baht.");
        Console.WriteLine("2.cyberpunk 1999({0} Baht.");
        Console.WriteLine("3.old world({0} Baht.");
        Console.WriteLine("4.mario cart({0} Baht.");

        // for loop end


        // for loop end

        // show ตังค์  สักเลข สมุมติ 5.      Console.WriteLine(balance);
        // 1.เติมตังค์
        // 0. return
        // show return 0.


        Console.WriteLine("select = ");
        success = Int32.TryParse(Console.ReadLine(), out select);   // input select


        // ---------shop----------------//

        userInput = 1;
        while (userInput != 0)
        {
            switch (select)
            {
                case 1:
                    userInput--;    // userInput = 0  exit loop
                    // 
                    break;







                // ---Your Wallet--- //

                case 5:
                    userInput--;
                    Console.WriteLine("----Your Wallet----");
                    Console.WriteLine($"Current Wallet balance = {0} Baht");//return wallet
                    Console.WriteLine("1.Topup");
                    Console.WriteLine("0.return");
                    success = Int32.TryParse(Console.ReadLine(), out select);   // input select
                    userInput = 1;
                    while (userInput != 0)
                    {
                         switch(select)
                    {
                            case 1:
                             userInput--;
                             Console.WriteLine($"Steam wallet code : {0}");//return wallet
                            break;
                            case 0:
                               break;
                        // ฝาก 0.returnด้วย
                            default:
                             Console.WriteLine("Please select only 1 or 0");
                               break;
                    }

                    }       // while end

                    



                   break;   // case 5 end

                // ---Your Wallet--- //

                default:
                    break;          // exit loop
            }



        }


        // ---------shop----------------//


        Console.WriteLine("-----GTA X-----------)");
        // show  ราคา
        // show ตังค์
        Console.WriteLine("Comfirm purchase?");
        Console.WriteLine("1.yes");
        // 


        Console.WriteLine("2.no");


        // Comfirm Start

        userInput = 1;
        while (userInput != 0)
        {
            switch (select)
            {
                case 1:
                    userInput--;    // userInput = 0  exit loop

                    // if (balance > game_pirce[i])
                    // {

                    //     balance = balance - game_pirce[i];

                    // // Add game to your libary; KIM ทำ

                    //     else
                    //     {
                    //         Console.WriteLine("Fuck you");
                    //     }
                    // }

                    break;

                default:
                    break;          // exit loop
            }



        }

        // Comfirm End

    } // main


}




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
        string user_name = "";

        main_menu.selection();

        success = Int32.TryParse(Console.ReadLine(), out select);   // input select
        userInput = 1;
        while (userInput != 0)
        {
            switch (select)
            {

                case 1:
                    userInput--;
                    user_name = main_menu.login();
                    break;

                case 2:
                    userInput--;
                    main_menu.signup();
                    goto case 1;

                default:
                    Console.WriteLine("Do again");
                    success = Int32.TryParse(Console.ReadLine(), out select);   // input select
                    break;
            }
        }

        string[] user_data = file_func.SelectData(user_name, 1, file_func.PullData("libary"));
        long balance = Convert.ToInt64(user_data[1]);

        do
        {

            menu.selection();
            success = Int32.TryParse(Console.ReadLine(), out select);   // input select

            switch (select)
            {
                case 1:
                    menu.SelectGame(balance);   // return game yet.
                    break;

                case 2:
                    menu.libary(user_name);
                    break;

                case 0:
                    // return
                    Environment.Exit(0);
                    
                    break;
                default:
                    Console.WriteLine("Please select 1-3");
                    break;
            }

        } while (true);

    } // main


}




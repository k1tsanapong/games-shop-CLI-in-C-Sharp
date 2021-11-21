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
        string[] user_data;
        long balance = 0;


        
        userInput = 1;
        while (userInput != 0)

        {
            main_menu.selection();

        success = Int32.TryParse(Console.ReadLine(), out select); 
            switch (select)
            {

                case 1:
                    userInput--;
                    user_name = main_menu.login();
                    if (user_name == "0")
                    {
                        userInput = 1;
                        break;
                    }
                    user_data = file_func.SelectData(user_name, 1, file_func.PullData("libary"));
                    balance = Convert.ToInt64(user_data[1]);
                    break;

                case 2:
                    userInput--;
                    main_menu.signup();
                    goto case 1;

                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Do again");
                    success = Int32.TryParse(Console.ReadLine(), out select);   // input select
                    break;
            }
        }



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
                                user_data = file_func.SelectData(user_name, 1, file_func.PullData("libary"));
                                balance = Convert.ToInt64(user_data[1]);
                                break;

                            case 2:
                                userInput--;
                                main_menu.signup();
                                goto case 1;

                            case 0:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Do again");
                                success = Int32.TryParse(Console.ReadLine(), out select);   // input select
                                break;
                        }
                    }

                    break;
                default:
                    Console.WriteLine("Please select 1-3");
                    break;
            }

        } while (true);

    } // main


}




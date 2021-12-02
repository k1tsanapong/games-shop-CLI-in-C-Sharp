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
        double balance = 0;



        userInput = 1;
        while (userInput != 0)
        {

            main_menu.selection(userInput);
            success = Int32.TryParse(Console.ReadLine(), out select);

            switch (select)
            {

                case 1:
                    userInput = 0;
                    user_name = main_menu.login();
                    if (user_name == "0")
                    {
                        userInput = 1;
                        break;
                    }
                    user_data = file_func.SelectData(user_name, 1, file_func.PullData("libary"));
                    balance = Convert.ToDouble(user_data[1]);
                    break;
                case 2:
                    userInput = 0;
                    user_name = main_menu.signup();
                    if (user_name == "0")
                    {
                        userInput = 1;
                        break;
                    }
                    user_data = file_func.SelectData(user_name, 1, file_func.PullData("libary"));
                    balance = Convert.ToDouble(user_data[1]);
                    break;

                case 0:

                    if (success == false) { goto default; }

                    Environment.Exit(0);
                    break;

                default:
                    userInput = 2;
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
                    menu.SelectGame(user_name, balance);   // return game yet.
                    break;

                case 2:
                    menu.libary(user_name);
                    break;

                case 0:
                    if (success == false) { goto default; }
                    userInput = 1;
                    while (userInput != 0)
                    {

                        main_menu.selection(userInput);
                        success = Int32.TryParse(Console.ReadLine(), out select);

                        switch (select)
                        {

                            case 1:
                                userInput = 0;
                                user_name = main_menu.login();
                                if (user_name == "0")
                                {
                                    userInput = 1;
                                    break;
                                }
                                user_data = file_func.SelectData(user_name, 1, file_func.PullData("libary"));
                                balance = Convert.ToDouble(user_data[1]);
                                break;
                            case 2:
                                userInput = 0;
                                user_name = main_menu.signup();
                                if (user_name == "0")
                                {
                                    userInput = 1;
                                    break;
                                }
                                user_data = file_func.SelectData(user_name, 1, file_func.PullData("libary"));
                                balance = Convert.ToDouble(user_data[1]);

                                break;

                            case 0:

                                if (success == false) { goto default; }

                                Environment.Exit(0);
                                break;

                            default:
                                userInput = 2;
                                break;


                        }
                    }

                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please select 1-3");
                    Console.ReadKey();
                    break;
            }

            user_data = file_func.SelectData(user_name, 1, file_func.PullData("libary"));
            balance = Convert.ToDouble(user_data[1]);


        } while (true);

    } // main


}




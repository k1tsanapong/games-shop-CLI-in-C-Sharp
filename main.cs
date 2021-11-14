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
                    break;

                default:
                    Console.WriteLine("Do again");
                    success = Int32.TryParse(Console.ReadLine(), out select);   // input select
                    break;
            }
        }


    } // main


}




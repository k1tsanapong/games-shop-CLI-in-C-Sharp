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

        string[] user_data = file_func.SelectData(user_name, 1, file_func.PullData("libary"));
        long balance = Convert.ToInt64(user_data[1]);

        menu.selection();
        success = Int32.TryParse(Console.ReadLine(), out select);   // input select

        switch (select)
        {
            case 1:
                menu.PrepareMerge(balance);
                break;
            case 2:
                menu.libary(user_name);
                break;
            case 3:
                ///return>>. ก่อนหน้า
                break;
            default:
                Console.WriteLine("Please select 1-3");
                break;
        }


        ///รีเทิร์นฝากเหล่าเทพเจ้าช่วยด้วย
        success = Int32.TryParse(Console.ReadLine(), out select);   // input select
        switch (select)
        {
            case 1:
                Console.WriteLine("yes");
                break;
            case 2:
                Console.WriteLine("no");
                break;
            default:
                Console.WriteLine("Select ONLY 1,2");
                break;
        }


    } // main


}




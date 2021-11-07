using System;
using System.IO;
using Func;
using SelectMenu;
// start

class Program
{
    static void Main(string[] args)
    {
        bool success;
        int select;

        main_menu.selection();

        success = Int32.TryParse(Console.ReadLine(), out select);   // input select
        int userInput = 1;
        while (userInput != 0)
        {
            switch (select)
            {

                case 1:
                    userInput--;
                    main_menu.login();
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



        menu.selection();
        success = Int32.TryParse(Console.ReadLine(), out select);   // input select

        switch (select)
        {
            case 1:
                menu.shop();
                break;
            case 2:
                menu.libary();
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




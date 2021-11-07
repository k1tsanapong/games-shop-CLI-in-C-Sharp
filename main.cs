using System;
using System.IO;
using Func;
using SelectMenu;
// start

class Program
{
    static void Main(string[] args)
    {



        main_menu.selection();


        int select = Convert.ToInt32(Console.ReadLine());
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
                    select = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }


        //kim
        //int select = Int32.Parse(Console.ReadLine());
        int select1 = Convert.ToInt32(Console.ReadLine());
        switch (select1)
        {
            case 1:
                Console.WriteLine("*----Menu----*");
                Console.WriteLine("1.Shop");
                Console.WriteLine("2.Libray");
                Console.WriteLine("3.Return");
                Console.Write("Select ....");
                int select2 = Convert.ToInt32(Console.ReadLine());
                if (select2 == 1) //shop
                {
                    Console.WriteLine("*----Shop----*");
                    Console.WriteLine("1. gta x");
                    Console.WriteLine("2.cyberpunk 1999");
                    Console.WriteLine("3.old world");
                    Console.WriteLine("4.mario cart");
                    Console.WriteLine("5.return");
                }
                else if (select2 == 2)
                {
                    Console.WriteLine("*----Libary----*");
                }
                else if (select2 == 3)
                {
                    ///return>>. ก่อนหน้า
                }
                else
                {
                    Console.WriteLine("Please select 1-3");
                }
                break;


            case 2: //libray
                Console.WriteLine("*----Menu----*");
                Console.WriteLine("1.shop");
                Console.WriteLine("2.Libray");
                Console.WriteLine("3.Return");
                Console.Write("Select ....");
                int select3 = Convert.ToInt32(Console.ReadLine());
                if (select3 == 2)
                {
                    Console.WriteLine("*----Libary----*");
                    //รับค่าจาก พี่คิม
                }
                break;

            default:
                Console.WriteLine("Please select 1-2");
                break;
        }

        {
            int Game1 = 23, Game2 = 47, Game3 = 221, Game4 = 60, select3, confirm;
            double money, change;
            Console.WriteLine("Insert your money");
            money = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Game library");
            Console.WriteLine("1.GTA X({0} Baht.)", Game1);
            Console.WriteLine("2.cyberpunk 1999({0} Baht.)", Game2);
            Console.WriteLine("3.old world({0} Baht.)", Game3);
            Console.WriteLine("4.mario cart({0} Baht.)", Game4);
            Console.WriteLine("select 1,2,3,4 =");
            select3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Comfirm purchase?");
            Console.WriteLine("1.yes");
            Console.WriteLine("2.no");
            ///รีเทิร์นฝากเหล่าเทพเจ้าช่วยด้วย
            confirm = Convert.ToInt32(Console.ReadLine());
            switch (confirm)
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
            switch (select3)
            {
                case 1:
                    if (money >= Game1)
                    {
                        Console.WriteLine("You select GTA X. This is {0} bath.", Game1);
                        Console.WriteLine("You pay {0}", money);
                        change = money - Game1;
                        Console.WriteLine("You get change for {0} Baht. ", change);
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough money");
                    }
                    break;
                case 2:
                    if (money >= Game2)
                    {
                        Console.WriteLine("You select cyberpunk 1999. This is {0} bath.", Game2);
                        Console.WriteLine("You pay {0}", money);
                        change = money - Game2;
                        Console.WriteLine("You get change for {0} Baht. ", change);
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough money");
                    }
                    break;
                case 3:
                    if (money >= Game3)
                    {
                        Console.WriteLine("You select old world. This is {0} bath.", Game3);
                        Console.WriteLine("You pay {0}", money);
                        change = money - Game3;
                        Console.WriteLine("You get change for {0} Baht. ", change);
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough money");
                    }
                    break;
                case 4:
                    if (money >= Game4)
                    {
                        Console.WriteLine("You select mario cart. This is {0} bath.", Game4);
                        Console.WriteLine("You pay {0}", money);
                        change = money - Game4;
                        Console.WriteLine("You get change for {0} Baht. ", change);
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough money");
                    }
                    break;
                default:
                    Console.WriteLine("Select ONLY 1-4");
                    break;
            }
        }

    } // main


}



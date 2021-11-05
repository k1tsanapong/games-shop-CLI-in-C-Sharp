using System;
using System.IO;

// start

class Program
{
    static void Main(string[] args)
    {

        AddNewUser(CreateUser(), CreatePassWord());

    } // main

    public static void AddNewUser(string name, string password)
    {
        Console.WriteLine(name + "," + password);
    }


    public static bool CheckUserName(string new_user_name)
    {
        const string Path = "data/user.txt";          //for replit
                                                      // const string Path = "../../../data/user.txt"; //for windows

        string[] user_name = File.ReadAllLines(Path);

        using (StreamWriter file = new StreamWriter(Path, true))
        { // start new_user_name

            for (int i = 0; i <= (user_name.Length - 1); i++)
            {
                string[] fields = user_name[i].Split(',');

                if (new_user_name == fields[0])
                {
                    Console.WriteLine("fail");
                    return false;
                }
            }

            Console.WriteLine("Suc");
            return true;

        } // end new_user_name

    }

    public static string CreateUser()
    {
        string new_user_name;
        do
        {
            Console.Write("User : ");
            new_user_name = Console.ReadLine();
        }

        while (!CheckUserName(new_user_name));
        return new_user_name;
    }

    public static string CreatePassWord()
    {

        string password;
        string password_confilm;
        do
        {
            Console.Write("Password : ");
            password = Console.ReadLine();

            Console.Write("Confilm Password : ");
            password_confilm = Console.ReadLine();

        } while (password != password_confilm);


        return password;
    }

}
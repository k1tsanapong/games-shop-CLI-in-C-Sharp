using System;
using System.IO;

namespace Func
{

    public class file_func
    {

        public static string[] PullData(string file_name)
        {

            string path = Path(file_name);

            string[] data_base = File.ReadAllLines(path);
            return data_base;

        }

        public static string[] SelectData(string check, int column, string[] data_base)
        {

            column--;
            string[] not_found = { "NotFound" };

            for (int i = 0; i < data_base.Length; i++)
            {
                string[] fields = data_base[i].Split(',');

                if (check == fields[column])
                {
                    return fields;                           //break
                }
            }

            return not_found;
        }

        public static string Path(string file_name)
        {

            string path = "./data/" + file_name + ".txt";
            return path;
        }

        public static bool ScanData(string check, int column, string[] data_base)
        {

            column--;   //Array start at 0

            for (int i = 0; i < data_base.Length; i++)  //check all rows
            {
                string[] fields = data_base[i].Split(',');

                if (check == fields[column])
                {
                    //Console.WriteLine("fail");
                    return true;                           //break
                }
            }

            //Console.WriteLine("Suc");
            return false;

        }

    }


    public class user_func
    {

        public static void AddNewUser(string name, string password)
        {
            string user_new = name + "," + password;
            Console.WriteLine(name + "," + password);
            
            using (StreamWriter file = new StreamWriter(file_func.Path("user") , true)){
                file.WriteLine(user_new);
            }

        }


        public static bool CheckUserName(string new_user_name)
        {
            string[] user_name = file_func.PullData("user");
            return file_func.ScanData(new_user_name, 1, user_name);

        }

        public static string CreateUser()
        {
            string new_user_name;
            int i = 1;

            // user_name condition if(new_user_name) {do something}


            do
            {
                if (i != 1)
                {
                    Console.WriteLine("fail");
                }

                Console.Write("User : ");
                new_user_name = Console.ReadLine();

                i++;

            } while (CheckUserName(new_user_name));

            Console.WriteLine("Suc");
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



}
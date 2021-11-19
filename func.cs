using System;
using System.IO;
using System.Collections.Generic;

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
            // string path = "../../../data/" + file_name + ".txt"; //for visual studio
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

        public static void WriteOnFile(string file_name, List<string> words)
        {

            // string user_new = name + "," + password;
            // Console.WriteLine(name + "," + password);

            // column--;   //Array start at 0

            // for (int i = 0; i < data_base.Length; i++)  //check all rows
            // {
            //     string[] fields = data_base[i].Split(',');

            //     if (check == fields[column])
            //     {
            //         //Console.WriteLine("fail");
            //         return true;                           //break
            //     }
            // }

            // //Console.WriteLine("Suc");
            // return false;

            // string sentence ;

            // var even = new List<int>();
            // var odd = new List<int>();

            using (StreamWriter file = new StreamWriter(file_func.Path(file_name), true))
            {
                file.WriteLine(words[0]);
            }



        }

        public static void WriteOnFile(string file_name, string words)
        {
            using (StreamWriter file = new StreamWriter(file_func.Path(file_name), true))
            {
                file.WriteLine(words);
            }
        }

    }


    public class user_func
    {

        public static void AddNewUser(string name, string password)
        {
            string start_money = "0";

            file_func.WriteOnFile("user", name + "," + password);
            file_func.WriteOnFile("libary", name + "," + start_money);

            // using (StreamWriter file = new StreamWriter(file_func.Path("user"), true))
            // {
            //     file.WriteLine(user_new);
            // }

        }




        public static bool CheckUserName(string new_user_name)
        {
            string[] user_name = file_func.PullData("user");
            return file_func.ScanData(new_user_name, 1, user_name);

        }







    }



}
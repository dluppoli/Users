using System;
using System.Collections.Generic;
using Users.Models;

namespace Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = Controller.Users.GetAll();
            //PrintTable(users);

            //Stampare tutti i maschi
            List<User> maschi = users.FindAll(u => u.Gender == "male");
            PrintTable(maschi);


            Console.ReadLine();
        }

        static void PrintTable(List<User> users)
        {
            foreach (string s in Controller.Users.FormatAsTable(users))
            {
                Console.WriteLine(s);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Users.Models;

namespace Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = Controller.Users.GetAll();
            PrintTable(users);

            //Stampare tutti i maschi
            List<User> maschi = users.FindAll(u => u.Gender == "male");
            //PrintTable(maschi);

            //Stampare tutti gli utenti della california (state==CA)
            //Stampare tutti gli utenti di origine giapponese (mail che finisce co jp)
            //Stampare tutti gli utenti con password <= di 8 caratteri
            //Contare quanti utenti sono nati nel 1979
            //Stampare tutti gli utenti con età > di 50 anni (calcolata da BirthDate)
            //Stampare tutti gli utenti che lavorano per amazon


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

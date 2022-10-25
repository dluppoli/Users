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
            List<User> californiano = users.FindAll(

                //delegate (User u) { return u.Address.State == "CA"; }
                //(u) => { return u.Address.State == "CA"; }
                u => u.Address.State == "CA"
                );


            //Stampare tutti gli utenti di origine giapponese (mail che finisce con jp)
            List<User> giapponesi = users.FindAll(u => u.Email.EndsWith(".jp"));

            //Stampare tutti gli utenti con password <= di 8 caratteri
            List<User> pwdDeboli = users.FindAll(u => u.Password.Length <= 8);

            //Contare quanti utenti sono nati nel 1979
            List<User> nati79 = users.FindAll(u => u.BirthDate.Year == 1979);

            //Stampare tutti gli utenti con età > di 50 anni (calcolata da BirthDate)
            List<User> cinquantenni = users.FindAll(u => (DateTime.Today - u.BirthDate).TotalDays >= 365 * 50);

            //Stampare tutti gli utenti che lavorano per amazon
            List<User> amazoniani = users.FindAll(u => u.Email.Contains("@amazon"));

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

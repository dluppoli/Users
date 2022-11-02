using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UsersWinForms.Controllers
{
    public static class Auth
    {
        public static bool Login(string username, string password)
        {
            //Password fissa da spostare su database
            SHA512 hashCalculator = SHA512.Create();
            string passwordHash = BitConverter.ToString(hashCalculator.ComputeHash(Encoding.ASCII.GetBytes(password))).Replace("-", "");

            return username.ToLower() == ConfigurationManager.AppSettings["username"] && passwordHash.ToLower() == ConfigurationManager.AppSettings["password"].ToLower();
        }
    }
}

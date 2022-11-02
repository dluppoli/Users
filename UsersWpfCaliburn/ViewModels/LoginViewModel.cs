using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UsersWpfCaliburn.ViewModels
{
    internal class LoginViewModel : Conductor<object>
    {
        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; NotifyOfPropertyChange("Username"); }
        }


        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; NotifyOfPropertyChange("Password"); }
        }

        public void Login()
        {
            var ok = UsersClassLibrary.Controllers.Users.VerificaCredenziali(Username, Password);
            MessageBox.Show(ok.ToString());
            Username = "";
            Password="";
        }
    }
}

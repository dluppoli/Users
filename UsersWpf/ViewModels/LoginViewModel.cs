using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersWpf.ViewModels
{
    internal class LoginViewModel : BaseViewModel
    {
		private string _username;

		public string Username
		{
			get { return _username; }
			set { _username = value; NotifyPropertyChanged("Username"); }
		}

		private string _password;

		public string Password
		{
			get { return _password; }
			set { _password = value; NotifyPropertyChanged("Password"); }
        }

		private bool _mostraPassword = false;

		public bool MostraPassword
		{
			get { return _mostraPassword; }
			set { _mostraPassword = value; NotifyPropertyChanged("MostraPassword"); }
		}

		public bool Login()
		{
			return UsersClassLibrary.Controllers.Users.VerificaCredenziali(Username, Password);
		}
	}
}

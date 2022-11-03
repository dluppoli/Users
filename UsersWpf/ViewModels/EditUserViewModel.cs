using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersClassLibrary.Controllers;
using UsersClassLibrary.Models;

namespace UsersWpf.ViewModels
{
    internal class EditUserViewModel : BaseViewModel
    {
		private User _selectedUser;

		public User SelectedUser
        {
			get { return _selectedUser; }
			set { _selectedUser = value; NotifyPropertyChanged("SelectedUser"); }
		}

		private List<string> _listaSessi;

		public List<string> ListaSessi
		{
			get { return _listaSessi; }
			set { _listaSessi = value; NotifyPropertyChanged("ListaSessi"); }
		}

		public EditUserViewModel()
		{
			SelectedUser = new User();
			ListaSessi = Users.GetGenders();
		}

		public void Save()
		{
			Users.Add(SelectedUser);
		}
	}
}

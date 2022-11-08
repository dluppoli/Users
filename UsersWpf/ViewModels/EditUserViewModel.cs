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
		private bool isNew;

		private int _selectedUserId;
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

		private string _titleLabel;

		public string TitleLabel
		{
			get { return _titleLabel; }
			set { _titleLabel = value; NotifyPropertyChanged("TitleLabel"); }
		}

		public EditUserViewModel()
		{
			isNew = true;
			SelectedUser = new User();
			ListaSessi = Users.GetGenders();
			TitleLabel = "Nuovo Utente";
		}

		public EditUserViewModel(User u)
		{
			isNew = false;
			_selectedUserId = u.Id;
			SelectedUser = new User
			{
				Id = u.Id,
				FirstName = u.FirstName,
				LastName = u.LastName,
				Email = u.Email,
				Username = u.Username,
				Password = u.Password,
				BirthDate = u.BirthDate,
				Age = u.Age,
				Gender = u.Gender,
				Address = u.Address
			};
            ListaSessi = Users.GetGenders();
            TitleLabel = $"Modifica Utente {_selectedUserId}";
        }
		public void Save()
		{
			if (isNew)
				Users.Add(SelectedUser);
			else
				Users.Update(_selectedUserId, SelectedUser);
		}
	}
}

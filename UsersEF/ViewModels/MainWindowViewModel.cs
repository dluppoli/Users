using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersEF.Models;

namespace UsersEF.ViewModels
{
    internal class MainWindowViewModel
    {
		private List<User> _dati;

		public List<User> Dati
		{
			get { return _dati; }
			set { _dati = value; }
		}

		public MainWindowViewModel()
		{
			using (UsersContext context = new UsersContext())
			{
				//INSERT
				/*User newUser = new User
				{
					Id = 100,
					FirstName = "Nuovo",
					LastName = "Nuovo",
					Email = "nuovo@nuovo.com",
					Age = 30,
					BirthDate = DateTime.Today.AddDays(-30*365),
					Gender = "male",
					Username = "nuovo",
					Password = "nuovo123.",
					Address = "Via del corso",
					City = "Reggio Emilia",
					State = "RE",
					PostalCode = "00200"
				};

				context.Users.Add(newUser);*/

				//Dati = context.Users.ToList();

				//UPDATE
				/*User candidate = Dati.Find(u => u.FirstName.Contains("Nuovo"));

				if( candidate!= null)
				{
					candidate.LastName = "Nuovo utente";
				}*/

				//DELETE
				/*User candidate = Dati.Find(u => u.Id == 99);
				context.Users.Remove(candidate);
                Dati.Remove(candidate);

                context.SaveChanges();*/


				//List<Login> logins = context.Logins.ToList();//Select * from Logins
				//List<Login> logins = context.Logins.Include(i=> i.User ).ToList();
				//select * from logins L inner join users U on L.userId = U.Id
				//Login l = logins[0]; //UserId = 2

				//Dati = new List<User>
				//{
				//	l.User //Select * from Users where Id = 2
				//};

				Dati = context.Users.Include(i => i.Logins).ToList();
				User candidate = Dati[0];

				Login newLogin = new Login
				{
					UserId = candidate.Id,
					Date = DateTime.Now,
					LoginSuccessful = true,
					Note = "nuovo login"
				};

				//candidate.Logins.Add(newLogin);
				context.Logins.Add(newLogin);

				context.SaveChanges();
			}
		}
	}
}

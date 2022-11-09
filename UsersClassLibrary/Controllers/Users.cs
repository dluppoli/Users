using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersClassLibrary.Models;

namespace UsersClassLibrary.Controllers
{
    public static class Users
    {
        public static string connectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
            }
        }

        private static List<User> _users;
        public static List<User> GetAll()
        {
            if (_users == null)
            {
                if (!File.Exists(@".\Models\database.json")) return new List<User>();
                string json = File.ReadAllText(@".\Models\database.json");
                _users = JsonConvert.DeserializeObject<List<User>>(json);
            }
            return _users;
        }

        //public static List<User> FindAll(Predicate<User> condizione)
        public static List<User> FindAll(string nome, string sex)
        {
            if (string.IsNullOrWhiteSpace(nome)) nome = "";
            if (string.IsNullOrWhiteSpace(sex)) sex = "";
            //return GetAll().FindAll(condizione);

            //1 - Mi creo la lista vuota da restituire
            List<User> retVal = new List<User>();

            //2 - Mi connetto al db e apro la connessione
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    //3 - Compongo la query sql (con i parametri)
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM Users ";
                    cmd.CommandText += "WHERE (FirstName Like @name OR LastName Like @name) ";
                    cmd.CommandText += "AND Gender LIKE @sex";

                    cmd.Parameters.AddWithValue("@name", $"%{nome}%");
                    cmd.Parameters.AddWithValue("@sex", $"{sex}%");

                    //4 - Ottengo il data reader
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //5 - per ogni riga della query creo un oggetto User e aggiungo alla lista
                        while (reader.Read())
                        {
                            User u = new User
                            {
                                Id = (int)reader["Id"],
                                FirstName = (string)reader["FirstName"],
                                LastName = (string)reader["LastName"],
                                Age = (int)reader["Age"],
                                Gender = (string)reader["Gender"],
                                Email = (string)reader["Email"],
                                Username = (string)reader["Username"],
                                Password = (string)reader["Password"],
                                BirthDate = (DateTime)reader["BirthDate"],
                                Address = new FullAddress 
                                {
                                    Address = (string)reader["Address"],
                                    City = (string)reader["City"],
                                    PostalCode = (string)reader["PostalCode"],
                                    State = (string)reader["State"],
                                }
                            };

                            retVal.Add(u);
                        }
                    }
                    //6 - Restituisco la lista
                    return retVal;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static User Find(Predicate<User> condizione)
        {
            return GetAll().Find(condizione);
        }

        public static void Add(User u)
        {
            GetAll().Add(u);
        }

        public static bool Update(int id, User u)
        {
            if (u.Id != id) return false;
            User candidate = Find(q => q.Id == id);
            if (candidate == null) return false;

            candidate.FirstName = u.FirstName;
            candidate.LastName = u.LastName;
            candidate.Age = u.Age;
            candidate.Email = u.Email;
            candidate.Username = u.Username;
            candidate.Password = u.Password;
            candidate.BirthDate = u.BirthDate;
            candidate.Gender = u.Gender;

            return true;
        }
        public static List<string> GetGenders()
        {
            return GetAll().Select(s => s.Gender).Distinct().ToList();
        }

        public static string[] FormatAsTable(List<User> users)
        {
            string[] table = new string[users.Count+4];

            int i = 0;

            table[i++] = new String('-', 170);
            table[i++] = string.Format("|{0,3}|{1,10}|{2,12}|{3,3}|{4,7}|{5,27}|{6,13}|{7,13}|{8,11}|{9,30}|{10,15}|{11,6}|{12,6}|",
                "Id", "FirstName","LastName", "Age", "Gender", "Email", "Username", "Password", "BirthDate", "Address","City", "Zip", "State");
            table[i++] = new String('-', 170);

            foreach (User u in users)
            {
                string s = string.Format("|{0,3}|{1,10}|{2,12}|{3,3}|{4,7}|{5,27}|{6,13}|{7,13}|{8,11}|{9,30}|{10,15}|{11,6}|{12,6}|",
                    u.Id, u.FirstName, u.LastName, u.Age, u.Gender, u.Email, u.Username, u.Password, u.BirthDate.ToShortDateString(), u.Address.Address, u.Address.City, u.Address.PostalCode, u.Address.State);

                table[i++] = s;
            }
            table[i++] = new String('-', 170);
            return table;
        }

        public static bool VerificaCredenziali(string u, string p)
        {
            if (u == null || p == null) return false;
            if (string.IsNullOrEmpty(u) || string.IsNullOrEmpty(p)) return false;

            //string connectionString = @"Server=E80\SQLEXPRESS;Database=Users;Integrated Security=True;TrustServerCertificate=True";            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(*) AS UtentiValidi FROM Users";
                    command.CommandText += " WHERE Username=@u AND Password=@p";

                    //SqlParameter p1 = new SqlParameter("@u", u);
                    //command.Parameters.Add(p1);
                    //command.Parameters.Add(new SqlParameter("@u", u));

                    command.Parameters.AddWithValue("@u", u);
                    command.Parameters.AddWithValue("@p", p);

                    //return ((int)command.ExecuteScalar()) > 0;
                    int utentiTrovati = (int)command.ExecuteScalar();
                    return utentiTrovati == 1;
                }
                catch(Exception e)
                {
                    throw;
                }
            }


            /*User user = Find(q => q.Username.ToLower() == u.ToLower() );

            if (user != null && user.Password == p)
            {
                Logins.Add(new Login(user.Id, true, DateTime.Now));
                return true;
            }
            else if( user != null && user.Password != p)
            {
                Logins.Add(new Login(user.Id, false, DateTime.Now));
                return false;
            }
            else
            {
                Logins.Add(new Login(-1, false, DateTime.Now));
                return false;
            }*/
        }

        public static bool InviaMailDiRecupero(string m)
        {
            return Find(u => u.Email.ToLower() == m.ToLower()) != null;
        }
    }
}

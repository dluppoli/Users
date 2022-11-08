using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using UsersClassLibrary.Controllers;
using UsersClassLibrary.Models;

namespace UsersAdo.ViewModels
{
    internal class MainWindowViewModel
    {
        private string connectionString = @"Server=E80\SQLEXPRESS;Database=Users;Integrated Security=True;TrustServerCertificate=True";
        
        internal void CreateTables()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = @"create table Users(
                            Id INT PRIMARY KEY,
                            FirstName VARCHAR(1000) NOT NULL,
                            LastName VARCHAR(1000) NOT NULL,
                            Age INT NOT NULL,
	                        Gender VARCHAR(10) NOT NULL,
                            Email VARCHAR(1000) NOT NULL,
                            Username VARCHAR(1000) NOT NULL,
                            Password VARCHAR(1000) NOT NULL,
                            BirthDate DATETIME NOT NULL,
	                        Address VARCHAR(1000) NOT NULL,
                            City VARCHAR(1000) NOT NULL,
                            PostalCode VARCHAR(1000) NOT NULL,
                            State VARCHAR(1000) NOT NULL)";
                    command.Connection = connection;
                    command.ExecuteNonQuery();


                    command.CommandText = @"CREATE TABLE Logins(
                            UserId INT NOT NULL,
                            Date DATETIME NOT NULL,
                            LoginSuccessful BIT NOT NULL,
                            Note VARCHAR(1000),
                            FOREIGN KEY(UserId) REFERENCES Users(Id)
                        )";
                    command.ExecuteNonQuery();

                    MessageBox.Show("Tabelle create con successo");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Tabelle già esistenti");
                }
                catch (Exception)
                {
                    MessageBox.Show("Errore generico");
                }
            }
        }

        internal void DeleteFromTables()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "DELETE FROM Logins; DELETE FROM Users";
                    command.Connection = connection;
                    int righe = command.ExecuteNonQuery();
                    if( righe==0)
                        MessageBox.Show("Tabelle già vuote");
                    else
                        MessageBox.Show("Tabelle svuotate con successo");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Errore Sql");
                }
                catch (Exception)
                {
                    MessageBox.Show("Errore generico");
                }
            }
        }

        internal void Droptables()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "DROP TABLE Logins; DROP TABLE Users";
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Tabelle cancellate con successo");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Tabelle non esistenti");
                }
                catch(Exception)
                {
                    MessageBox.Show("Errore generico");
                }
            }
        }

        internal void LoadDataOnTables()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    List<User> users = Users.GetAll();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    foreach (User u in users)
                    {
                        command.CommandText = "INSERT INTO Users VALUES(";
                        command.CommandText += u.Id.ToString() + ",";
                        command.CommandText += "'" + u.FirstName.Replace("'","''") + "',";
                        command.CommandText += "'" + u.LastName.Replace("'", "''") + "',";
                        command.CommandText += u.Age + ",";
                        command.CommandText += "'" + u.Gender.Replace("'", "''") + "',";
                        command.CommandText += "'" + u.Email.Replace("'", "''") + "',";
                        command.CommandText += "'" + u.Username.Replace("'", "''") + "',";
                        command.CommandText += "'" + u.Password.Replace("'", "''") + "',";
                        command.CommandText += "'" + u.BirthDate.ToString("yyyy-MM-dd HH:mm:ss") + "',";
                        command.CommandText += "'" + u.Address.Address.Replace("'", "''") + "',";
                        command.CommandText += "'" + u.Address.City.Replace("'", "''") + "',";
                        command.CommandText += "'" + u.Address.PostalCode.Replace("'", "''") + "',";
                        command.CommandText += "'" + u.Address.State.Replace("'", "''") + "'";
                        command.CommandText += ")";

                        command.ExecuteNonQuery();
                    }


                    List<Login> logins = Logins.GetAll();
                    foreach(Login l in logins)
                    {
                        command.CommandText = "INSERT INTO Logins VALUES(";
                        command.CommandText += l.UserId.ToString() + ",";
                        command.CommandText += "'" + l.Date.ToString("yyyy-MM-dd HH:mm:ss") + "',";
                        command.CommandText += l.LoginSuccessfull ? "1," : "0,";  
                        command.CommandText += "'" + l.Notes?.Replace("'", "''") + "'";
                        command.CommandText += ")";

                        command.ExecuteNonQuery();
                    }

                }
                catch (SqlException e)
                {
                    MessageBox.Show("Errore Sql");
                }
                catch (Exception)
                {
                    MessageBox.Show("Errore generico");
                }
            }
        }
    }
}

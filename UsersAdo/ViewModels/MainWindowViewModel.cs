using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UsersAdo.ViewModels
{
    internal class MainWindowViewModel
    {
        private string connectionString = @"Server=E80\SQLEXPRESS;Database=Users;Integrated Security=True;TrustServerCertificate=True";
        
        internal void CreateTables()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}

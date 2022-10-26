using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersWinForms.Controllers;
using UsersWinForms.Models;

namespace UsersWinForms
{
    public partial class EditUser : Form
    {
        #region ViewModel
        //private User user;

        public User UserVM
        {
            get 
            {
                return new User
                {
                    Id = (int)nbrId.Value,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Age = (int)nbrEtà.Value,
                    Gender = (string)(cmbSesso.SelectedItem),
                    BirthDate = dtBirthDate.Value
                };
            }
            set 
            {
                nbrId.Value = value.Id;
                nbrEtà.Value = value.Age;
                txtFirstName.Text = value.FirstName;
                txtLastName.Text = value.LastName;
                txtEmail.Text = value.Email;
                txtUsername.Text = value.Username;
                txtPassword.Text = value.Password;
                dtBirthDate.Value = value.BirthDate;
                cmbSesso.SelectedItem = value.Gender;
            }
        }

        #endregion


        private User u;
        private bool isNew = true;
        public EditUser()
        {
            InitializeComponent();
        }

        public EditUser(User u) : this()
        {
            this.u = u;
            isNew = false;
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            cmbSesso.DataSource = Users.GetGenders();
            cmbSesso.SelectedIndex = -1;
            lblTitolo.Text = "Nuovo utente";

            if ( !isNew )
            {
                /*nbrId.Value = u.Id;
                nbrEtà.Value = u.Age;
                txtFirstName.Text = u.FirstName;
                txtLastName.Text = u.LastName;
                txtEmail.Text = u.Email;
                txtUsername.Text = u.Username;
                txtPassword.Text = u.Password;
                dtBirthDate.Value = u.BirthDate;
                cmbSesso.SelectedItem = u.Gender;*/
                UserVM = u;
                lblTitolo.Text = "Modifica utente";
            }
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            /*User nuovo = new User
            {
                Id = (int)nbrId.Value,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Age = (int)nbrEtà.Value,
                Gender = (string)(cmbSesso.SelectedItem),
                BirthDate = dtBirthDate.Value
            };*/
            if (isNew)
                Users.Add(/*nuovo*/UserVM);
            else
            {
                if( Users.Update(u.Id, /*nuovo*/ UserVM)==false )
                {
                    MessageBox.Show("Errore nell'aggiornamento");
                }
            }
            Close();
        }
    }
}

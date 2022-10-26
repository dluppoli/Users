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
        public EditUser()
        {
            InitializeComponent();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            cmbSesso.DataSource = Users.GetGenders();
            cmbSesso.SelectedIndex = -1;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            User nuovo = new User
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

            Users.Add(nuovo);
            Close();
        }
    }
}

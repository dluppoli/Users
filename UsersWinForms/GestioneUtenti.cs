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
    public partial class GestioneUtenti : Form
    {
        #region ViewModel
        public string SearchText 
        {
            get
            {
                return txtNome.Text;
            }
            set
            {
                txtNome.Text = value;   
            }
        }

        public string SearchSex
        {
            get
            {
                return (string)(cmbSesso.SelectedItem);
            }
        }

        public int SearchSexIndex
        {
            get
            {
                return cmbSesso.SelectedIndex;
            }
            set
            {
                cmbSesso.SelectedIndex = value;
            }
        }

        public List<string> Genders 
        { 
            get
            {
                return (List<string>)(cmbSesso.DataSource);
            }
            set
            {
                cmbSesso.DataSource = value;
            } 
        }

        private List<User> _usersList;
        public List<User> UsersList
        {
            get
            {
                //return (List<User>)(gridUtenti.DataSource);
                return _usersList;
            }
            set
            {
                _usersList = value;
                gridUtenti.DataSource = value;
            }
        }
        #endregion

        public GestioneUtenti()
        {
            InitializeComponent();
        }

        private void LoadGridData()
        {
            UsersList = Users.FindAll(u =>
                (u.FirstName.Contains(SearchText) || u.LastName.Contains(SearchText)) &&
                (SearchSex == null || u.Gender == SearchSex)
            );
        }
        private void GestioneUtenti_Load(object sender, EventArgs e)
        {
            //List<string> genders = Users.GetGenders();
            //foreach (string gender in genders)
            //    cmbSesso.Items.Add(gender);

            Genders = Users.GetGenders();
            SearchSexIndex = -1;

            //gridUtenti.DataSource = Users.GetAll();
            LoadGridData();
            gridUtenti.Columns["Password"].Visible = false;

            //UsersList.Add(new User { Id = 1000 });
            //Users.Add(new User { Id = 100, FirstName="Marco", LastName="Rossi", Gender="male" });
            //LoadGridData();

        }

        private void btnFiltra_Click(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void cmbSesso_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void bntPulisciFiltri_Click(object sender, EventArgs e)
        {
            SearchText = "";
            SearchSexIndex = -1;
            LoadGridData();
        }

        private void btnNuovo_Click(object sender, EventArgs e)
        {
            EditUser edit = new EditUser();
            edit.ShowDialog();
            LoadGridData();
        }

        private void gridUtenti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            User u = UsersList[e.RowIndex];
            EditUser edit = new EditUser(u);
            edit.ShowDialog();
            LoadGridData();
        }
    }
}

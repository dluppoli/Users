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

namespace UsersWinForms
{
    public partial class GestioneUtenti : Form
    {
        public GestioneUtenti()
        {
            InitializeComponent();
        }
        private void GestioneUtenti_Load(object sender, EventArgs e)
        {
            //List<string> genders = Users.GetGenders();
            //foreach (string gender in genders)
            //    cmbSesso.Items.Add(gender);

            cmbSesso.DataSource = Users.GetGenders();
            gridUtenti.DataSource = Users.GetAll();

            cmbSesso.SelectedIndex = -1;
            gridUtenti.Columns["Password"].Visible = false;
        }

        private void btnFiltra_Click(object sender, EventArgs e)
        {
            gridUtenti.DataSource = Users.FindAll(u =>
                ( u.FirstName.Contains(txtNome.Text) || u.LastName.Contains(txtNome.Text) ) &&
                ( cmbSesso.SelectedItem == null || u.Gender==(string)(cmbSesso.SelectedItem) )
            );
        }
    }
}

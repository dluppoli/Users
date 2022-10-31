using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsersWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void logoutMenuItem_Click(object sender, EventArgs e)
        {
            ShowLoginUserControl();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowLoginUserControl();
            loginUserControl.LoginSuccesful += LoginSuccessful;
        }

        private void LoginSuccessful(object sender, EventArgs e)
        {
            ShowUtentiUserControl();
        }

        private void ShowLoginUserControl()
        {
            loginUserControl.Visible = true;
            gestioneUtenti.Visible = false;
            gestioneAccessiUserControl.Visible = false;
            logoutMenuItem.Enabled = false;
            datiMenuItem.Enabled = false;
        }
        private void ShowUtentiUserControl()
        {
            loginUserControl.Visible = false;
            gestioneUtenti.Visible = true;
            gestioneAccessiUserControl.Visible = false;
            logoutMenuItem.Enabled = true;
            datiMenuItem.Enabled = true;
        }

        private void ShowAccessiUserControl()
        {
            loginUserControl.Visible = false;
            gestioneUtenti.Visible = false;
            gestioneAccessiUserControl.Visible = true;
            logoutMenuItem.Enabled = true;
            datiMenuItem.Enabled = true;
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Davide Luppoli - Progetto Winforms");
        }

        private void gestioneUtentiMenuItem_Click(object sender, EventArgs e)
        {
            ShowUtentiUserControl();
        }

        private void gestioneAccessiMenuItem_Click(object sender, EventArgs e)
        {
            ShowAccessiUserControl();
        }
    }
}

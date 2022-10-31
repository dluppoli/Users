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
    public partial class LoginUserControl : UserControl
    {
        public event EventHandler LoginSuccesful;
        public LoginUserControl()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Username.Text);
            //1 - Modificare il controller aggiungendo public bool VerificaCredenziali(string u, string p)

            //2 - Chiamare il metodo VerificaCredenziali
            bool ok = Users.VerificaCredenziali(Username.Text, Password.Text);

            //3 - In base alla risposta visualizzare la msgbox opportuna
            //MessageBox.Show(ok ? "Login Corretto" : "Login Errato");
            if (!ok)
                MessageBox.Show("Login Errato");
            else
                LoginSuccesful?.Invoke(this, EventArgs.Empty);
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
                Password.PasswordChar = (char)0;
            else
                Password.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Site != null && Site.DesignMode) return;
            pnlLogin.Visible = true;
            pnlPasswordDimenticata.Visible = false;
        }

        private void btnPasswordDimenticata_Click(object sender, EventArgs e)
        {
            SwapPannelli();
        }

        private void SwapPannelli()
        {
            pnlLogin.Visible = !pnlLogin.Visible;
            pnlPasswordDimenticata.Visible = !pnlPasswordDimenticata.Visible;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool mailTrovata = Users.InviaMailDiRecupero(Mail.Text);
            if(mailTrovata)
            {
                MessageBox.Show("Mail Inviata");
                SwapPannelli();
            }
            else
                MessageBox.Show("Mail non trovata");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SwapPannelli();
        }
    }
}

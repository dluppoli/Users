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
    public partial class GestioneAccessiUserControl1 : UserControl
    {
        #region VM
        public bool SoloAccessiFalliti 
        { 
            get
            {
                return chkSoloFalliti.Checked;
            } 
            set
            { 
                chkSoloFalliti.Checked = value;
            } 
        }

        public int SearchUtenteIndex
        {
            get
            {
                return cmbUtente.SelectedIndex;
            }
            set
            {
                cmbUtente.SelectedIndex = value;
            }
        }

        public List<User> Utenti
        {
            get
            {
                return (List<User>)(cmbUtente.DataSource);
            }
            set
            {
                cmbUtente.DataSource = value;
            }
        }

        private List<Login> _accessiList;
        public List<Login> AccessiList
        {
            get
            {
                return _accessiList;
            }
            set
            {
                _accessiList = value;
                gridAccessi.DataSource = value;
            }
        }
        #endregion

        public GestioneAccessiUserControl1()
        {
            InitializeComponent();
        }

        private void GestioneAccessiUserControl1_Load(object sender, EventArgs e)
        {
            if (Site != null && Site.DesignMode) return;
            Utenti = Users.GetAll();
            LoadGridData();
            SearchUtenteIndex = -1;

            cmbUtente.DisplayMember = "Lastname";
            cmbUtente.ValueMember = "Id";
            gridAccessi.Columns["UserId"].Visible = false;
        }

        private void LoadGridData()
        {
            AccessiList = Logins.FindAll(u =>
                u.UserId == SearchUtenteIndex && (!SoloAccessiFalliti || !u.LoginSuccessfull) );
        }

        private void chkSoloFalliti_CheckedChanged(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void cmbUtente_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void GestioneAccessiUserControl1_VisibleChanged(object sender, EventArgs e)
        {
            LoadGridData();
        }
    }
}

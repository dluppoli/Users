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

        public int SearchUtenteId
        {
            get
            {
                return (int)(cmbUtente.SelectedValue ?? -1);
            }
            set
            {
                cmbUtente.SelectedValue = value;
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
            LoadGridData();

            cmbUtente.DisplayMember = "Lastname";
            cmbUtente.ValueMember = "Id";
            Utenti = Users.GetAll();
            SearchUtenteId = -1;

            gridAccessi.Columns["UserId"].Visible = false;
        }

        private void LoadGridData()
        {
            AccessiList = Logins.FindAll(u =>
                u.UserId == SearchUtenteId && (!SoloAccessiFalliti || !u.LoginSuccessfull) );
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

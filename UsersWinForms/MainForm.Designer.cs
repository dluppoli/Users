namespace UsersWinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneUtentiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneAccessiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginUserControl = new UsersWinForms.LoginUserControl();
            this.gestioneUtenti = new UsersWinForms.GestioneUtenti();
            this.gestioneAccessiUserControl = new UsersWinForms.GestioneAccessiUserControl1();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.datiMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(864, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutMenuItem,
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // logoutMenuItem
            // 
            this.logoutMenuItem.Name = "logoutMenuItem";
            this.logoutMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutMenuItem.Text = "Logout";
            this.logoutMenuItem.Click += new System.EventHandler(this.logoutMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // datiMenuItem
            // 
            this.datiMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestioneUtentiMenuItem,
            this.gestioneAccessiMenuItem});
            this.datiMenuItem.Name = "datiMenuItem";
            this.datiMenuItem.Size = new System.Drawing.Size(40, 20);
            this.datiMenuItem.Text = "Dati";
            // 
            // gestioneUtentiMenuItem
            // 
            this.gestioneUtentiMenuItem.Name = "gestioneUtentiMenuItem";
            this.gestioneUtentiMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestioneUtentiMenuItem.Text = "Gestione utenti";
            this.gestioneUtentiMenuItem.Click += new System.EventHandler(this.gestioneUtentiMenuItem_Click);
            // 
            // gestioneAccessiMenuItem
            // 
            this.gestioneAccessiMenuItem.Name = "gestioneAccessiMenuItem";
            this.gestioneAccessiMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestioneAccessiMenuItem.Text = "Gestione accessi";
            this.gestioneAccessiMenuItem.Click += new System.EventHandler(this.gestioneAccessiMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // loginUserControl
            // 
            this.loginUserControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginUserControl.Location = new System.Drawing.Point(141, 99);
            this.loginUserControl.Name = "loginUserControl";
            this.loginUserControl.Size = new System.Drawing.Size(575, 286);
            this.loginUserControl.TabIndex = 1;
            // 
            // gestioneUtenti
            // 
            this.gestioneUtenti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gestioneUtenti.Genders = null;
            this.gestioneUtenti.Location = new System.Drawing.Point(0, 27);
            this.gestioneUtenti.Name = "gestioneUtenti";
            this.gestioneUtenti.SearchSexIndex = -1;
            this.gestioneUtenti.SearchText = "";
            this.gestioneUtenti.Size = new System.Drawing.Size(864, 467);
            this.gestioneUtenti.TabIndex = 2;
            this.gestioneUtenti.UsersList = null;
            // 
            // gestioneAccessiUserControl
            // 
            this.gestioneAccessiUserControl.AccessiList = null;
            this.gestioneAccessiUserControl.Location = new System.Drawing.Point(0, 27);
            this.gestioneAccessiUserControl.Name = "gestioneAccessiUserControl";
            this.gestioneAccessiUserControl.SearchUtenteIndex = -1;
            this.gestioneAccessiUserControl.Size = new System.Drawing.Size(864, 467);
            this.gestioneAccessiUserControl.SoloAccessiFalliti = false;
            this.gestioneAccessiUserControl.TabIndex = 3;
            this.gestioneAccessiUserControl.Utenti = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 488);
            this.Controls.Add(this.gestioneAccessiUserControl);
            this.Controls.Add(this.loginUserControl);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.gestioneUtenti);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private LoginUserControl loginUserControl;
        private GestioneUtenti gestioneUtenti;
        private System.Windows.Forms.ToolStripMenuItem datiMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestioneUtentiMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestioneAccessiMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private GestioneAccessiUserControl1 gestioneAccessiUserControl;
    }
}
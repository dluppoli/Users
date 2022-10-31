namespace UsersWinForms
{
    partial class GestioneAccessiUserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridAccessi = new System.Windows.Forms.DataGridView();
            this.lblNome = new System.Windows.Forms.Label();
            this.cmbUtente = new System.Windows.Forms.ComboBox();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.chkSoloFalliti = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAccessi)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAccessi
            // 
            this.gridAccessi.AllowUserToAddRows = false;
            this.gridAccessi.AllowUserToDeleteRows = false;
            this.gridAccessi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAccessi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridAccessi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAccessi.Location = new System.Drawing.Point(17, 167);
            this.gridAccessi.MultiSelect = false;
            this.gridAccessi.Name = "gridAccessi";
            this.gridAccessi.ReadOnly = true;
            this.gridAccessi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAccessi.Size = new System.Drawing.Size(771, 271);
            this.gridAccessi.TabIndex = 13;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(17, 86);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(80, 13);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Filtra per utente";
            // 
            // cmbUtente
            // 
            this.cmbUtente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUtente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUtente.FormattingEnabled = true;
            this.cmbUtente.Location = new System.Drawing.Point(17, 104);
            this.cmbUtente.Name = "cmbUtente";
            this.cmbUtente.Size = new System.Drawing.Size(627, 21);
            this.cmbUtente.TabIndex = 11;
            this.cmbUtente.SelectedIndexChanged += new System.EventHandler(this.cmbUtente_SelectedIndexChanged);
            // 
            // lblTitolo
            // 
            this.lblTitolo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitolo.Location = new System.Drawing.Point(12, 9);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(206, 26);
            this.lblTitolo.TabIndex = 10;
            this.lblTitolo.Text = "Gestione Accessi";
            // 
            // chkSoloFalliti
            // 
            this.chkSoloFalliti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSoloFalliti.AutoSize = true;
            this.chkSoloFalliti.Location = new System.Drawing.Point(665, 107);
            this.chkSoloFalliti.Name = "chkSoloFalliti";
            this.chkSoloFalliti.Size = new System.Drawing.Size(109, 17);
            this.chkSoloFalliti.TabIndex = 14;
            this.chkSoloFalliti.Text = "Solo accessi falliti";
            this.chkSoloFalliti.UseVisualStyleBackColor = true;
            this.chkSoloFalliti.CheckedChanged += new System.EventHandler(this.chkSoloFalliti_CheckedChanged);
            // 
            // GestioneAccessiUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkSoloFalliti);
            this.Controls.Add(this.gridAccessi);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.cmbUtente);
            this.Controls.Add(this.lblTitolo);
            this.Name = "GestioneAccessiUserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.GestioneAccessiUserControl1_Load);
            this.VisibleChanged += new System.EventHandler(this.GestioneAccessiUserControl1_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.gridAccessi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAccessi;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cmbUtente;
        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.CheckBox chkSoloFalliti;
    }
}

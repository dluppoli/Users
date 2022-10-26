namespace UsersWinForms
{
    partial class GestioneUtenti
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
            this.lblTitolo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmbSesso = new System.Windows.Forms.ComboBox();
            this.btnFiltra = new System.Windows.Forms.Button();
            this.bntPulisciFiltri = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSesso = new System.Windows.Forms.Label();
            this.btnNuovo = new System.Windows.Forms.Button();
            this.gridUtenti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridUtenti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitolo
            // 
            this.lblTitolo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitolo.Location = new System.Drawing.Point(12, 9);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(551, 26);
            this.lblTitolo.TabIndex = 1;
            this.lblTitolo.Text = "Utenti";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(17, 105);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(523, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // cmbSesso
            // 
            this.cmbSesso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSesso.FormattingEnabled = true;
            this.cmbSesso.Location = new System.Drawing.Point(546, 104);
            this.cmbSesso.Name = "cmbSesso";
            this.cmbSesso.Size = new System.Drawing.Size(161, 21);
            this.cmbSesso.TabIndex = 3;
            this.cmbSesso.SelectedIndexChanged += new System.EventHandler(this.cmbSesso_SelectedIndexChanged);
            // 
            // btnFiltra
            // 
            this.btnFiltra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltra.Location = new System.Drawing.Point(713, 101);
            this.btnFiltra.Name = "btnFiltra";
            this.btnFiltra.Size = new System.Drawing.Size(75, 23);
            this.btnFiltra.TabIndex = 4;
            this.btnFiltra.Text = "Filtra";
            this.btnFiltra.UseVisualStyleBackColor = true;
            this.btnFiltra.Click += new System.EventHandler(this.btnFiltra_Click);
            // 
            // bntPulisciFiltri
            // 
            this.bntPulisciFiltri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntPulisciFiltri.Location = new System.Drawing.Point(713, 130);
            this.bntPulisciFiltri.Name = "bntPulisciFiltri";
            this.bntPulisciFiltri.Size = new System.Drawing.Size(75, 23);
            this.bntPulisciFiltri.TabIndex = 5;
            this.bntPulisciFiltri.Text = "Azzera filtri";
            this.bntPulisciFiltri.UseVisualStyleBackColor = true;
            this.bntPulisciFiltri.Click += new System.EventHandler(this.bntPulisciFiltri_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(17, 86);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(76, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Filtra per nome";
            // 
            // lblSesso
            // 
            this.lblSesso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSesso.AutoSize = true;
            this.lblSesso.Location = new System.Drawing.Point(543, 86);
            this.lblSesso.Name = "lblSesso";
            this.lblSesso.Size = new System.Drawing.Size(77, 13);
            this.lblSesso.TabIndex = 7;
            this.lblSesso.Text = "Filtra per sesso";
            // 
            // btnNuovo
            // 
            this.btnNuovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuovo.Location = new System.Drawing.Point(677, 9);
            this.btnNuovo.Name = "btnNuovo";
            this.btnNuovo.Size = new System.Drawing.Size(111, 40);
            this.btnNuovo.TabIndex = 8;
            this.btnNuovo.Text = "Nuovo utente";
            this.btnNuovo.UseVisualStyleBackColor = true;
            this.btnNuovo.Click += new System.EventHandler(this.btnNuovo_Click);
            // 
            // gridUtenti
            // 
            this.gridUtenti.AllowUserToAddRows = false;
            this.gridUtenti.AllowUserToDeleteRows = false;
            this.gridUtenti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUtenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridUtenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUtenti.Location = new System.Drawing.Point(17, 167);
            this.gridUtenti.MultiSelect = false;
            this.gridUtenti.Name = "gridUtenti";
            this.gridUtenti.ReadOnly = true;
            this.gridUtenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUtenti.Size = new System.Drawing.Size(771, 271);
            this.gridUtenti.TabIndex = 9;
            this.gridUtenti.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUtenti_CellDoubleClick);
            // 
            // GestioneUtenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridUtenti);
            this.Controls.Add(this.btnNuovo);
            this.Controls.Add(this.lblSesso);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.bntPulisciFiltri);
            this.Controls.Add(this.btnFiltra);
            this.Controls.Add(this.cmbSesso);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblTitolo);
            this.Name = "GestioneUtenti";
            this.Text = "GestioneUtenti";
            this.Load += new System.EventHandler(this.GestioneUtenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUtenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbSesso;
        private System.Windows.Forms.Button btnFiltra;
        private System.Windows.Forms.Button bntPulisciFiltri;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSesso;
        private System.Windows.Forms.Button btnNuovo;
        private System.Windows.Forms.DataGridView gridUtenti;
    }
}
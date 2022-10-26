using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlsAndEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.Visible = true;
            userControl21.Visible = false;

            userControl11.miHannoCliccato += mostraUC2ToolStripMenuItem_Click;
            userControl21.miHannoCliccato += mostraUC1ToolStripMenuItem_Click;
        }

        private void mostraUC1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.Visible = true;
            userControl21.Visible = false;
        }

        private void mostraUC2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.Visible = false;
            userControl21.Visible = true;
        }
    }
}

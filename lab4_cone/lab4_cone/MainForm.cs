using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab4_cone
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogBox dialogBox = new DialogBox();
            dialogBox.Show();
        }

        private void workToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

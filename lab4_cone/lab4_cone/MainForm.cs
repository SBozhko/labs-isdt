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
        private Cone Cone { set; get; }
        public DialogBox DialogBox { set; get; }        

        public MainForm()
        {
            InitializeComponent();
            Cone = new Cone();
            DialogBox = new DialogBox();
            DialogBox.Cone = this.Cone;
        }
        
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inputMenuItem_Click(object sender, EventArgs e)
        {           
            DialogBox.Show();
        }

        private void workMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}

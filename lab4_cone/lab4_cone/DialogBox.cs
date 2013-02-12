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
    public partial class DialogBox : Form
    {
        public Cone Cone { set; get; }

        public DialogBox()
        {
            InitializeComponent();
        }

        private void savePropertiesButton_Click(object sender, EventArgs e)
        {
            Cone.Radius = Double.Parse(this.radiusTextBox.Text);
            Cone.Height = Double.Parse(this.heightTextBox.Text);
            Cone.Density = Double.Parse(this.densityTextBox.Text);
            this.Close();
        }        
    }
}

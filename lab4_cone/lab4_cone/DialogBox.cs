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
        private Cone cone;
        public Cone Cone
        {
            set { this.cone = value; }
            get { return this.cone; }
        }

        private bool calcVolume;
        public bool CalcVolume
        { 
            set { this.calcVolume = value; }
            get { return this.calcVolume; }
        }

        private bool calcMass;
        public bool CalcMass
        {
            set { this.calcMass = value; }
            get { return this.calcMass; }
        }        

        public DialogBox()
        {
            InitializeComponent();
        }

        private void savePropertiesButton_Click(object sender, EventArgs e)
        {
            cone.Radius = Double.Parse(this.radiusTextBox.Text);
            cone.Height = Double.Parse(this.heightTextBox.Text);
            cone.Density = Double.Parse(this.densityTextBox.Text);

            calcVolume = this.volumeCheckBox.Checked;
            calcMass = this.massCheckBox.Checked;

            this.Close();
        }        
    }
}

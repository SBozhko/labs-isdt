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
        public bool CalcVolume { set; get; }
        public bool CalcMass { set; get; }

        public DialogBox()
        {
            InitializeComponent();
        }

        private void savePropertiesButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Double.Parse(this.radiusTextBox.Text) < 0 ||
                    Double.Parse(this.heightTextBox.Text) < 0 ||
                    Double.Parse(this.densityTextBox.Text) < 0)
                {
                    throw new IllegalArgumentException();
                }

                Cone.Radius = Double.Parse(this.radiusTextBox.Text);
                Cone.Height = Double.Parse(this.heightTextBox.Text);
                Cone.Density = Double.Parse(this.densityTextBox.Text);

                CalcVolume = this.volumeCheckBox.Checked;
                CalcMass = this.massCheckBox.Checked;

                this.Hide();
            }
            catch (IllegalArgumentException)
            {
                MessageBox.Show("Negative numbers for cone's parameters detected", "Validation error");
            }
            catch (Exception)
            {
                MessageBox.Show("Please, input correct data", "Validation error");
            }


        }
    }
}

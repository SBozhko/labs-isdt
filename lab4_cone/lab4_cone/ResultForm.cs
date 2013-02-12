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
    public partial class ResultForm : Form
    {
        private Cone cone;
        public Cone Cone
        {
            set { this.cone = value; }
            get { return this.cone; }
        }


        private bool renderMass;
        public bool RenderMass
        {
            set { this.renderMass = value; }
            get { return this.renderMass; }
        }

        private bool renderVolume;
        public bool RenderVolume
        {
            set { this.renderVolume = value; }
            get { return this.renderVolume; }
        }       

        public ResultForm()
        {
            InitializeComponent();           
        }

        public void ShowResults()
        {
            this.massResLabel.Text = this.cone.Mass.ToString();
            this.volumeResLabel.Text = this.cone.Volume.ToString();

            this.massLabel.Visible = this.renderMass;
            this.massResLabel.Visible = this.renderMass;
            this.volumeLabel.Visible = this.renderVolume;
            this.volumeResLabel.Visible = this.renderVolume;
        }   
    }
}

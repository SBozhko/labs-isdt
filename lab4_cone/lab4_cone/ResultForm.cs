﻿using System;
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
        public Cone Cone { set; get; }
        public bool RenderMass { set; get; }
        public bool RenderVolume { set; get; }

        public ResultForm()
        {
            InitializeComponent();
        }

        public void ShowResults()
        {
            this.massResLabel.Text = String.Format("{0:0,0.00}", this.Cone.Mass);
            this.volumeResLabel.Text = String.Format("{0:0,0.00}", this.Cone.Volume);

            this.massLabel.Visible = this.RenderMass;
            this.massResLabel.Visible = this.RenderMass;
            this.volumeLabel.Visible = this.RenderVolume;
            this.volumeResLabel.Visible = this.RenderVolume;
        }
    }
}

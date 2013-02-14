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
        public Cone Cone { set; get; }
        public DialogBox DialogBox { set; get; }
        public ResultForm ResultForm { set; get; }

        public MainForm()
        {
            InitializeComponent();

            this.Cone = new Cone();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inputMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogBox = new DialogBox();
            this.DialogBox.Cone = this.Cone;
            this.DialogBox.Show();
        }

        private void workMenuItem_Click(object sender, EventArgs e)
        {
            this.ResultForm = new ResultForm();
            this.ResultForm.Cone = this.DialogBox.Cone;
            this.ResultForm.RenderMass = this.DialogBox.CalcMass;
            this.ResultForm.RenderVolume = this.DialogBox.CalcVolume;
            this.ResultForm.ShowResults();
            this.ResultForm.Show();
        }
    }
}

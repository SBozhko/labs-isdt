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
        private Cone cone;
        public Cone Cone
        {
            set { this.cone = value; }
            get { return this.cone; }
        }

        private DialogBox dialogBox;
        public DialogBox DialogBox
        {
            set { this.dialogBox = value; }
            get { return this.dialogBox; }
        }

        private ResultForm resultForm;
        public ResultForm ResultForm
        {
            set { this.resultForm = value; }
            get { return this.resultForm; }
        }       

        public MainForm()
        {
            InitializeComponent();
            
            cone = new Cone();
            dialogBox = new DialogBox();            
            dialogBox.Cone = this.Cone;            
        }
        
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inputMenuItem_Click(object sender, EventArgs e)
        {           
            dialogBox.Show();
        }

        private void workMenuItem_Click(object sender, EventArgs e)
        {
            this.resultForm = new ResultForm();
            this.resultForm.Cone = this.dialogBox.Cone;
            this.resultForm.RenderMass = this.dialogBox.CalcMass;
            this.resultForm.RenderVolume = this.dialogBox.CalcVolume;
            this.resultForm.ShowResults();
            this.resultForm.Show();
        }
    }
}

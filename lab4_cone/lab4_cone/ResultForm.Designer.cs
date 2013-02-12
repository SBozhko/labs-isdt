namespace lab4_cone
{
    partial class ResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.volumeLabel = new System.Windows.Forms.Label();
            this.volumeResLabel = new System.Windows.Forms.Label();
            this.massLabel = new System.Windows.Forms.Label();
            this.massResLabel = new System.Windows.Forms.Label();
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.resultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(15, 26);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(45, 13);
            this.volumeLabel.TabIndex = 0;
            this.volumeLabel.Text = "Volume:";
            // 
            // volumeResLabel
            // 
            this.volumeResLabel.AutoSize = true;
            this.volumeResLabel.Location = new System.Drawing.Point(66, 26);
            this.volumeResLabel.Name = "volumeResLabel";
            this.volumeResLabel.Size = new System.Drawing.Size(0, 13);
            this.volumeResLabel.TabIndex = 1;
            // 
            // massLabel
            // 
            this.massLabel.AutoSize = true;
            this.massLabel.Location = new System.Drawing.Point(15, 52);
            this.massLabel.Name = "massLabel";
            this.massLabel.Size = new System.Drawing.Size(35, 13);
            this.massLabel.TabIndex = 2;
            this.massLabel.Text = "Mass:";
            // 
            // massResLabel
            // 
            this.massResLabel.AutoSize = true;
            this.massResLabel.Location = new System.Drawing.Point(66, 52);
            this.massResLabel.Name = "massResLabel";
            this.massResLabel.Size = new System.Drawing.Size(0, 13);
            this.massResLabel.TabIndex = 3;
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.Controls.Add(this.massLabel);
            this.resultGroupBox.Controls.Add(this.massResLabel);
            this.resultGroupBox.Controls.Add(this.volumeLabel);
            this.resultGroupBox.Controls.Add(this.volumeResLabel);
            this.resultGroupBox.Location = new System.Drawing.Point(12, 21);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Size = new System.Drawing.Size(199, 100);
            this.resultGroupBox.TabIndex = 4;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Text = "Cone\'s characteristics";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(223, 144);
            this.Controls.Add(this.resultGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Results";
            this.resultGroupBox.ResumeLayout(false);
            this.resultGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.Label volumeResLabel;
        private System.Windows.Forms.Label massLabel;
        private System.Windows.Forms.Label massResLabel;
        private System.Windows.Forms.GroupBox resultGroupBox;
    }
}
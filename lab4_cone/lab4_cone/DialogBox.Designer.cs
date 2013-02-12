namespace lab4_cone
{
    partial class DialogBox
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
            this.conePropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.densityTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.densityLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.propertiesToCalcGroupBox = new System.Windows.Forms.GroupBox();
            this.savePropertiesButton = new System.Windows.Forms.Button();
            this.volumeCheckBox = new System.Windows.Forms.CheckBox();
            this.massCheckBox = new System.Windows.Forms.CheckBox();
            this.conePropertiesGroupBox.SuspendLayout();
            this.propertiesToCalcGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // conePropertiesGroupBox
            // 
            this.conePropertiesGroupBox.Controls.Add(this.densityTextBox);
            this.conePropertiesGroupBox.Controls.Add(this.heightTextBox);
            this.conePropertiesGroupBox.Controls.Add(this.densityLabel);
            this.conePropertiesGroupBox.Controls.Add(this.heightLabel);
            this.conePropertiesGroupBox.Controls.Add(this.radiusLabel);
            this.conePropertiesGroupBox.Controls.Add(this.radiusTextBox);
            this.conePropertiesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.conePropertiesGroupBox.Name = "conePropertiesGroupBox";
            this.conePropertiesGroupBox.Size = new System.Drawing.Size(200, 118);
            this.conePropertiesGroupBox.TabIndex = 1;
            this.conePropertiesGroupBox.TabStop = false;
            this.conePropertiesGroupBox.Text = "Cone properties";
            // 
            // densityTextBox
            // 
            this.densityTextBox.Location = new System.Drawing.Point(74, 88);
            this.densityTextBox.Name = "densityTextBox";
            this.densityTextBox.Size = new System.Drawing.Size(100, 20);
            this.densityTextBox.TabIndex = 5;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(74, 56);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 4;
            // 
            // densityLabel
            // 
            this.densityLabel.AutoSize = true;
            this.densityLabel.Location = new System.Drawing.Point(11, 88);
            this.densityLabel.Name = "densityLabel";
            this.densityLabel.Size = new System.Drawing.Size(45, 13);
            this.densityLabel.TabIndex = 3;
            this.densityLabel.Text = "Density:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(11, 56);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(41, 13);
            this.heightLabel.TabIndex = 2;
            this.heightLabel.Text = "Height:";
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Location = new System.Drawing.Point(11, 26);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(43, 13);
            this.radiusLabel.TabIndex = 1;
            this.radiusLabel.Text = "Radius:";
            // 
            // radiusTextBox
            // 
            this.radiusTextBox.Location = new System.Drawing.Point(74, 26);
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.radiusTextBox.TabIndex = 0;
            // 
            // propertiesToCalcGroupBox
            // 
            this.propertiesToCalcGroupBox.Controls.Add(this.massCheckBox);
            this.propertiesToCalcGroupBox.Controls.Add(this.volumeCheckBox);
            this.propertiesToCalcGroupBox.Location = new System.Drawing.Point(232, 12);
            this.propertiesToCalcGroupBox.Name = "propertiesToCalcGroupBox";
            this.propertiesToCalcGroupBox.Size = new System.Drawing.Size(101, 82);
            this.propertiesToCalcGroupBox.TabIndex = 2;
            this.propertiesToCalcGroupBox.TabStop = false;
            this.propertiesToCalcGroupBox.Text = "Calculate:";
            // 
            // savePropertiesButton
            // 
            this.savePropertiesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.savePropertiesButton.Location = new System.Drawing.Point(232, 100);
            this.savePropertiesButton.Name = "savePropertiesButton";
            this.savePropertiesButton.Size = new System.Drawing.Size(101, 30);
            this.savePropertiesButton.TabIndex = 3;
            this.savePropertiesButton.Text = "OK";
            this.savePropertiesButton.UseVisualStyleBackColor = true;
            this.savePropertiesButton.Click += new System.EventHandler(this.savePropertiesButton_Click);
            // 
            // volumeCheckBox
            // 
            this.volumeCheckBox.AutoSize = true;
            this.volumeCheckBox.Location = new System.Drawing.Point(18, 26);
            this.volumeCheckBox.Name = "volumeCheckBox";
            this.volumeCheckBox.Size = new System.Drawing.Size(61, 17);
            this.volumeCheckBox.TabIndex = 0;
            this.volumeCheckBox.Text = "Volume";
            this.volumeCheckBox.UseVisualStyleBackColor = true;
            // 
            // massCheckBox
            // 
            this.massCheckBox.AutoSize = true;
            this.massCheckBox.Location = new System.Drawing.Point(18, 56);
            this.massCheckBox.Name = "massCheckBox";
            this.massCheckBox.Size = new System.Drawing.Size(51, 17);
            this.massCheckBox.TabIndex = 1;
            this.massCheckBox.Text = "Mass";
            this.massCheckBox.UseVisualStyleBackColor = true;
            // 
            // DialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(345, 142);
            this.Controls.Add(this.savePropertiesButton);
            this.Controls.Add(this.propertiesToCalcGroupBox);
            this.Controls.Add(this.conePropertiesGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DialogBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input cone\'s parameters";
            this.conePropertiesGroupBox.ResumeLayout(false);
            this.conePropertiesGroupBox.PerformLayout();
            this.propertiesToCalcGroupBox.ResumeLayout(false);
            this.propertiesToCalcGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox conePropertiesGroupBox;
        private System.Windows.Forms.GroupBox propertiesToCalcGroupBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.TextBox radiusTextBox;
        private System.Windows.Forms.Label densityLabel;
        private System.Windows.Forms.TextBox densityTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Button savePropertiesButton;
        private System.Windows.Forms.CheckBox massCheckBox;
        private System.Windows.Forms.CheckBox volumeCheckBox;
    }
}
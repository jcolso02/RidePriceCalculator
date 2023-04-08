
namespace Prog2
{
    partial class Form1
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
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.coCTextBox = new System.Windows.Forms.TextBox();
            this.coBTextBox = new System.Windows.Forms.TextBox();
            this.coATextBox = new System.Windows.Forms.TextBox();
            this.coCLabel = new System.Windows.Forms.Label();
            this.coBLabel = new System.Windows.Forms.Label();
            this.coALabel = new System.Windows.Forms.Label();
            this.passengersLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.carLabel = new System.Windows.Forms.Label();
            this.passengersTextBox = new System.Windows.Forms.TextBox();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.carComboBox = new System.Windows.Forms.ComboBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.passengersErrorLabel = new System.Windows.Forms.Label();
            this.distanceErrorLabel = new System.Windows.Forms.Label();
            this.carTypeErrorLabel = new System.Windows.Forms.Label();
            this.resultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.resultsTextBox);
            this.resultsGroupBox.Controls.Add(this.coCTextBox);
            this.resultsGroupBox.Controls.Add(this.coBTextBox);
            this.resultsGroupBox.Controls.Add(this.coATextBox);
            this.resultsGroupBox.Controls.Add(this.coCLabel);
            this.resultsGroupBox.Controls.Add(this.coBLabel);
            this.resultsGroupBox.Controls.Add(this.coALabel);
            this.resultsGroupBox.Location = new System.Drawing.Point(293, 36);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(315, 223);
            this.resultsGroupBox.TabIndex = 0;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Results";
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Enabled = false;
            this.resultsTextBox.Location = new System.Drawing.Point(39, 177);
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.Size = new System.Drawing.Size(236, 20);
            this.resultsTextBox.TabIndex = 6;
            // 
            // coCTextBox
            // 
            this.coCTextBox.Enabled = false;
            this.coCTextBox.Location = new System.Drawing.Point(175, 137);
            this.coCTextBox.Name = "coCTextBox";
            this.coCTextBox.Size = new System.Drawing.Size(100, 20);
            this.coCTextBox.TabIndex = 5;
            // 
            // coBTextBox
            // 
            this.coBTextBox.Enabled = false;
            this.coBTextBox.Location = new System.Drawing.Point(175, 84);
            this.coBTextBox.Name = "coBTextBox";
            this.coBTextBox.Size = new System.Drawing.Size(100, 20);
            this.coBTextBox.TabIndex = 4;
            // 
            // coATextBox
            // 
            this.coATextBox.Enabled = false;
            this.coATextBox.Location = new System.Drawing.Point(175, 33);
            this.coATextBox.Name = "coATextBox";
            this.coATextBox.Size = new System.Drawing.Size(100, 20);
            this.coATextBox.TabIndex = 3;
            // 
            // coCLabel
            // 
            this.coCLabel.AutoSize = true;
            this.coCLabel.Location = new System.Drawing.Point(36, 140);
            this.coCLabel.Name = "coCLabel";
            this.coCLabel.Size = new System.Drawing.Size(85, 13);
            this.coCLabel.TabIndex = 2;
            this.coCLabel.Text = "Company C Cost";
            // 
            // coBLabel
            // 
            this.coBLabel.AutoSize = true;
            this.coBLabel.Location = new System.Drawing.Point(36, 87);
            this.coBLabel.Name = "coBLabel";
            this.coBLabel.Size = new System.Drawing.Size(85, 13);
            this.coBLabel.TabIndex = 1;
            this.coBLabel.Text = "Company B Cost";
            // 
            // coALabel
            // 
            this.coALabel.AutoSize = true;
            this.coALabel.Location = new System.Drawing.Point(36, 36);
            this.coALabel.Name = "coALabel";
            this.coALabel.Size = new System.Drawing.Size(83, 13);
            this.coALabel.TabIndex = 0;
            this.coALabel.Text = "Compant A Cost";
            // 
            // passengersLabel
            // 
            this.passengersLabel.AutoSize = true;
            this.passengersLabel.Location = new System.Drawing.Point(23, 72);
            this.passengersLabel.Name = "passengersLabel";
            this.passengersLabel.Size = new System.Drawing.Size(92, 13);
            this.passengersLabel.TabIndex = 1;
            this.passengersLabel.Text = "Passengers (1-12)";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(33, 123);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(82, 13);
            this.distanceLabel.TabIndex = 2;
            this.distanceLabel.Text = "Distance (Miles)";
            // 
            // carLabel
            // 
            this.carLabel.AutoSize = true;
            this.carLabel.Location = new System.Drawing.Point(62, 176);
            this.carLabel.Name = "carLabel";
            this.carLabel.Size = new System.Drawing.Size(53, 13);
            this.carLabel.TabIndex = 3;
            this.carLabel.Text = "Car Type:";
            // 
            // passengersTextBox
            // 
            this.passengersTextBox.Location = new System.Drawing.Point(121, 69);
            this.passengersTextBox.Name = "passengersTextBox";
            this.passengersTextBox.Size = new System.Drawing.Size(100, 20);
            this.passengersTextBox.TabIndex = 4;
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(121, 120);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.distanceTextBox.TabIndex = 5;
            // 
            // carComboBox
            // 
            this.carComboBox.FormattingEnabled = true;
            this.carComboBox.Items.AddRange(new object[] {
            "Limo",
            "Luxury",
            "Mid-Tier",
            "Green",
            "Economy"});
            this.carComboBox.Location = new System.Drawing.Point(121, 173);
            this.carComboBox.Name = "carComboBox";
            this.carComboBox.Size = new System.Drawing.Size(100, 21);
            this.carComboBox.TabIndex = 6;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(65, 275);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(103, 23);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate Cost";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // passengersErrorLabel
            // 
            this.passengersErrorLabel.AutoSize = true;
            this.passengersErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.passengersErrorLabel.Location = new System.Drawing.Point(70, 92);
            this.passengersErrorLabel.Name = "passengersErrorLabel";
            this.passengersErrorLabel.Size = new System.Drawing.Size(151, 13);
            this.passengersErrorLabel.TabIndex = 8;
            this.passengersErrorLabel.Text = "Invalid Number of Passengers.";
            this.passengersErrorLabel.Visible = false;
            // 
            // distanceErrorLabel
            // 
            this.distanceErrorLabel.AutoSize = true;
            this.distanceErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.distanceErrorLabel.Location = new System.Drawing.Point(135, 143);
            this.distanceErrorLabel.Name = "distanceErrorLabel";
            this.distanceErrorLabel.Size = new System.Drawing.Size(86, 13);
            this.distanceErrorLabel.TabIndex = 9;
            this.distanceErrorLabel.Text = "Invalid Distance.";
            this.distanceErrorLabel.Visible = false;
            // 
            // carTypeErrorLabel
            // 
            this.carTypeErrorLabel.AutoSize = true;
            this.carTypeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.carTypeErrorLabel.Location = new System.Drawing.Point(134, 197);
            this.carTypeErrorLabel.Name = "carTypeErrorLabel";
            this.carTypeErrorLabel.Size = new System.Drawing.Size(87, 13);
            this.carTypeErrorLabel.TabIndex = 10;
            this.carTypeErrorLabel.Text = "Invalid Car Type.";
            this.carTypeErrorLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 329);
            this.Controls.Add(this.carTypeErrorLabel);
            this.Controls.Add(this.distanceErrorLabel);
            this.Controls.Add(this.passengersErrorLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.carComboBox);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.passengersTextBox);
            this.Controls.Add(this.carLabel);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.passengersLabel);
            this.Controls.Add(this.resultsGroupBox);
            this.Name = "Form1";
            this.Text = "IRydeShare Cost Calculation";
            this.resultsGroupBox.ResumeLayout(false);
            this.resultsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.TextBox coCTextBox;
        private System.Windows.Forms.TextBox coBTextBox;
        private System.Windows.Forms.TextBox coATextBox;
        private System.Windows.Forms.Label coCLabel;
        private System.Windows.Forms.Label coBLabel;
        private System.Windows.Forms.Label coALabel;
        private System.Windows.Forms.Label passengersLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label carLabel;
        private System.Windows.Forms.TextBox passengersTextBox;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.ComboBox carComboBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label passengersErrorLabel;
        private System.Windows.Forms.Label distanceErrorLabel;
        private System.Windows.Forms.Label carTypeErrorLabel;
    }
}


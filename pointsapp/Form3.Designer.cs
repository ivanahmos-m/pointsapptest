namespace pointsapp
{
	partial class Form3
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
			this.PhoneNumberLabel = new System.Windows.Forms.Label();
			this.PhoneNumberTextbox = new System.Windows.Forms.TextBox();
			this.PointsToAddLabel = new System.Windows.Forms.Label();
			this.PointsToAddTextBox = new System.Windows.Forms.TextBox();
			this.AddPointsButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// PhoneNumberLabel
			// 
			this.PhoneNumberLabel.AutoSize = true;
			this.PhoneNumberLabel.Location = new System.Drawing.Point(54, 64);
			this.PhoneNumberLabel.Name = "PhoneNumberLabel";
			this.PhoneNumberLabel.Size = new System.Drawing.Size(78, 13);
			this.PhoneNumberLabel.TabIndex = 0;
			this.PhoneNumberLabel.Text = "Phone Number";
			// 
			// PhoneNumberTextbox
			// 
			this.PhoneNumberTextbox.Location = new System.Drawing.Point(57, 90);
			this.PhoneNumberTextbox.Name = "PhoneNumberTextbox";
			this.PhoneNumberTextbox.Size = new System.Drawing.Size(100, 20);
			this.PhoneNumberTextbox.TabIndex = 1;
			this.PhoneNumberTextbox.TextChanged += new System.EventHandler(this.PhoneNumberTextbox_TextChanged);
			// 
			// PointsToAddLabel
			// 
			this.PointsToAddLabel.AutoSize = true;
			this.PointsToAddLabel.Location = new System.Drawing.Point(54, 123);
			this.PointsToAddLabel.Name = "PointsToAddLabel";
			this.PointsToAddLabel.Size = new System.Drawing.Size(74, 13);
			this.PointsToAddLabel.TabIndex = 2;
			this.PointsToAddLabel.Text = "Points To Add";
			// 
			// PointsToAddTextBox
			// 
			this.PointsToAddTextBox.Location = new System.Drawing.Point(57, 148);
			this.PointsToAddTextBox.Name = "PointsToAddTextBox";
			this.PointsToAddTextBox.Size = new System.Drawing.Size(100, 20);
			this.PointsToAddTextBox.TabIndex = 3;
			this.PointsToAddTextBox.TextChanged += new System.EventHandler(this.PointsToAddTextBox_TextChanged);
			// 
			// AddPointsButton
			// 
			this.AddPointsButton.Location = new System.Drawing.Point(333, 309);
			this.AddPointsButton.Name = "AddPointsButton";
			this.AddPointsButton.Size = new System.Drawing.Size(96, 32);
			this.AddPointsButton.TabIndex = 4;
			this.AddPointsButton.Text = "Add Points";
			this.AddPointsButton.UseVisualStyleBackColor = true;
			this.AddPointsButton.Click += new System.EventHandler(this.AddPointsButton_Click);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.AddPointsButton);
			this.Controls.Add(this.PointsToAddTextBox);
			this.Controls.Add(this.PointsToAddLabel);
			this.Controls.Add(this.PhoneNumberTextbox);
			this.Controls.Add(this.PhoneNumberLabel);
			this.Name = "Form3";
			this.Text = "Form3";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label PhoneNumberLabel;
		private System.Windows.Forms.TextBox PhoneNumberTextbox;
		private System.Windows.Forms.Label PointsToAddLabel;
		private System.Windows.Forms.TextBox PointsToAddTextBox;
		private System.Windows.Forms.Button AddPointsButton;
	}
}
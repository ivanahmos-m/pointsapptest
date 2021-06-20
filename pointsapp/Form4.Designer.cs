namespace pointsapp
{
	partial class Form4
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
			this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
			this.PhoneNumberLabel = new System.Windows.Forms.Label();
			this.PointsYouHave = new System.Windows.Forms.Label();
			this.Points = new System.Windows.Forms.Label();
			this.MoneyText = new System.Windows.Forms.Label();
			this.Money = new System.Windows.Forms.Label();
			this.CheckOutButton = new System.Windows.Forms.Button();
			this.CheckUserButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// PhoneNumberTextBox
			// 
			this.PhoneNumberTextBox.Location = new System.Drawing.Point(306, 93);
			this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
			this.PhoneNumberTextBox.Size = new System.Drawing.Size(167, 20);
			this.PhoneNumberTextBox.TabIndex = 0;
			this.PhoneNumberTextBox.TextChanged += new System.EventHandler(this.PhoneNumberTextBox_TextChanged);
			// 
			// PhoneNumberLabel
			// 
			this.PhoneNumberLabel.AutoSize = true;
			this.PhoneNumberLabel.Location = new System.Drawing.Point(303, 50);
			this.PhoneNumberLabel.Name = "PhoneNumberLabel";
			this.PhoneNumberLabel.Size = new System.Drawing.Size(106, 13);
			this.PhoneNumberLabel.TabIndex = 1;
			this.PhoneNumberLabel.Text = "Enter Phone Number";
			// 
			// PointsYouHave
			// 
			this.PointsYouHave.AutoSize = true;
			this.PointsYouHave.Location = new System.Drawing.Point(306, 168);
			this.PointsYouHave.Name = "PointsYouHave";
			this.PointsYouHave.Size = new System.Drawing.Size(90, 13);
			this.PointsYouHave.TabIndex = 2;
			this.PointsYouHave.Text = "Points You Have:";
			// 
			// Points
			// 
			this.Points.AutoSize = true;
			this.Points.Location = new System.Drawing.Point(422, 167);
			this.Points.Name = "Points";
			this.Points.Size = new System.Drawing.Size(0, 13);
			this.Points.TabIndex = 3;
			// 
			// MoneyText
			// 
			this.MoneyText.AutoSize = true;
			this.MoneyText.Location = new System.Drawing.Point(303, 219);
			this.MoneyText.Name = "MoneyText";
			this.MoneyText.Size = new System.Drawing.Size(109, 13);
			this.MoneyText.TabIndex = 4;
			this.MoneyText.Text = "And that is in pounds:";
			this.MoneyText.Click += new System.EventHandler(this.MoneyText_Click);
			// 
			// Money
			// 
			this.Money.AutoSize = true;
			this.Money.Location = new System.Drawing.Point(422, 219);
			this.Money.Name = "Money";
			this.Money.Size = new System.Drawing.Size(0, 13);
			this.Money.TabIndex = 5;
			// 
			// CheckOutButton
			// 
			this.CheckOutButton.Location = new System.Drawing.Point(306, 294);
			this.CheckOutButton.Name = "CheckOutButton";
			this.CheckOutButton.Size = new System.Drawing.Size(167, 23);
			this.CheckOutButton.TabIndex = 6;
			this.CheckOutButton.Text = "Check Out!!!";
			this.CheckOutButton.UseVisualStyleBackColor = true;
			this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
			// 
			// CheckUserButton
			// 
			this.CheckUserButton.Location = new System.Drawing.Point(613, 89);
			this.CheckUserButton.Name = "CheckUserButton";
			this.CheckUserButton.Size = new System.Drawing.Size(75, 23);
			this.CheckUserButton.TabIndex = 7;
			this.CheckUserButton.Text = "Check User";
			this.CheckUserButton.UseVisualStyleBackColor = true;
			this.CheckUserButton.Click += new System.EventHandler(this.CheckUserButton_Click);
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.CheckUserButton);
			this.Controls.Add(this.CheckOutButton);
			this.Controls.Add(this.Money);
			this.Controls.Add(this.MoneyText);
			this.Controls.Add(this.Points);
			this.Controls.Add(this.PointsYouHave);
			this.Controls.Add(this.PhoneNumberLabel);
			this.Controls.Add(this.PhoneNumberTextBox);
			this.Name = "Form4";
			this.Text = "Form4";
			this.Load += new System.EventHandler(this.Form4_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox PhoneNumberTextBox;
		private System.Windows.Forms.Label PhoneNumberLabel;
		private System.Windows.Forms.Label PointsYouHave;
		private System.Windows.Forms.Label Points;
		private System.Windows.Forms.Label MoneyText;
		private System.Windows.Forms.Label Money;
		private System.Windows.Forms.Button CheckOutButton;
		private System.Windows.Forms.Button CheckUserButton;
	}
}
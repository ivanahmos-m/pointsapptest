namespace pointsapp
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
			this.AddPointsButton = new System.Windows.Forms.Button();
			this.Add = new System.Windows.Forms.Button();
			this.SaleButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// AddPointsButton
			// 
			this.AddPointsButton.Location = new System.Drawing.Point(62, 34);
			this.AddPointsButton.Name = "AddPointsButton";
			this.AddPointsButton.Size = new System.Drawing.Size(249, 129);
			this.AddPointsButton.TabIndex = 0;
			this.AddPointsButton.Text = "AddPoints";
			this.AddPointsButton.UseVisualStyleBackColor = true;
			this.AddPointsButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// Add
			// 
			this.Add.Location = new System.Drawing.Point(480, 34);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(249, 129);
			this.Add.TabIndex = 1;
			this.Add.Text = "Add User";
			this.Add.UseVisualStyleBackColor = true;
			this.Add.Click += new System.EventHandler(this.button2_Click);
			// 
			// SaleButton
			// 
			this.SaleButton.Location = new System.Drawing.Point(256, 228);
			this.SaleButton.Name = "SaleButton";
			this.SaleButton.Size = new System.Drawing.Size(249, 129);
			this.SaleButton.TabIndex = 2;
			this.SaleButton.Text = "SALE!";
			this.SaleButton.UseVisualStyleBackColor = true;
			this.SaleButton.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(810, 450);
			this.Controls.Add(this.SaleButton);
			this.Controls.Add(this.Add);
			this.Controls.Add(this.AddPointsButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button AddPointsButton;
		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.Button SaleButton;
	}
}


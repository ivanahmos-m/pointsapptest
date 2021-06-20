using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pointsapp
{
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void Form4_Load(object sender, EventArgs e)
		{

		}

		private void MoneyText_Click(object sender, EventArgs e)
		{

		}

		private void CheckOutButton_Click(object sender, EventArgs e)
		{
			UserData.reset(PhoneNumberTextBox.Text);
			Points.ResetText();
			Money.ResetText();
			PhoneNumberTextBox.ResetText();
		}

		private void CheckUserButton_Click(object sender, EventArgs e)
		{
			int points = UserData.CheckUser(PhoneNumberTextBox.Text);
			string pointstring = points.ToString();
			Points.Text = pointstring;
			int money = points / 100;
			Money.Text = money.ToString();
		}
	}
}

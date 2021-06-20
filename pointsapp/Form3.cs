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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void AddPointsButton_Click(object sender, EventArgs e)
		{
			UserData.AddPoints(PhoneNumberTextbox.Text, PointsToAddTextBox.Text );
			PhoneNumberTextbox.Clear();
			PointsToAddTextBox.Clear();
		}

		private void PhoneNumberTextbox_TextChanged(object sender, EventArgs e)
		{

		}

		private void PointsToAddTextBox_TextChanged(object sender, EventArgs e)
		{

		}
	}
}

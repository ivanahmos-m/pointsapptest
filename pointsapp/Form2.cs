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
	
	public partial class Form2 : Form
	{
		
		public Form2()
		{
			InitializeComponent();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			UserData.AddUser(NameTextBox.Text, PhoneNumberTextBox.Text);
			NameTextBox.Clear();
			PhoneNumberTextBox.Clear();



		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
		{

		}
	}
}

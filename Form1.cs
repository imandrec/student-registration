using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistration
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			//read data
			MethodsForGui methods = new MethodsForGui();

			methods.ReadDataFromFile("Students.csv");
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This is Student Registration App.");
		}

		private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddStudentForm addStudentForm = new AddStudentForm();

			addStudentForm.ShowDialog(this);
		}

		private void modifyStudentToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ModifyStudentForm modifyStudentForm = new ModifyStudentForm();
			modifyStudentForm.ShowDialog();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void menuToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}

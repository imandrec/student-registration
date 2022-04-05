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
	public partial class AddStudentForm : Form
	{
		public AddStudentForm()
		{
			InitializeComponent();

			CreateNewId();
		}

		private void CreateNewId()
		{
			Random random = new Random(DateTime.Now.Second);
			int id = random.Next(100000, 999999);
			StudentIdLabel.Text = id.ToString();
		}

		bool validate()
		{
			bool istextBoxEmpty = true;
			bool isRadioButtonEmpty = true;
			if (string.IsNullOrEmpty(FirstNameTextBox.Text) == false ||
				string.IsNullOrEmpty(LastNameTextBox.Text) == false ||
				string.IsNullOrEmpty(EmailTextBox.Text) == false && EmailTextBox.Text.Contains("@") == true)
			{
				istextBoxEmpty = false;
			}


			foreach (Control control in this.Controls)
			{
				if (control is RadioButton)
				{
					RadioButton btn = (RadioButton)control;
					if (btn.Checked == true)
					{
						isRadioButtonEmpty = false;
					}
				}
			}

			if (istextBoxEmpty == false && isRadioButtonEmpty == false && MajorCombobox.SelectedIndex != -1)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private void OkButton_Click(object sender, EventArgs e)
		{
			if (validate() == false)
			{
				MessageBox.Show("Some fields may missing");
			}
			else
			{
				MessageBox.Show("Okay");
			}
		}

		private void ClearButton_Click(object sender, EventArgs e)
		{
			FirstNameTextBox.Clear();
			LastNameTextBox.Clear();
			EmailTextBox.Clear();
			MajorCombobox.SelectedIndex = -1;

			foreach (Control control in this.Controls)
			{
				if (control is RadioButton)
				{
					RadioButton btn = (RadioButton)control;
					btn.Checked = false;
				}
			}
		}

		private void AddStudentForm_Load(object sender, EventArgs e)
		{

		}
	}
}

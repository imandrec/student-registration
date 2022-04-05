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
	public partial class ModifyStudentForm : Form
	{
		List<StudentAttributes> students = new List<StudentAttributes>();
		public ModifyStudentForm()
		{
			InitializeComponent();

			MethodsForGui methods = new MethodsForGui();
			students = methods.ReadDataFromFile("Students.csv");
		}

		private void ModifyStudentForm_Load(object sender, EventArgs e)
		{
		}

		private void SearchIdButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(SByIdTextBox.Text) == false)
			{
				for (int i = 0; i < students.Count; i++)
				{
					if (students[i].StudentId == Convert.ToInt32(SByIdTextBox.Text))
					{
						LoadDataToForm(students[i]);
						return;
					}
				}
			}
			else
			{
				MessageBox.Show("Invlaid Id");
			}

		}

		private void SearchEmailButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(SByEmailTextBox.Text) == false)
			{
				for (int i = 0; i < students.Count; i++)
				{
					if (i != 0)
					{
						if (students[i].Email.ToString().Trim() == SByEmailTextBox.Text)
						{
							LoadDataToForm(students[i]);
							return;
						}
					}
				}
			}
			else
			{
				MessageBox.Show("Invalid Email");
			}
		}

		private void LoadDataToForm(StudentAttributes student)
		{
			StudentIdLabel.Text = student.StudentId.ToString();
			FirstNameTextBox.Text = student.FirstName;
			LastNameTextBox.Text = student.LastName;
			EmailTextBox.Text = student.Email;

			string temp = student.Year.Trim();

			if (temp.Equals("Freshman"))
			{
				FreshmanRadioButton.Checked = true;
			}
			else if (temp.Equals("Sophomore"))
			{
				SophomoreRadioButton.Checked = true;
			}
			else if (temp.Equals("Junior"))
			{
				JuniorRadioButton.Checked = true;
			}
			else if (temp.Equals("Senior"))
			{
				SeniorRadioButton.Checked = true;
			}


			if (student.Major.ToString().ToLower().Trim() == "None".ToLower())
			{
				MajorCombobox.SelectedIndex = 0;
			}

			else if (student.Major.ToString().ToLower().Trim() == "Math".ToLower())
			{
				MajorCombobox.SelectedIndex = 1;
			}
			else if (student.Major.ToString().ToLower().Trim() == "Computer Science".ToLower())
			{
				MajorCombobox.SelectedIndex = 2;
			}
			else if (student.Major.ToString().ToLower().Trim() == "Management Information System".ToLower())
			{
				MajorCombobox.SelectedIndex = 3;
			}
			else if (student.Major.ToString().ToLower().Trim() == "Cyber Security".ToLower())
			{
				MajorCombobox.SelectedIndex = 4;
			}

		}

		private void ClearButton_Click(object sender, EventArgs e)
		{

		}
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistration
{
	public class MethodsForGui
	{
		public List<StudentAttributes> ReadDataFromFile(string fileName)
		{
			if (File.Exists("Students.csv") == false)
			{
				MessageBox.Show("Student.csv file doesn't exists.");
			}

			else
			{
				//Here data from file will be stored
				List<StudentAttributes> students = new List<StudentAttributes>();

				//all lines of file are read
				string[] csvRows = File.ReadAllLines(fileName);

				//storing lines to stock variable
				for (int i = 0; i < csvRows.Length; i++)
				{
					//Temp Stock variable to get data from csv
					//and stores to Stocks variable
					StudentAttributes student = new StudentAttributes();

					//spliting rows through comma delimiter
					string[] row = null;
					if (csvRows[i] != null)
					{
						row = csvRows[i].Split(',');
					}

					//Handling Header Row
					if (i == 0)
					{
						student.Headers = row;
						students.Add(student);
						continue;
					}

					student.StudentId = Convert.ToInt32(row[0].ToString());

					student.FirstName = row[1].ToString();

					student.LastName = row[2].ToString();

					student.Year = row[3].ToString();

					student.Major = row[4].ToString();

					student.Email = row[5].ToString();

					students.Add(student);
				}

				return students;
			}

			return null;
		}
	}
}

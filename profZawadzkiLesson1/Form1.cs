using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace profZawadzkiLesson1
{
	public partial class Form1 : Form
	{

		public List<Employee> StudentsList = new List<Employee>();
		public List<Employee> SearchList = new List<Employee>();
		public Form1()
		{
			InitializeComponent();
			dgvStudentsList.ColumnCount = 5;
			dgvStudentsList.RowCount = 1;
			dgvStudentsList.Columns[0].HeaderText = "lp.";
			dgvStudentsList.Columns[0].Width = 50;
			dgvStudentsList.Columns[1].HeaderText = "Name";
			dgvStudentsList.Columns[2].HeaderText = "Last Name";
			dgvStudentsList.Columns[3].HeaderText = "Employee Id";
			dgvStudentsList.Columns[4].HeaderText = "Deparetment";
		}

		private void btnSumbit_Click(object sender, EventArgs e)
		{
			string name = txtBoxName.Text;
			string lastName = txtBoxLastName.Text;
			int employeeId;
			string department = DepertmentTextBox.Text;
			if (string.IsNullOrEmpty(name))
			{
				MessageBox.Show("Name is required.");
				return;
			}

			if (string.IsNullOrEmpty(lastName))
			{
				MessageBox.Show("Last name is required.");
				return;
			}
			if (!int.TryParse(txtBoxStudentsId.Text, out employeeId))
			{
				MessageBox.Show("ID is required.");
				return;
			}
			if (string.IsNullOrEmpty(department))
			{
				MessageBox.Show("Department name is required.");
				return;
			}


			if (SearchBox.Text == "" || dgvStudentsList.Rows.Count != 1)
			{
				StudentsList.Add(new Employee(name, lastName, employeeId, department));
			}
			else if (SearchBox.Text.Length > 0 && dgvStudentsList.Rows.Count == 1)
			{
				int searcherdID = Int32.Parse((dgvStudentsList.Rows[0].Cells[3].Value).ToString());
				var employeeToChange = StudentsList.FirstOrDefault(x => x.employeeID == searcherdID);
				employeeToChange.employeeID = employeeId;
				employeeToChange.Name = name;
				employeeToChange.LastName = lastName;
				employeeToChange.Department = department;
			}

			ClearTxtControls();
			ShowEmployeesFromList(StudentsList);

		}
		private void btnShowStudents_Click(object sender, EventArgs e)
		{
			ShowEmployeesFromList(StudentsList);
		}
		void ClearTxtControls()
		{
			txtBoxName.Text = string.Empty;
			txtBoxLastName.Text = string.Empty;
			txtBoxStudentsId.Text = string.Empty;
			DepertmentTextBox.Text = string.Empty;
			SearchBox.Text = string.Empty;
		}

		private void SearchBox_TextChanged(object sender, EventArgs e)
		{
			SearchList.Clear();
			SearchList = StudentsList.Where(x => x.employeeID.ToString().Contains(SearchBox.Text.ToLower())).ToList();
			ShowEmployeesFromList(SearchList);
		}
		private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}


		private void btnClearStudentsList_Click(object sender, EventArgs e)
		{
			StudentsList.Clear();
			dgvStudentsList.Rows.Clear();
		}
		void ShowEmployeesFromList(List<Employee> employeesList)
		{
			dgvStudentsList.Rows.Clear();
			int currentLpNumber = 1;
			if (employeesList != null)
			{
				foreach (Employee student in employeesList)
				{
					string[] tab = student.ToString().Split(' ');
					string[] rowItems = new string[] { currentLpNumber.ToString() }.Concat(tab).ToArray();
					dgvStudentsList.Rows.Add(rowItems);
					currentLpNumber++;
				}
			}
		}

	}
}
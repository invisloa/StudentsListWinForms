using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace profZawadzkiLesson1
{
	public partial class Form1 : Form
	{
		string name;
		string lastName;
		int employeeId;
		string department;

		public List<Employee> EmployeesList = new List<Employee>();
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


			if (CanSaveCurrentInputData())
			{
				if ((EmployeesList.FirstOrDefault(x => x.employeeID == employeeId)) == null)
				{
					EmployeesList.Add(new Employee(name, lastName, employeeId, department));
					ClearTxtControls();
					ShowEmployeesFromList(EmployeesList);
					MessageBox.Show($"Dodano pracownika: {employeeId}");
				}
				else
				{
					MessageBox.Show($"Pracownik o nr ID: {employeeId} już istnieje");

				}

			}
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
			SearchList = EmployeesList.Where(x => x.employeeID.ToString().Contains(SearchBox.Text.ToLower())).ToList();
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
			EmployeesList.Clear();
			dgvStudentsList.Rows.Clear();
			ClearTxtControls();
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
		void UpdateEmployeeData()
		{
			if (SearchList.Count == 1 && SearchBox.Text != "")
			{
				if (CanSaveCurrentInputData())
				{
					int searchedEmployeeID = Int32.Parse((dgvStudentsList.Rows[0].Cells[3].Value).ToString());
					var employeeToChange = EmployeesList.FirstOrDefault(x => x.employeeID == searchedEmployeeID);
					employeeToChange.employeeID = employeeId;
					employeeToChange.Name = name;
					employeeToChange.LastName = lastName;
					employeeToChange.Department = department;
					MessageBox.Show($"Aktualizacja studenta o nr ID: {employeeId}");
				}
			}
			else
			{
				MessageBox.Show("Niepoprawne dane do aktualizacji");
				ClearTxtControls();

			}
		}
		bool CanSaveCurrentInputData()
		{
			name = txtBoxName.Text;
			lastName = txtBoxLastName.Text;
			department = DepertmentTextBox.Text;
			if (string.IsNullOrEmpty(txtBoxName.Text))
			{
				MessageBox.Show("Podaj poprawne imię");
				return false;
			}

			if (string.IsNullOrEmpty(txtBoxLastName.Text))
			{
				MessageBox.Show("Podaj poprawne nazwisko");
				return false;
			}
			if (!int.TryParse(txtBoxStudentsId.Text, out employeeId))
			{
				MessageBox.Show("Podaj poprawne ID");
				return false;
			}
			if (string.IsNullOrEmpty(DepertmentTextBox.Text))
			{
				MessageBox.Show("Podaj poprawny departament");
				return false;
			}
			ClearTxtControls();
			return true;

		}

		private void button2_Click(object sender, EventArgs e)
		{
			UpdateEmployeeData();
			ShowEmployeesFromList(EmployeesList);

		}

		private void button3_Click(object sender, EventArgs e)
		{
			ShowEmployeesFromList(EmployeesList);

		}
	}
}
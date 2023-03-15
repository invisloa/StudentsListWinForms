using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace profZawadzkiLesson1
{
	public partial class Form1 : Form
	{
		StudentsListGenerator listGenerator = new StudentsListGenerator();
		public List<Student> StudentsList = new List<Student>();
		int columnsHeaderWidth = 200;
		public Form1()
		{
			InitializeComponent();
			StudentsList = listGenerator.MakeStudentsList();

		}

		private void btnSumbit_Click(object sender, EventArgs e)
		{
			string name = txtBoxName.Text;
			string lastName = txtBoxLastName.Text;
			int studenstId;
			if (!int.TryParse(txtBoxStudentsId.Text, out studenstId))
			{
				MessageBox.Show("BAD DATA!!!");
				return;
			}
			StudentsList.Add(new Student(name, lastName, studenstId));
			ClearTxtControls();
		}

		private void btnShowStudents_Click(object sender, EventArgs e)
		{
			dgvStudentsList.Rows.Clear();
			int currentLpNumber = 1;
			foreach (Student student in StudentsList)
			{
				string[] tab = student.ToString().Split(' ');
				object[] rowItems = new object[] { currentLpNumber }.Concat(tab).ToArray();
				dgvStudentsList.Rows.Add(rowItems);
				currentLpNumber++;
			}
		}
		void ClearTxtControls()
		{
			txtBoxName.Text = string.Empty;
			txtBoxLastName.Text = string.Empty;
			txtBoxStudentsId.Text = string.Empty;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
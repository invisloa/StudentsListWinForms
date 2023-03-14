namespace profZawadzkiLesson1
{
	public partial class Form1 : Form
	{
		public List<Student> StudentsList = new List<Student>();
		int columnsHeaderWidth = 200;
		public Form1()
		{
			InitializeComponent();
			dgvStudentsList.ColumnCount = 10;
			dgvStudentsList.RowCount = 10;
			dgvStudentsList.Columns[0].HeaderText = "lp.";
			dgvStudentsList.Columns[0].Width = 50;
			dgvStudentsList.Columns[1].HeaderText = "Name";
			dgvStudentsList.Columns[1].Width = columnsHeaderWidth;
			dgvStudentsList.Columns[2].HeaderText = "Last Name";
			dgvStudentsList.Columns[2].Width = columnsHeaderWidth;
			dgvStudentsList.Columns[3].HeaderText = "Students Id";
			dgvStudentsList.Columns[3].Width = columnsHeaderWidth;

		}

		private void btnSumbit_Click(object sender, EventArgs e)
		{
			string name = txtBoxName.Text;
			string lastName = txtBoxLastName.Text;
			int studenstId;
			if (!int.TryParse(txtBoxStudentsId.Text, out studenstId))
			{ MessageBox.Show("BAD DATA!!!"); }
			StudentsList.Add(new Student(name, lastName, studenstId));
			ClearTxtControls();



		}

		private void btnShowStudents_Click(object sender, EventArgs e)
		{
			int currentLpNumber = 1;
			foreach (Student student in StudentsList)
			{
				string[] tab = student.ToString().Split(' ');
				dgvStudentsList.Rows.Add(tab);
			}
		}
		void ClearTxtControls()
		{
			txtBoxName.Text = string.Empty;
			txtBoxLastName.Text = string.Empty;
			txtBoxStudentsId.Text = string.Empty;
		}
	}
}
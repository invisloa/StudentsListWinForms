using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;
using System.Collections.Generic;

namespace profZawadzkiLesson1
{
    public partial class Form1 : Form
    {

        StudentsListGenerator listGenerator = new StudentsListGenerator();
        public List<Student> StudentsList = new List<Student>();
        public List<Student> SearchList = new List<Student>();
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
            if (!int.TryParse(txtBoxStudentsId.Text, out studenstId))
            {
                MessageBox.Show("ID is required.");
                return;
            }



            StudentsList.Add(new Student(name, lastName, studenstId));
            ClearTxtControls();
        }
        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            ShowStudentsFromList(StudentsList);
        }
        void ClearTxtControls()
        {
            txtBoxName.Text = string.Empty;
            txtBoxLastName.Text = string.Empty;
            txtBoxStudentsId.Text = string.Empty;
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchList.Clear();
            SearchList = StudentsList.Where(x => x.Name.ToLower().Contains(SearchBox.Text.ToLower())
                                            || x.LastName.ToLower().Contains(SearchBox.Text.ToLower())
                                            || x.StudentId.ToString().Contains(SearchBox.Text.ToLower())).ToList();
            ShowStudentsFromList(SearchList);
        }

        private void btnClearStudentsList_Click(object sender, EventArgs e)
        {
            StudentsList.Clear();
            dgvStudentsList.Rows.Clear();
        }
        void ShowStudentsFromList(List<Student> studentsList)
        {
            dgvStudentsList.Rows.Clear();
            int currentLpNumber = 1;
            if (studentsList != null)
            {
                foreach (Student student in studentsList)
                {
                    string[] tab = student.ToString().Split(' ');
                    object[] rowItems = new object[] { currentLpNumber }.Concat(tab).ToArray();
                    dgvStudentsList.Rows.Add(rowItems);
                    currentLpNumber++;
                }
            }
        }

    }
}
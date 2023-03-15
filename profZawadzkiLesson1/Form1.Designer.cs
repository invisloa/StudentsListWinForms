namespace profZawadzkiLesson1
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			txtBoxName = new TextBox();
			txtBoxLastName = new TextBox();
			txtBoxStudentsId = new TextBox();
			NameLabel = new Label();
			LastNameLabel = new Label();
			StudentsNoLabel = new Label();
			btnSumbit = new Button();
			btnShowStudents = new Button();
			dgvStudentsList = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgvStudentsList).BeginInit();
			SuspendLayout();
			// 
			// txtBoxName
			// 
			txtBoxName.Location = new Point(146, 52);
			txtBoxName.Margin = new Padding(5);
			txtBoxName.MaxLength = 16;
			txtBoxName.Name = "txtBoxName";
			txtBoxName.Size = new Size(285, 32);
			txtBoxName.TabIndex = 0;
			// 
			// txtBoxLastName
			// 
			txtBoxLastName.Location = new Point(146, 137);
			txtBoxLastName.Margin = new Padding(5);
			txtBoxLastName.MaxLength = 16;
			txtBoxLastName.Name = "txtBoxLastName";
			txtBoxLastName.Size = new Size(285, 32);
			txtBoxLastName.TabIndex = 1;
			// 
			// txtBoxStudentsId
			// 
			txtBoxStudentsId.Location = new Point(146, 223);
			txtBoxStudentsId.Margin = new Padding(5);
			txtBoxStudentsId.MaxLength = 6;
			txtBoxStudentsId.Name = "txtBoxStudentsId";
			txtBoxStudentsId.Size = new Size(155, 32);
			txtBoxStudentsId.TabIndex = 2;
			// 
			// NameLabel
			// 
			NameLabel.AutoSize = true;
			NameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			NameLabel.Location = new Point(25, 59);
			NameLabel.Margin = new Padding(5, 0, 5, 0);
			NameLabel.Name = "NameLabel";
			NameLabel.Size = new Size(62, 25);
			NameLabel.TabIndex = 3;
			NameLabel.Text = "Name";
			// 
			// LastNameLabel
			// 
			LastNameLabel.AutoSize = true;
			LastNameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			LastNameLabel.Location = new Point(25, 144);
			LastNameLabel.Margin = new Padding(5, 0, 5, 0);
			LastNameLabel.Name = "LastNameLabel";
			LastNameLabel.Size = new Size(97, 25);
			LastNameLabel.TabIndex = 4;
			LastNameLabel.Text = "Last name";
			// 
			// StudentsNoLabel
			// 
			StudentsNoLabel.AutoSize = true;
			StudentsNoLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			StudentsNoLabel.Location = new Point(25, 230);
			StudentsNoLabel.Margin = new Padding(5, 0, 5, 0);
			StudentsNoLabel.Name = "StudentsNoLabel";
			StudentsNoLabel.Size = new Size(111, 25);
			StudentsNoLabel.TabIndex = 5;
			StudentsNoLabel.Text = "Students no";
			// 
			// btnSumbit
			// 
			btnSumbit.Location = new Point(146, 302);
			btnSumbit.Name = "btnSumbit";
			btnSumbit.Size = new Size(123, 39);
			btnSumbit.TabIndex = 6;
			btnSumbit.Text = "Submit";
			btnSumbit.UseVisualStyleBackColor = true;
			btnSumbit.Click += btnSumbit_Click;
			// 
			// btnShowStudents
			// 
			btnShowStudents.Location = new Point(125, 366);
			btnShowStudents.Name = "btnShowStudents";
			btnShowStudents.Size = new Size(176, 57);
			btnShowStudents.TabIndex = 7;
			btnShowStudents.Text = "Show students";
			btnShowStudents.UseVisualStyleBackColor = true;
			btnShowStudents.Click += btnShowStudents_Click;
			// 
			// dgvStudentsList
			// 
			dgvStudentsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvStudentsList.Location = new Point(518, 129);
			dgvStudentsList.Name = "dgvStudentsList";
			dgvStudentsList.RowTemplate.Height = 25;
			dgvStudentsList.Size = new Size(739, 441);
			dgvStudentsList.TabIndex = 8;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(11F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1269, 582);
			Controls.Add(dgvStudentsList);
			Controls.Add(btnShowStudents);
			Controls.Add(btnSumbit);
			Controls.Add(StudentsNoLabel);
			Controls.Add(LastNameLabel);
			Controls.Add(NameLabel);
			Controls.Add(txtBoxStudentsId);
			Controls.Add(txtBoxLastName);
			Controls.Add(txtBoxName);
			Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(5);
			Name = "Form1";
			Text = "Students library";
			((System.ComponentModel.ISupportInitialize)dgvStudentsList).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtBoxName;
		private TextBox txtBoxLastName;
		private TextBox txtBoxStudentsId;
		private Label NameLabel;
		private Label LastNameLabel;
		private Label StudentsNoLabel;
		private Button btnSumbit;
		private Button btnShowStudents;
		private DataGridView dgvStudentsList;
	}
}
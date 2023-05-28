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
			btnClearStudentsList = new Button();
			dgvEmployeeList = new DataGridView();
			btnSumbit = new Button();
			panel1 = new Panel();
			label1 = new Label();
			SearchBox = new TextBox();
			button2 = new Button();
			button3 = new Button();
			label2 = new Label();
			Department = new TextBox();
			button4 = new Button();
			((System.ComponentModel.ISupportInitialize)dgvEmployeeList).BeginInit();
			SuspendLayout();
			// 
			// txtBoxName
			// 
			txtBoxName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			txtBoxName.Location = new Point(56, 23);
			txtBoxName.Margin = new Padding(5);
			txtBoxName.MaximumSize = new Size(190, 25);
			txtBoxName.MaxLength = 16;
			txtBoxName.Name = "txtBoxName";
			txtBoxName.Size = new Size(190, 25);
			txtBoxName.TabIndex = 0;
			// 
			// txtBoxLastName
			// 
			txtBoxLastName.Anchor = AnchorStyles.Top;
			txtBoxLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			txtBoxLastName.Location = new Point(333, 23);
			txtBoxLastName.Margin = new Padding(5);
			txtBoxLastName.MaximumSize = new Size(190, 25);
			txtBoxLastName.MaxLength = 16;
			txtBoxLastName.Name = "txtBoxLastName";
			txtBoxLastName.Size = new Size(190, 25);
			txtBoxLastName.TabIndex = 1;
			// 
			// txtBoxStudentsId
			// 
			txtBoxStudentsId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			txtBoxStudentsId.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			txtBoxStudentsId.Location = new Point(620, 23);
			txtBoxStudentsId.Margin = new Padding(5);
			txtBoxStudentsId.MaximumSize = new Size(87, 25);
			txtBoxStudentsId.MaxLength = 6;
			txtBoxStudentsId.Name = "txtBoxStudentsId";
			txtBoxStudentsId.Size = new Size(87, 25);
			txtBoxStudentsId.TabIndex = 2;
			txtBoxStudentsId.KeyPress += SearchBox_KeyPress;
			// 
			// NameLabel
			// 
			NameLabel.AutoSize = true;
			NameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			NameLabel.Location = new Point(3, 26);
			NameLabel.Margin = new Padding(5, 0, 5, 0);
			NameLabel.MaximumSize = new Size(43, 17);
			NameLabel.Name = "NameLabel";
			NameLabel.Size = new Size(43, 17);
			NameLabel.TabIndex = 3;
			NameLabel.Text = "Name";
			// 
			// LastNameLabel
			// 
			LastNameLabel.Anchor = AnchorStyles.Top;
			LastNameLabel.AutoSize = true;
			LastNameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			LastNameLabel.Location = new Point(256, 26);
			LastNameLabel.Margin = new Padding(5, 0, 5, 0);
			LastNameLabel.MaximumSize = new Size(67, 17);
			LastNameLabel.Name = "LastNameLabel";
			LastNameLabel.Size = new Size(67, 17);
			LastNameLabel.TabIndex = 4;
			LastNameLabel.Text = "Last name";
			// 
			// StudentsNoLabel
			// 
			StudentsNoLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			StudentsNoLabel.AutoSize = true;
			StudentsNoLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			StudentsNoLabel.Location = new Point(533, 26);
			StudentsNoLabel.Margin = new Padding(5, 0, 5, 0);
			StudentsNoLabel.Name = "StudentsNoLabel";
			StudentsNoLabel.Size = new Size(81, 17);
			StudentsNoLabel.TabIndex = 5;
			StudentsNoLabel.Text = "Employee ID";
			// 
			// btnClearStudentsList
			// 
			btnClearStudentsList.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			btnClearStudentsList.Location = new Point(42, 110);
			btnClearStudentsList.MaximumSize = new Size(105, 25);
			btnClearStudentsList.MinimumSize = new Size(105, 25);
			btnClearStudentsList.Name = "btnClearStudentsList";
			btnClearStudentsList.Size = new Size(105, 25);
			btnClearStudentsList.TabIndex = 9;
			btnClearStudentsList.Text = "Clear list";
			btnClearStudentsList.UseVisualStyleBackColor = true;
			btnClearStudentsList.Click += btnClearStudentsList_Click;
			// 
			// dgvEmployeeList
			// 
			dgvEmployeeList.AllowUserToAddRows = false;
			dgvEmployeeList.AllowUserToDeleteRows = false;
			dgvEmployeeList.AllowUserToResizeColumns = false;
			dgvEmployeeList.AllowUserToResizeRows = false;
			dgvEmployeeList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvEmployeeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvEmployeeList.BackgroundColor = SystemColors.ButtonHighlight;
			dgvEmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvEmployeeList.GridColor = SystemColors.ActiveCaptionText;
			dgvEmployeeList.Location = new Point(12, 141);
			dgvEmployeeList.Name = "dgvEmployeeList";
			dgvEmployeeList.ReadOnly = true;
			dgvEmployeeList.RowTemplate.Height = 25;
			dgvEmployeeList.Size = new Size(820, 308);
			dgvEmployeeList.TabIndex = 8;
			// 
			// btnSumbit
			// 
			btnSumbit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnSumbit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			btnSumbit.Location = new Point(664, 110);
			btnSumbit.MaximumSize = new Size(105, 25);
			btnSumbit.Name = "btnSumbit";
			btnSumbit.Size = new Size(105, 25);
			btnSumbit.TabIndex = 6;
			btnSumbit.Text = "Submit/Update";
			btnSumbit.UseVisualStyleBackColor = true;
			btnSumbit.Click += btnSumbit_Click;
			// 
			// panel1
			// 
			panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			panel1.Location = new Point(114, 266);
			panel1.Name = "panel1";
			panel1.Size = new Size(774, 333);
			panel1.TabIndex = 10;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(169, 113);
			label1.Name = "label1";
			label1.Size = new Size(63, 17);
			label1.TabIndex = 11;
			label1.Text = "Search ID";
			// 
			// SearchBox
			// 
			SearchBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			SearchBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			SearchBox.Location = new Point(280, 110);
			SearchBox.MaximumSize = new Size(190, 25);
			SearchBox.MinimumSize = new Size(190, 25);
			SearchBox.Name = "SearchBox";
			SearchBox.PlaceholderText = "Type search criteria...";
			SearchBox.Size = new Size(190, 25);
			SearchBox.TabIndex = 12;
			SearchBox.TextChanged += SearchBox_TextChanged;
			SearchBox.KeyPress += SearchBox_KeyPress;
			// 
			// button2
			// 
			button2.Location = new Point(56, 64);
			button2.Name = "button2";
			button2.Size = new Size(147, 37);
			button2.TabIndex = 13;
			button2.Text = "Serialize";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Location = new Point(331, 64);
			button3.Name = "button3";
			button3.Size = new Size(165, 37);
			button3.TabIndex = 14;
			button3.Text = "Deserialize";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(502, 70);
			label2.Name = "label2";
			label2.Size = new Size(112, 25);
			label2.TabIndex = 15;
			label2.Text = "Department";
			// 
			// Department
			// 
			Department.Location = new Point(620, 67);
			Department.Name = "Department";
			Department.Size = new Size(212, 32);
			Department.TabIndex = 16;
			// 
			// button4
			// 
			button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			button4.Location = new Point(545, 110);
			button4.Name = "button4";
			button4.Size = new Size(113, 23);
			button4.TabIndex = 17;
			button4.Text = "Show employees";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(11F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Silver;
			ClientSize = new Size(844, 461);
			Controls.Add(button4);
			Controls.Add(Department);
			Controls.Add(label2);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(SearchBox);
			Controls.Add(label1);
			Controls.Add(dgvEmployeeList);
			Controls.Add(btnSumbit);
			Controls.Add(btnClearStudentsList);
			Controls.Add(StudentsNoLabel);
			Controls.Add(LastNameLabel);
			Controls.Add(NameLabel);
			Controls.Add(txtBoxStudentsId);
			Controls.Add(txtBoxLastName);
			Controls.Add(txtBoxName);
			Controls.Add(panel1);
			Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(5);
			MinimumSize = new Size(860, 500);
			Name = "Form1";
			Text = "Students library";
			((System.ComponentModel.ISupportInitialize)dgvEmployeeList).EndInit();
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
		private DataGridView dgvEmployeeList;
		private Button btnClearStudentsList;
		private Panel panel1;
		private Label label1;
		private TextBox SearchBox;
		private Button button1;
		private Button button2;
		private Button button3;
		private Label label2;
		private TextBox Department;
		private Button button4;
	}
}
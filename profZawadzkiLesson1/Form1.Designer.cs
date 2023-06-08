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
			dgvStudentsList = new DataGridView();
			btnSumbit = new Button();
			panel1 = new Panel();
			label1 = new Label();
			SearchBox = new TextBox();
			label2 = new Label();
			DepertmentTextBox = new TextBox();
			btnAktualizuj = new Button();
			btnShowAll = new Button();
			((System.ComponentModel.ISupportInitialize)dgvStudentsList).BeginInit();
			SuspendLayout();
			// 
			// txtBoxName
			// 
			txtBoxName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			txtBoxName.Location = new Point(86, 17);
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
			txtBoxLastName.Location = new Point(86, 59);
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
			txtBoxStudentsId.Location = new Point(461, 17);
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
			NameLabel.Location = new Point(9, 17);
			NameLabel.Margin = new Padding(5, 0, 5, 0);
			NameLabel.MaximumSize = new Size(43, 17);
			NameLabel.Name = "NameLabel";
			NameLabel.Size = new Size(35, 17);
			NameLabel.TabIndex = 3;
			NameLabel.Text = "Imię:";
			// 
			// LastNameLabel
			// 
			LastNameLabel.Anchor = AnchorStyles.Top;
			LastNameLabel.AutoSize = true;
			LastNameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			LastNameLabel.Location = new Point(9, 59);
			LastNameLabel.Margin = new Padding(5, 0, 5, 0);
			LastNameLabel.MaximumSize = new Size(67, 17);
			LastNameLabel.Name = "LastNameLabel";
			LastNameLabel.Size = new Size(66, 17);
			LastNameLabel.TabIndex = 4;
			LastNameLabel.Text = "Nazwisko:";
			// 
			// StudentsNoLabel
			// 
			StudentsNoLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			StudentsNoLabel.AutoSize = true;
			StudentsNoLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			StudentsNoLabel.Location = new Point(428, 20);
			StudentsNoLabel.Margin = new Padding(5, 0, 5, 0);
			StudentsNoLabel.Name = "StudentsNoLabel";
			StudentsNoLabel.Size = new Size(23, 17);
			StudentsNoLabel.TabIndex = 5;
			StudentsNoLabel.Text = "ID:";
			// 
			// btnClearStudentsList
			// 
			btnClearStudentsList.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			btnClearStudentsList.Location = new Point(640, 110);
			btnClearStudentsList.MaximumSize = new Size(155, 25);
			btnClearStudentsList.MinimumSize = new Size(105, 25);
			btnClearStudentsList.Name = "btnClearStudentsList";
			btnClearStudentsList.Size = new Size(155, 25);
			btnClearStudentsList.TabIndex = 9;
			btnClearStudentsList.Text = "Wyczyść wszystkich";
			btnClearStudentsList.UseVisualStyleBackColor = true;
			btnClearStudentsList.Click += btnClearStudentsList_Click;
			// 
			// dgvStudentsList
			// 
			dgvStudentsList.AllowUserToAddRows = false;
			dgvStudentsList.AllowUserToDeleteRows = false;
			dgvStudentsList.AllowUserToResizeColumns = false;
			dgvStudentsList.AllowUserToResizeRows = false;
			dgvStudentsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvStudentsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvStudentsList.BackgroundColor = SystemColors.ButtonHighlight;
			dgvStudentsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvStudentsList.GridColor = SystemColors.ActiveCaptionText;
			dgvStudentsList.Location = new Point(12, 141);
			dgvStudentsList.Name = "dgvStudentsList";
			dgvStudentsList.ReadOnly = true;
			dgvStudentsList.RowTemplate.Height = 25;
			dgvStudentsList.Size = new Size(820, 308);
			dgvStudentsList.TabIndex = 8;
			// 
			// btnSumbit
			// 
			btnSumbit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnSumbit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			btnSumbit.Location = new Point(47, 110);
			btnSumbit.MaximumSize = new Size(105, 25);
			btnSumbit.Name = "btnSumbit";
			btnSumbit.Size = new Size(105, 25);
			btnSumbit.TabIndex = 6;
			btnSumbit.Text = "Dodaj pracownika";
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
			label1.Location = new Point(674, 17);
			label1.Name = "label1";
			label1.Size = new Size(44, 17);
			label1.TabIndex = 11;
			label1.Text = "Szukaj";
			// 
			// SearchBox
			// 
			SearchBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			SearchBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			SearchBox.Location = new Point(605, 51);
			SearchBox.MaximumSize = new Size(190, 25);
			SearchBox.MinimumSize = new Size(190, 25);
			SearchBox.Name = "SearchBox";
			SearchBox.PlaceholderText = "Podaj kryteria szukania...";
			SearchBox.Size = new Size(190, 25);
			SearchBox.TabIndex = 12;
			SearchBox.TextChanged += SearchBox_TextChanged;
			SearchBox.KeyPress += SearchBox_KeyPress;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(364, 59);
			label2.Margin = new Padding(5, 0, 5, 0);
			label2.Name = "label2";
			label2.Size = new Size(87, 17);
			label2.TabIndex = 14;
			label2.Text = "Departament:";
			// 
			// DepertmentTextBox
			// 
			DepertmentTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			DepertmentTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			DepertmentTextBox.Location = new Point(461, 56);
			DepertmentTextBox.Margin = new Padding(5);
			DepertmentTextBox.MaximumSize = new Size(87, 25);
			DepertmentTextBox.MaxLength = 6;
			DepertmentTextBox.Name = "DepertmentTextBox";
			DepertmentTextBox.Size = new Size(87, 25);
			DepertmentTextBox.TabIndex = 13;
			// 
			// btnAktualizuj
			// 
			btnAktualizuj.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnAktualizuj.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			btnAktualizuj.Location = new Point(187, 110);
			btnAktualizuj.MaximumSize = new Size(105, 25);
			btnAktualizuj.Name = "btnAktualizuj";
			btnAktualizuj.Size = new Size(105, 25);
			btnAktualizuj.TabIndex = 17;
			btnAktualizuj.Text = "Aktualizuj";
			btnAktualizuj.UseVisualStyleBackColor = true;
			btnAktualizuj.Click += btnAktualizuj_Click;
			// 
			// btnShowAll
			// 
			btnShowAll.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			btnShowAll.Location = new Point(470, 110);
			btnShowAll.MaximumSize = new Size(155, 25);
			btnShowAll.MinimumSize = new Size(105, 25);
			btnShowAll.Name = "btnShowAll";
			btnShowAll.Size = new Size(155, 25);
			btnShowAll.TabIndex = 18;
			btnShowAll.Text = "Pokaż wszystkich";
			btnShowAll.UseVisualStyleBackColor = true;
			btnShowAll.Click += btnShowAll_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(11F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Silver;
			ClientSize = new Size(844, 461);
			Controls.Add(btnShowAll);
			Controls.Add(btnAktualizuj);
			Controls.Add(label2);
			Controls.Add(DepertmentTextBox);
			Controls.Add(SearchBox);
			Controls.Add(label1);
			Controls.Add(dgvStudentsList);
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
		private DataGridView dgvStudentsList;
		private Button btnClearStudentsList;
		private Panel panel1;
		private Label label1;
		private TextBox SearchBox;
		private Button button1;
		private Label label2;
		private TextBox DepertmentTextBox;
		private Button btnAktualizuj;
		private Button btnShowAll;
	}
}
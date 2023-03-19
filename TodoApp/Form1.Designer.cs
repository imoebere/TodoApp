namespace TodoApp
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
			components = new System.ComponentModel.Container();
			label1 = new Label();
			btnAdd = new Button();
			label2 = new Label();
			txtList = new TextBox();
			label3 = new Label();
			txtSearch = new TextBox();
			btnDelete = new Button();
			btnEdit = new Button();
			cSharpCodeProviderBindingSource = new BindingSource(components);
			cSharpCodeProviderBindingSource1 = new BindingSource(components);
			dataGridView1 = new DataGridView();
			dataGridViewCheckBoxColumn2 = new DataGridViewCheckBoxColumn();
			dBBindingSource = new BindingSource(components);
			dbFunctionBindingSource = new BindingSource(components);
			lblRecord = new Label();
			btnRefresh = new Button();
			Check = new DataGridViewCheckBoxColumn();
			Tasks = new DataGridViewTextBoxColumn();
			dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
			Task = new DataGridViewTextBoxColumn();
			txtDelete = new TextBox();
			txtNote = new RichTextBox();
			label4 = new Label();
			label5 = new Label();
			((System.ComponentModel.ISupportInitialize)cSharpCodeProviderBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)cSharpCodeProviderBindingSource1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dBBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)dbFunctionBindingSource).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = SystemColors.ActiveCaption;
			label1.Font = new Font("Arial", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label1.Location = new Point(166, -1);
			label1.Name = "label1";
			label1.Size = new Size(345, 34);
			label1.TabIndex = 0;
			label1.Text = "MY TODO APPLICATION";
			// 
			// btnAdd
			// 
			btnAdd.BackColor = Color.FromArgb(0, 192, 0);
			btnAdd.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnAdd.Location = new Point(391, 202);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(66, 33);
			btnAdd.TabIndex = 1;
			btnAdd.Text = "SAVE";
			btnAdd.UseVisualStyleBackColor = false;
			btnAdd.Click += btnSignUp_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(166, 36);
			label2.Name = "label2";
			label2.Size = new Size(57, 22);
			label2.TabIndex = 2;
			label2.Text = "Title:";
			label2.TextAlign = ContentAlignment.TopCenter;
			// 
			// txtList
			// 
			txtList.Location = new Point(276, 36);
			txtList.Multiline = true;
			txtList.Name = "txtList";
			txtList.Size = new Size(181, 22);
			txtList.TabIndex = 3;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(166, 243);
			label3.Name = "label3";
			label3.Size = new Size(83, 22);
			label3.TabIndex = 6;
			label3.Text = "Search:";
			label3.TextAlign = ContentAlignment.TopCenter;
			// 
			// txtSearch
			// 
			txtSearch.Location = new Point(265, 243);
			txtSearch.Multiline = true;
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(221, 22);
			txtSearch.TabIndex = 7;
			txtSearch.TextChanged += txtSearch_TextChanged;
			// 
			// btnDelete
			// 
			btnDelete.BackColor = Color.Red;
			btnDelete.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnDelete.Location = new Point(505, 468);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(87, 29);
			btnDelete.TabIndex = 8;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = false;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnEdit
			// 
			btnEdit.BackColor = SystemColors.ActiveCaption;
			btnEdit.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnEdit.Location = new Point(609, 236);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(87, 29);
			btnEdit.TabIndex = 9;
			btnEdit.Text = "Edit";
			btnEdit.UseVisualStyleBackColor = false;
			btnEdit.Click += btnEdit_Click;
			// 
			// cSharpCodeProviderBindingSource
			// 
			cSharpCodeProviderBindingSource.DataSource = typeof(Microsoft.CSharp.CSharpCodeProvider);
			// 
			// cSharpCodeProviderBindingSource1
			// 
			cSharpCodeProviderBindingSource1.DataSource = typeof(Microsoft.CSharp.CSharpCodeProvider);
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewCheckBoxColumn2 });
			dataGridView1.Location = new Point(0, 265);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(696, 205);
			dataGridView1.TabIndex = 10;
			// 
			// dataGridViewCheckBoxColumn2
			// 
			dataGridViewCheckBoxColumn2.HeaderText = "Check";
			dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
			// 
			// dBBindingSource
			// 
			dBBindingSource.DataSource = typeof(DB);
			// 
			// dbFunctionBindingSource
			// 
			dbFunctionBindingSource.DataSource = typeof(DbFunction);
			// 
			// lblRecord
			// 
			lblRecord.AutoSize = true;
			lblRecord.Location = new Point(0, 473);
			lblRecord.Name = "lblRecord";
			lblRecord.Size = new Size(72, 15);
			lblRecord.TabIndex = 11;
			lblRecord.Text = "Total Record";
			// 
			// btnRefresh
			// 
			btnRefresh.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			btnRefresh.Location = new Point(600, 470);
			btnRefresh.Name = "btnRefresh";
			btnRefresh.Size = new Size(96, 30);
			btnRefresh.TabIndex = 12;
			btnRefresh.Text = "Refresh";
			btnRefresh.UseVisualStyleBackColor = true;
			btnRefresh.Click += btnRefresh_Click;
			// 
			// Check
			// 
			Check.HeaderText = "CheckBox";
			Check.Name = "Check";
			// 
			// Tasks
			// 
			Tasks.HeaderText = "Task";
			Tasks.Name = "Tasks";
			// 
			// dataGridViewCheckBoxColumn1
			// 
			dataGridViewCheckBoxColumn1.HeaderText = "Check";
			dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
			// 
			// Task
			// 
			Task.HeaderText = "Task";
			Task.Name = "Task";
			// 
			// txtDelete
			// 
			txtDelete.Location = new Point(452, 472);
			txtDelete.Name = "txtDelete";
			txtDelete.Size = new Size(49, 23);
			txtDelete.TabIndex = 13;
			// 
			// txtNote
			// 
			txtNote.Location = new Point(276, 60);
			txtNote.Name = "txtNote";
			txtNote.Size = new Size(181, 139);
			txtNote.TabIndex = 14;
			txtNote.Text = "";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(166, 80);
			label4.Name = "label4";
			label4.Size = new Size(64, 22);
			label4.TabIndex = 15;
			label4.Text = "Note: ";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label5.Location = new Point(317, 473);
			label5.Name = "label5";
			label5.Size = new Size(129, 22);
			label5.TabIndex = 16;
			label5.Text = "Delete By ID:";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkGray;
			ClientSize = new Size(696, 497);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(txtNote);
			Controls.Add(txtDelete);
			Controls.Add(btnRefresh);
			Controls.Add(lblRecord);
			Controls.Add(dataGridView1);
			Controls.Add(btnEdit);
			Controls.Add(btnDelete);
			Controls.Add(txtSearch);
			Controls.Add(label3);
			Controls.Add(txtList);
			Controls.Add(label2);
			Controls.Add(btnAdd);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)cSharpCodeProviderBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)cSharpCodeProviderBindingSource1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)dBBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)dbFunctionBindingSource).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button btnAdd;
		private Label label2;
		private TextBox txtList;
		private Label label3;
		private TextBox txtSearch;
		private Button btnDelete;
		private Button btnEdit;
		private BindingSource cSharpCodeProviderBindingSource;
		private BindingSource cSharpCodeProviderBindingSource1;
		private DataGridView dataGridView1;
		private Label lblRecord;
		private Button btnRefresh;
		private BindingSource dbFunctionBindingSource;
		private BindingSource dBBindingSource;
		private DataGridViewCheckBoxColumn Check;
		private DataGridViewTextBoxColumn Tasks;
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
		private DataGridViewTextBoxColumn Task;
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
		private TextBox txtDelete;
		private RichTextBox txtNote;
		private Label label4;
		private Label label5;
		//private BindingSource bindingSource1;
	}
}
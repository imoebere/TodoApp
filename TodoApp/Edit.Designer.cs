namespace TodoApp
{
	partial class Edit
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnUpdate = new Button();
			comboBox1 = new ComboBox();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			txtEdit = new TextBox();
			SuspendLayout();
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(164, 156);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(80, 39);
			btnUpdate.TabIndex = 11;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(127, 55);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(117, 23);
			comboBox1.TabIndex = 10;
			comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(43, 110);
			label3.Name = "label3";
			label3.Size = new Size(66, 15);
			label3.TabIndex = 9;
			label3.Text = "Update List";
			//label3.Click += label3_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = SystemColors.ActiveCaption;
			label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = SystemColors.ActiveCaptionText;
			label2.Location = new Point(60, 9);
			label2.Name = "label2";
			label2.Size = new Size(169, 29);
			label2.TabIndex = 8;
			label2.Text = "UPDATE LIST";
			//label2.Click += label2_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(43, 63);
			label1.Name = "label1";
			label1.Size = new Size(55, 15);
			label1.TabIndex = 7;
			label1.Text = "Select ID:";
			//label1.Click += label1_Click;
			// 
			// txtEdit
			// 
			txtEdit.Location = new Point(127, 102);
			txtEdit.Name = "txtEdit";
			txtEdit.Size = new Size(117, 23);
			txtEdit.TabIndex = 6;
			txtEdit.TextChanged += txtEdit_TextChanged;
			// 
			// Edit
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(338, 210);
			Controls.Add(btnUpdate);
			Controls.Add(comboBox1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txtEdit);
			Name = "Edit";
			Text = "Edit";
			Load += Edit_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnUpdate;
		private ComboBox comboBox1;
		private Label label3;
		private Label label2;
		private Label label1;
		private TextBox txtEdit;
	}
}
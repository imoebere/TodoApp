
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TodoApp
{
	public partial class Form1 : Form
	{

		private readonly IDbFunction _dbFunction;
		DB db = new DB();
		public Form1()
		{
			InitializeComponent();
			_dbFunction = new DbFunction(db);
		}


		private void btnSignUp_Click(object sender, EventArgs e)
		{
			try
			{
				var name = this.txtList.Text.Trim();
				var note = this.txtNote.Text.Trim();
				if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(note))
				{
					MessageBox.Show("Field shouldn't be empty.");
				}
				else if (int.TryParse(name, out _))
				{
					txtList.Clear();
					//txtNote.Clear();
					throw new ArgumentException("List item should not be an integer.");
				}
				else
				{
					string sql = "INSERT INTO TblTodo (list, note) VALUES('" + name + "','" + note + "')";
					var output = _dbFunction.Execute(sql);
					if (output)
					{
						MessageBox.Show("Added Successful");
						dataForem();
						txtList.Clear();
						txtNote.Clear();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			dataForem();

		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			var update = new Edit();
			update.ShowDialog();
		}
		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				int id = Convert.ToInt32(txtDelete.Text);
				if ((id == 0) || (id == null))
					MessageBox.Show($"Field can not be zero Or Empty");
				var output = _dbFunction.Delete(id);
				if (output)
					MessageBox.Show("Deleted Successfully");
				else
					MessageBox.Show("Record Not found!");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}


		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			try
			{
				string search = txtSearch.Text;
				var dtb = _dbFunction.SearchRecord(search);
				dataGridView1.DataSource = dtb;
				lblRecord.Text = $"Total Records: {dataGridView1.RowCount - 1}";
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}

		public void dataForem()
		{
			var table = _dbFunction.GetRecord();
			dataGridView1.DataSource = table;
			lblRecord.Text = $"Total Records: {dataGridView1.RowCount - 1}";
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			dataForem();
		}
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			dataForem();
		}
	}
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace TodoApp
{
	public partial class Edit : Form
	{

		DB db = new DB();
		public Edit()
		{
			InitializeComponent();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Combobox();
		}
		public void Combobox()
		{
			SqlConnection conn = null;
			string query = "SELECT id FROM TblTodo";
			try
			{
				conn = db.Connector();
				SqlCommand command = new SqlCommand(query, conn);
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					comboBox1.Items.Add(reader["id"].ToString());
				}
				reader.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}
		public void EditTextBox()
		{
			SqlConnection con = null;
			var id = comboBox1.SelectedIndex;
			var sql = "SELECT list FROM TblTodo WHERE id = @id";
			try
			{
				con = db.Connector();
				SqlCommand cmd = new SqlCommand(sql, con);
				cmd.Parameters.AddWithValue("@id", id);
				//var result = cmd.ExecuteNonQuery();
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read())
				{
					txtEdit.Text = reader["list"].ToString();
				}
				reader.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error : {ex.Message}");
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{

		}

		private void txtEdit_TextChanged(object sender, EventArgs e)
		{
			//EditTextBox();
		}

		private void Edit_Load(object sender, EventArgs e)
		{
			Combobox();
			EditTextBox();
		}
	}
}

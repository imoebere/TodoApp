using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TodoApp;
using System.Data;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Drawing;
using System.Data.Common;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace TodoApp
{
	public class DbFunction : IDbFunction
	{
		private readonly IDB _db;

		public DbFunction(IDB db)
		{
			_db = db;
		}
		public  DataTable GetRecord()
		{
				SqlConnection conn = _db.Connector();
				string sql = "SELECT * FROM TblTodo";
				SqlCommand cmd = new SqlCommand(sql, conn);
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				DataTable table = new DataTable();
				adapter.Fill(table);

				return table;
		}
		public bool Execute(string sql)
		{
			SqlConnection conn = null;
			try
			{
				//get connection
				conn = _db.Connector();
				SqlCommand cmd = new SqlCommand(sql, conn);
				var result = cmd.ExecuteNonQuery();
				if (result > 0)
				{
					return true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: { ex.Message}");
			}
			finally
			{
				conn.Close();
			}
			return false;
		}

		public bool Delete(int id)
		{
			SqlConnection conn = null;
			string sql = "DELETE FROM TblTodo WHERE id = @id";
			try
			{
				conn = _db.Connector();
				using (SqlCommand command = new SqlCommand(sql, conn))
				{
					command.Parameters.AddWithValue("@id", id);
					int rowsAffected = command.ExecuteNonQuery();
					if (rowsAffected > 0)
						return true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
			return false;

		}
	

		public DataTable SearchRecord(string search)
		{
				SqlConnection conn = _db.Connector();
				string sql = "SELECT * FROM TblTodo WHERE list = @search";
				SqlCommand cmd = new SqlCommand(sql, conn);
				SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
				cmd.Parameters.AddWithValue("@search", search);
				DataTable dt = new DataTable();
				dataAdapter.Fill(dt);
				
				return dt;
			
		}
	}
}



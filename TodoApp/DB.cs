using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
	public class DB : IDB
	{
		public static string connectString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=ToDo_db;Integrated Security=True";

		public SqlConnection Connector()
		{
			SqlConnection conn = new SqlConnection(connectString);
			conn.Open();
			return conn;
		}
	}	
	
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
	public interface IDbFunction
	{
		public bool Execute(string sql);
		public bool Delete(int id);
		//public bool DeleteSelected(int[] id);
		//public bool Edit(int id);
		public DataTable SearchRecord(string search);
		public DataTable GetRecord();
	}
}

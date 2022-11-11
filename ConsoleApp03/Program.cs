using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp03
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string sql = @"INSERT INTO News(Title, vContent, ModifyTime)VALUES(@Title, @vContent, getdate())";
			var dbHelper = new SqlDbHelper("default");
			try
			{
				var parameters = new SqlParameterBuilder()
					.AddNVarchar("title", 50, "xx")
					.AddNVarchar("vContent", 3000, "xxxxxx")
					.Build();

				dbHelper.ExecuteNonQuery(sql, parameters);

				Console.WriteLine("記錄已新增");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"操作失敗, 原因 :{ex.Message}");
			}

		}
	}

	
}

using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp06
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string sql = @"DELETE FROM News WHERE Id=@Id";

			var dbHelper = new SqlDbHelper("default");
			try
			{
				var parameters = new SqlParameterBuilder()
					.AddNInt("id", 2)
					.Build();

				dbHelper.ExecuteNonQuery(sql, parameters);

				Console.WriteLine("記錄已 delete");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"操作失敗, 原因 :{ex.Message}");
			}
		}
	}
}

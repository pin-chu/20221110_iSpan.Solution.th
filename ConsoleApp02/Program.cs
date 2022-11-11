using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp02
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string connString = System.Configuration.ConfigurationManager.ConnectionStrings["default"].ConnectionString;
			Console.WriteLine(connString);

			#region 不使用 using

			var conn2 = new SqlConnection(connString);
			try
			{
				conn2.Open();
				//.....

			}
			catch (Exception ex)
			{
				//...
			}
			finally
			{
				if (conn2 != null)
				{
					conn2.Dispose(); // 叫用 Dispose時,會一併關閉資料庫連線
				}

			}

			#endregion

			#region 使用 using

			using (var conn = new SqlConnection(connString))
			{
				try
				{
					conn.Open(); // 連結到指定的sql server
					Console.WriteLine("連線成功");
				}
				catch (Exception ex)
				{
					Console.WriteLine($"連線失敗, 原因 :{ex.Message}");
				}
			}

			#endregion
		}
	}
}

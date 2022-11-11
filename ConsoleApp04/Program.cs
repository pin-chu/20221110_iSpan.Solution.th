using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp04
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string title = "tt";
			string content = "');Drop table News     --ccc";

			string sql = $"INSERT INTO News(Title, vContent)VALUES('{title}','{content}')";
			// INSERT INTO News(Title, vContent)VALUES('tt','');Drop table News     --ccc')
		}
	}
}

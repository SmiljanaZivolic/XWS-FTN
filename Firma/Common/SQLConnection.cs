using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
	public class SQLConnection
	{
		public static string ConnectionString
		{
			get { return @"Data Source=DESKTOP-4IDNJLN\SQLEXPRESS;Initial Catalog=XWS;Integrated Security=True"; }
		}
	}
}

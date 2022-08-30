namespace Dolores.Config
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;
	using Dolores.Authentication;

	public class AppSettings
	{
		public string ConnString { get; set; }
		public JwtSettings JwtSettings { get; set; }
	}
}

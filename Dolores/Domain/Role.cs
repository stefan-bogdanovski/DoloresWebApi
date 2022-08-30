namespace Domain
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class Role : Entity
	{
		public string Name { get; set; }

		public virtual ICollection<User> User { get; set; } = new HashSet<User>();
	}
}

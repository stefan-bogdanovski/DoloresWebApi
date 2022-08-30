namespace Domain
{
	using System.Collections.Generic;

	public class Brand : Entity
	{
		public string Name { get; set; }

		public virtual ICollection<Perfume> Perfumes { get; set; } = new List<Perfume>();
	}
}

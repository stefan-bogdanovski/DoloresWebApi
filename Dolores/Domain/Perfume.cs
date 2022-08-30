namespace Domain
{
	using System.Collections.Generic;

	public class Perfume : Entity
	{ 
		public string Name { get; set; }
		public int BrandId { get; set; }

		public virtual Brand Brand { get; set; }
		public virtual ICollection<PerfumeSizes> Sizes { get; set; } = new HashSet<PerfumeSizes>();
	}
}

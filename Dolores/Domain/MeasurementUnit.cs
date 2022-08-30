namespace Domain
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class MeasurementUnit : Entity
	{
		public string Unit { get; set; }

		public virtual ICollection<Size> Sizes { get; set; } = new HashSet<Size>();
	}
}
